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
    public partial class Stars : Form, IFormInterface
    {
        public List<StarData> deletedStarsInThisSessionList { get; set; } = new List<StarData> { };
        public StarData currStar { get; set; } = null;

        public string context { get; set; } = "Star";

        public Stars()
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
                    btn_Star.Enabled = false;
                }
                else
                {
                    btn_Star.Enabled = true;
                }
            }
            else
            {
                TextChangedBTNAddUpdateCheck(sender, e);
            }
        }

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); TextChangedBTNAddUpdateCheck(null, null); ComboBox_OrbitMode_SelectedIndexChanged(null, null); }

        //updates orbitables list
        private void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            ComboBox_FocusID.Items.Add("");

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(getSystem());

            if (orbitables == null) return;

            if (ComboBox_Stars.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {
                if (orbitables.Contains(Helper.GetStarWithID(ComboBox_Stars.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetStarWithID(ComboBox_Stars.SelectedItem.ToString()));
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

            item.WhatIsThis = Finals.STAR;
        }

        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            ComboBox_OrbitMode.SelectedItem = item.orbitLocationMode;

            foreach (var comboboxItem in ComboBox_FocusID.Items)//scroll through the list of items in the focusables
            {
                if (Helper.IDWithNameToID(comboboxItem.ToString()) == item.focusID)//if the focusables name is equal to the items focus
                {
                    ComboBox_FocusID.SelectedIndex = ComboBox_FocusID.Items.IndexOf(comboboxItem);//then make selected index be the comboboxItem which is what were looking for 
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

        private void Load()
        {
            LoadSystems();
            ComboBox_Stars.Items.Clear();

            ComboBox_Stars.Items.Add("New " + context);
            ComboBox_Stars.SelectedItem = "New " + context;

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Stars.Items.AddRange(
                    Helper.IDNameList(//turns systems into id + name list for the combo box
                        Helper.ListUpcasting(//turn star list to extend
                            Helper.GetSystemFromID(//get system with id (it automatically removes name)
                                ComboBox_Systems.SelectedItem.ToString()//selected star systems id + name
                                )
                            .starList.ToArray()))//get stars in the selected system
                    .ToArray());
            }

            ComboBox_OrbitMode.Items.Clear();

            ComboBox_OrbitMode.Items.AddRange(new object[] { 0, 1, 2, 3 });

            ComboBox_OrbitMode.SelectedItem = 0;

            loadOrbits();


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

        private void update(StarData star)
        {
            updateExtends(star);

            nud_Radius.Value = (decimal)star.radius;
            nud_CoronaSize.Value = (decimal)star.coronaSize;

        }

        private void reset()
        {


            resetExtend();

            nud_Radius.Value = 0;
            nud_CoronaSize.Value = 0;
        }

        private StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        private StarData getData()
        {
            StarData gettenStar = new StarData();

            addExtendValues(gettenStar);

            gettenStar.systemID = ComboBox_Systems.SelectedItem.ToString();

            gettenStar.radius = (float)nud_Radius.Value;
            gettenStar.coronaSize = (float)nud_CoronaSize.Value;

            return gettenStar;
        }

        private string getID()
        {
            if (ComboBox_Stars.SelectedItem != null)
            {
                return ComboBox_Stars.SelectedItem.ToString();
            }

            return null;
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

            ComboBox_Stars.SelectedItem = starToAdd.ID + " - " + starToAdd.name;//select the added star
        }

        #endregion

        #region formFunction

        //adds / updates star
        private void btn_AddStar_Click(object sender, EventArgs e)
        {
            if (btn_Star.Text == "Add " + context)
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

                ComboBox_Stars.SelectedItem = updatedStar.ID + " - " + updatedStar.name;//select updated system

                currStar = updatedStar;//set current star to updated star

            }
        }

        //checks for required stuff like ids or parent system
        private void TextChangedBTNAddUpdateCheck(object sender, EventArgs e)
        {
            if (
                tb_ID.Text == "" ||
                tb_TypeID.Text == "" ||
                ComboBox_Systems.SelectedItem == null ||
                ComboBox_Systems.SelectedItem.ToString() == ""
                )
            {
                btn_Star.Enabled = false;
            }
            else
            {
                btn_Star.Enabled = true;
            }
        }

        //star selection
        private void ComboBox_Stars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Stars.SelectedItem.ToString() == "New " + context)
            {
                btn_Star.Text = "Add " + context;

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_Stars.SelectedItem != null)
            {
                string selectedID = ComboBox_Stars.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                StarData Star = Helper.GetStarOnSystem(systemID, selectedID);//get star in the system

                update(Star);// update the star with variables

                currStar= Star;

                btn_Star.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { TextChangedBTNAddUpdateCheck(null, null); }


        private void btn_Delete_Click(object sender, EventArgs e)
        {

            StarData starToDelete = Helper.GetStarWithID(getID());//gets the star

            deletedStarsInThisSessionList.Add(starToDelete);//add it to deleteds list

            ItemEditingAdding.DeleteStar(starToDelete);//delete it

            Load();//reload

            reset();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {

            if (deletedStarsInThisSessionList.Count() == 0) { return; }

            StarData lastDeletedItem = deletedStarsInThisSessionList.ElementAt(deletedStarsInThisSessionList.Count() - 1);

            if (Helper.DoesStarIDExist(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }


            update(lastDeletedItem);

            AddStar();

            deletedStarsInThisSessionList.RemoveAt(deletedStarsInThisSessionList.Count() - 1);



        }

        private void btn_Clone_Click(object sender, EventArgs e)
        {
            tb_ID.Text += " / " + Guid.NewGuid().ToString().Substring(0, 4);

            AddStar();
        }

        #endregion


    }
}
