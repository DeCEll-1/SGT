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
    public partial class Planets : Form, IFormInterface
    {

        public List<PlanetData> deletedPlanetsInThisSessionList { get; set; } = new List<PlanetData>();
        public PlanetData currPlanet { get; set; } = null;

        public string context { get; set; } = "Planet";

        public Planets()
        {
            InitializeComponent();
            UpdateColors();
            Load();
        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        #region focusStuff

        //orbit mode selection
        private void ComboBox_OrbitMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetOrbit();
            byte orbitMode = Convert.ToByte(ComboBox_OrbitMode.SelectedItem.ToString());

            switch (orbitMode)//i dont have any idea on how switches work i work with ifs but why not go fancy when i got the chance
            {

                case 0://if orbit mode is 0 aka only coordinates

                    nud_X.Enabled = true;
                    nud_Y.Enabled = true;

                    break;//w3 schools says we need a break here but why? cant it just end when it hits the other piece?
                case 1:

                    ComboBox_FocusID.Enabled = true;

                    nud_Angle.Enabled = true;
                    nud_OrbitDays.Enabled = true;
                    nud_OrbitRadius.Enabled = true;

                    break;
                case 2://1 but pointing down

                    ComboBox_FocusID.Enabled = true;

                    nud_Angle.Enabled = true;
                    nud_OrbitDays.Enabled = true;
                    nud_OrbitRadius.Enabled = true;


                    break;

                case 3://max-min spin

                    ComboBox_FocusID.Enabled = true;

                    nud_Angle.Enabled = true;
                    nud_OrbitDays.Enabled = true;
                    nud_OrbitRadius.Enabled = true;

                    nud_MinSpin.Enabled = true;
                    nud_MaxSpin.Enabled = true;

                    break;

                default:
                    break;
            }


            if (orbitMode != 0)
            {
                if (
                    ComboBox_FocusID.SelectedItem == null ||
                    ComboBox_FocusID.SelectedItem.ToString() == ""
                   )
                {
                    btn_Planet.Enabled = false;
                }
                else
                {
                    btn_Planet.Enabled = true;
                }
            }
            else
            {
                TextChangedBTNAddUpdateCheck(sender, e);
            }
        }

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); }

        //updates orbitables list
        private void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            ComboBox_FocusID.Items.Add("");

            StarSystemData system = getSystem();

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(system);

            if (orbitables == null) return;

            if (ComboBox_Planets.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {//excludes the selected id from the orbiting list (it cant orbit around itself, cope more)
                if (orbitables.Contains(Helper.GetPlanetWithID(ComboBox_Planets.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetPlanetWithID(ComboBox_Planets.SelectedItem.ToString()));
                }
            }

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());
        }

        //adds extend values to the item, like id or type id or focus or bla bla
        private void addExtendValues(Extend item)
        {
            item.orbitLocationMode = Convert.ToInt32(ComboBox_OrbitMode.SelectedItem);

            if (item.orbitLocationMode != 0) item.focusID = Helper.IDWithNameToID(ComboBox_FocusID.SelectedItem.ToString());
            //if focus id isnt set then dont add it for not crashing
            //if no focus itll use x or y or whatever

            item.x = (float)nud_X.Value;
            item.y = (float)nud_Y.Value;

            item.angle = (float)nud_Angle.Value;
            item.orbitRadius = (float)nud_OrbitRadius.Value;
            item.orbitDays = (float)nud_OrbitDays.Value;

            item.minSpin = (float)nud_MinSpin.Value;
            item.maxSpin = (float)nud_MaxSpin.Value;

            item.ID = tb_ID.Text;
            item.name = tb_Name.Text;
            item.typeID = tb_TypeID.Text;

            item.WhatIsThis = Finals.PLANET;
        }

        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            loadOrbits();

            ComboBox_OrbitMode.SelectedItem = item.orbitLocationMode;

            foreach (var comboboxItem in ComboBox_FocusID.Items)//scroll through the list of items in the focusables
            {
                if (Helper.IDWithNameToID(comboboxItem.ToString()) == item.focusID)//if the focusables name is equal to the items focus
                {
                    ComboBox_FocusID.SelectedIndex = ComboBox_FocusID.Items.IndexOf(comboboxItem.ToString());//then make selected index be the comboboxItem which is what were looking for 
                    break;
                }
            }

            ComboBox_FocusID.SelectedText = item.focusID;

            nud_X.Value = (int)item.x;
            nud_Y.Value = (int)item.y;

            nud_Angle.Value = (int)item.angle;
            nud_OrbitRadius.Value = (int)item.orbitRadius;
            nud_OrbitDays.Value = (int)item.orbitDays;

            nud_MinSpin.Value = (int)item.minSpin;
            nud_MaxSpin.Value = (int)item.maxSpin;

            tb_ID.Text = item.ID;
            tb_Name.Text = item.name;
            tb_TypeID.Text = item.typeID;

            lbl_Order.Text = "Load Order: " + item.order;

            StringBuilder sb = new StringBuilder();

            foreach (string stuffOrbitingAround in item.stuffOrbitingAround)
            {
                sb.Append(stuffOrbitingAround + "\n");
            }

            lbl_StuffOrbitingAround.Text = "Stuff Orbiting Around :\n" + sb.ToString();
        }

        //reset extend elements on the form to default values
        private void resetExtend()
        {
            ComboBox_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New " + context;//change this in different forms

            resetOrbit();

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_TypeID.Text = "";
        }

        //resets orbit values to the defaults, resetExtend alredy uses this so dont need to run this too
        private void resetOrbit()
        {
            nud_X.Value = -1;
            nud_X.Enabled = false;

            nud_Y.Value = -1;
            nud_Y.Enabled = false;

            nud_Angle.Value = -1;
            nud_Angle.Enabled = false;

            nud_OrbitRadius.Value = -1;
            nud_OrbitRadius.Enabled = false;

            nud_OrbitDays.Value = -1;
            nud_OrbitDays.Enabled = false;

            nud_MinSpin.Value = -1;
            nud_MinSpin.Enabled = false;

            nud_MaxSpin.Value = -1;
            nud_MaxSpin.Enabled = false;

            ComboBox_FocusID.Enabled = false;

            loadOrbits();

            ComboBox_FocusID.SelectedIndex = 0;


        }

        #endregion

        #region customFunctions

        //system list refresh
        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { TextChangedBTNAddUpdateCheck(null, null); UpdatePlanets(); }

        private void TextChangedBTNAddUpdateCheck(object sender, EventArgs e)
        {
            if (
               tb_ID.Text == "" ||
               tb_TypeID.Text == "" ||
               ComboBox_Systems.SelectedItem == null ||
               ComboBox_Systems.SelectedItem.ToString() == ""
               )
            {
                btn_Planet.Enabled = false;
            }
            else
            {
                btn_Planet.Enabled = true;
            }
        }

        private void Load()
        {
            LoadSystems();
            ComboBox_Planets.Items.Clear();

            ComboBox_Planets.Items.Add("New " + context);
            ComboBox_Planets.SelectedItem = "New " + context;

            if (ComboBox_Systems.Items.Count != 0)
            {
                UpdatePlanets();
            }

            ComboBox_OrbitMode.Items.Clear();

            ComboBox_OrbitMode.Items.AddRange(new object[] { 0, 1, 2, 3 });

            ComboBox_OrbitMode.SelectedItem = 0;

            loadOrbits();
        }

        private void UpdatePlanets()
        {

            ComboBox_Planets.Items.Clear();

            try
            {
                //use the numbers for read order
                ComboBox_Planets.Items.AddRange(
                    Helper.IDNameList(//turns systems into id + name list for the combo box / 5
                        Helper.ListUpcasting(//turn planet list to extend list / 4
                            Helper.GetSystemFromID(//get system object with id (it automatically removes name from id + name) / 2
                                ComboBox_Systems.SelectedItem.ToString()//get selected systems id + name / 1
                                )
                            .planetList.ToArray()))//get planets in the selected system / 3
                    .ToArray());//to array because add range adds arrays and not list, just a minor inconvenience
            }
            catch (Exception ex)
            {
            }

        }

        private void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.BaseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }

        }

        private void update(PlanetData planetData)
        {

            updateExtends(planetData);

            nud_Radius.Value = (decimal)planetData.radius;

            currPlanet = planetData;
        }

        private void reset()
        {
            resetExtend();

            nud_Radius.Value = 0;
        }

        private StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        private PlanetData getData()
        {
            PlanetData gettenPlanet = new PlanetData();

            addExtendValues(gettenPlanet);

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

            planetToAdd.systemGUID = getSystem().GUID;

            ItemEditingAdding.AddPlanet(planetToAdd);//add the planet to the system

            currPlanet = planetToAdd;

            Load();

            ComboBox_Planets.SelectedItem = planetToAdd.ID + " - " + planetToAdd.name;//select the added planet
        }

        private string getID()
        {
            if (ComboBox_Planets.SelectedItem != null)
            {
                return ComboBox_Planets.SelectedItem.ToString();
            }

            return "";
        }


        #endregion

        #region formStuff

        //planet add / update
        private void btn_Planet_Click(object sender, EventArgs e)
        {
            if (btn_Planet.Text == "Add " + context)
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

                ComboBox_Planets.SelectedItem = updatedPlanet.ID + " - " + updatedPlanet.name;//select updated system

                currPlanet = updatedPlanet;//set current star to updated star


            }
        }

        private void ComboBox_Planets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Planets.SelectedItem.ToString() == "New " + context)
            {
                btn_Planet.Text = "Add " + context;

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_Planets.SelectedItem != null)
            {
                string selectedID = ComboBox_Planets.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                PlanetData planet = Helper.GetPlanetOnSystem(systemID, selectedID);//get star in the system

                update(planet);// update the star with variables

                btn_Planet.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            PlanetData planetToDelete = Helper.GetPlanetWithID(getID());

            deletedPlanetsInThisSessionList.Add(planetToDelete);

            ItemEditingAdding.DeletePlanet(planetToDelete);

            Load();

            reset();

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedPlanetsInThisSessionList.Count() == 0) { return; }

            PlanetData lastDeletedItem = deletedPlanetsInThisSessionList.ElementAt(deletedPlanetsInThisSessionList.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            update(lastDeletedItem);

            AddPlanet();

            deletedPlanetsInThisSessionList.RemoveAt(deletedPlanetsInThisSessionList.Count() - 1);
        }

        private void btn_PlanetsRefresh_Click(object sender, EventArgs e) { UpdatePlanets(); }

        private void btn_Clone_Click(object sender, EventArgs e)
        {
            tb_ID.Text += " / " + Guid.NewGuid().ToString().Substring(0, 4);

            AddPlanet();

        }

        #endregion


    }
}
