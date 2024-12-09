using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Planets : OrbitableMaster, IFormInterface
    {

        public List<PlanetData> deletedPlanetsInThisSessionList { get; set; } = new List<PlanetData>();
        public PlanetData currPlanet { get; set; } = null;

        public Planets()
        {
            InitializeComponent();
            context = "Planet";
            Load();
        }

        #region customFunctions
        internal override void Load()
        {
            base.Load();
        }
        internal override void UpdateForm(Extend extend)
        {
            PlanetData planet = extend as PlanetData;
            base.UpdateForm(planet);

            nud_Radius.Value = (decimal)planet.radius;
        }
        internal override void Reset()
        {
            base.Reset();

            nud_Radius.Value = 0;
        }
        private PlanetData getData()
        {
            PlanetData gettenPlanet = new PlanetData();

            AddExtendValuesFromForm(gettenPlanet, Finals.PLANET);

            gettenPlanet.systemID = ComboBox_Systems.SelectedItem.ToString();

            gettenPlanet.radius = (float)nud_Radius.Value;

            return gettenPlanet;
        }
        private void AddPlanet()
        {
            PlanetData planetToAdd = getData();//get planet 

            if (Helper.DoesIDExists(planetToAdd.ID))//if planet with same id exists
            {
                MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            planetToAdd.systemGUID = GetSystem().GUID;

            ItemEditingAdding.AddPlanet(planetToAdd);//add the planet to the system

            currPlanet = planetToAdd;

            Load();

            ComboBox_Selectables.SelectedItem = planetToAdd.ID + " - " + planetToAdd.name;//select the added planet
        }
        #endregion
        #region triggers
        internal override void SelectablesIndexChanged()
        { // runs when the selectable is changed
            // we do shit like fkn, idk, update the form with shit gotten from the selected index
            if (ComboBox_Selectables.SelectedItem.ToString() == "New " + context)
            {
                btn_Add.Text = "Add " + context;

                btn_Delete.Enabled = false;

                Reset();
            }
            else if (ComboBox_Selectables.SelectedItem != null)
            {
                string selectedID = ComboBox_Selectables.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                PlanetData planet = Helper.GetPlanetOnSystem(systemID, selectedID);//get star in the system

                UpdateForm(planet);// update the star with variables

                btn_Add.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }
        internal override void btn_Add_Click(object sender, EventArgs e) {

            if (btn_Add.Text == "Add " + context)
            {
                AddPlanet();
            }
            else//update
            {

                PlanetData updatedPlanet = getData();//get planet 

                if (Helper.DoesIDExists(updatedPlanet.ID, currPlanet.ID))
                {
                    MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                updatedPlanet.GUID = currPlanet.GUID;//TODO check if you update curr planet on selected planet change

                updatedPlanet.systemGUID = Helper.GetSystemFromID(updatedPlanet.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

                ItemEditingAdding.UpdatePlanet(updatedPlanet);//update the planet

                Load();

                ComboBox_Selectables.SelectedItem = updatedPlanet.ID + " - " + updatedPlanet.name;//select updated system

                currPlanet = updatedPlanet;//set current star to updated star


            }

        }
        internal override void btn_Clone_Click(object sender, EventArgs e)
        {
            base.btn_Clone_Click(sender, e);
            AddPlanet();
        }
        internal override void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedPlanetsInThisSessionList.Count() == 0) { return; }

            PlanetData lastDeletedItem = deletedPlanetsInThisSessionList.ElementAt(deletedPlanetsInThisSessionList.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            UpdateForm(lastDeletedItem);

            AddPlanet();

            deletedPlanetsInThisSessionList.RemoveAt(deletedPlanetsInThisSessionList.Count() - 1);
        }
        internal override void btn_Delete_Click(object sender, EventArgs e)
        {
            PlanetData planetToDelete = Helper.GetPlanetWithID(GetID());

            deletedPlanetsInThisSessionList.Add(planetToDelete);

            ItemEditingAdding.DeletePlanet(planetToDelete);

            Load();

            Reset();
        }
        #endregion


    }
}
