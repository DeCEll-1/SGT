using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using SSSystemGenerator.Forms;
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

namespace SSSystemGenerator
{
    public partial class Stars : OrbitableMaster
    {
        public List<StarData> deletedStarsInThisSessionList { get; set; } = new List<StarData> { };
        public StarData currStar { get; set; } = null;

        public Stars() : base()
        {
            InitializeComponent();
            context = "Star";
            Load();
        }

        #region customFunctions
        internal override void Load()
        {
            base.Load();
        }

        internal override void UpdateForm(Extend extend)
        {
            StarData star = extend as StarData;
            base.UpdateForm(star);

            nud_Radius.Value = (decimal)star.radius;
            nud_CoronaSize.Value = (decimal)star.coronaSize;
        }

        internal override void Reset()
        {
            base.Reset();

            nud_Radius.Value = 0;
            nud_CoronaSize.Value = 0;
        }

        internal override void LoadTypes()
        {
            cb_TypeID.Items.Clear();
            cb_TypeID.Items.AddRange(
                Statics.CSVs.StarGenDatas
                .ToList() // list it
                .Select(s => s.id) // turn it into a list of ids
                .ToArray<object>() // array it
            );
        }
        private StarData getData()
        {
            StarData gettenStar = new StarData();

            AddExtendValuesFromForm(gettenStar, Finals.STAR);

            gettenStar.systemID = ComboBox_Systems.SelectedItem.ToString();

            gettenStar.radius = (float)nud_Radius.Value;
            gettenStar.coronaSize = (float)nud_CoronaSize.Value;

            return gettenStar;
        }

        private void AddStar()
        {
            StarData starToAdd = getData();//gets star

            if (Helper.DoesStarIDExist(starToAdd.ID))//does a star with the same id exist
            {
                MessageBox.Show(context + " ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            starToAdd.systemGUID = Helper.GetSystemFromID(starToAdd.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

            ItemEditingAdding.AddStar(starToAdd);//add the star to the system

            //currStar = Helper.GetStarOnSystem(starToAdd.systemID, starToAdd.ID);
            //why the fuck did i got the star like this? starToAdd is literally this anyways?

            currStar = starToAdd;

            Load();//reload cuz why not

            ComboBox_Selectables.SelectedItem = starToAdd.ID + " - " + starToAdd.name;//select the added star
        }

        #endregion

        #region triggers
        internal override void SelectablesIndexChanged()
        { // runs when the selectable is changed
            // we do shit like fkn, idk, update the form with shit gotten from the selected index
            if (ComboBox_Selectables.SelectedItem.ToString() == "New " + context)
            {
                btn_Add.Text = "Add " + context;
                btn_Delete.Text = "Delete " + context;

                btn_Delete.Enabled = false;

                Reset();
            }
            else if (ComboBox_Selectables.SelectedItem != null)
            {
                string selectedID = ComboBox_Selectables.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                StarData Star = Helper.GetStarOnSystem(systemID, selectedID);//get star in the system

                UpdateForm(Star);// update the star with variables

                currStar = Star;

                btn_Add.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }
        internal override void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text == "Add " + context)
            {
                AddStar();
            }
            else//update star
            {
                StarData updatedStar = getData();//get updated star

                updatedStar.GUID = currStar.GUID;//give currstars guid to updated to keep the guid same

                updatedStar.systemGUID = Helper.GetSystemFromID(updatedStar.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

                if (Helper.DoesStarIDExist(updatedStar.ID, currStar.ID))//should work? idk mayn my brain isnt working fuck politics
                {
                    MessageBox.Show(context + " ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                ItemEditingAdding.UpdateStar(updatedStar);//updates star

                Load();//reload (idr why)

                ComboBox_Selectables.SelectedItem = updatedStar.ID + " - " + updatedStar.name;//select updated system

                currStar = updatedStar;//set current star to updated star

            }
        }
        internal override void btn_Clone_Click(object sender, EventArgs e)
        {
            base.btn_Clone_Click(sender, e);
            AddStar();
        }
        internal override void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedStarsInThisSessionList.Count() == 0) { return; }

            StarData lastDeletedItem = deletedStarsInThisSessionList.ElementAt(deletedStarsInThisSessionList.Count() - 1);

            if (Helper.DoesStarIDExist(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }


            UpdateForm(lastDeletedItem);

            AddStar();

            deletedStarsInThisSessionList.RemoveAt(deletedStarsInThisSessionList.Count() - 1);
        }
        internal override void btn_Delete_Click(object sender, EventArgs e)
        {
            StarData starToDelete = Helper.GetStarWithID(GetID());//gets the star

            deletedStarsInThisSessionList.Add(starToDelete);//add it to deleteds list

            ItemEditingAdding.DeleteStar(starToDelete);//delete it

            Load();//reload

            Reset();
        }
        #endregion

    }
}
