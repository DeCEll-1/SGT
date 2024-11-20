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

            nud_MinSpin.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_MaxSpin.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_X.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_Y.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_Angle.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_OrbitRadius.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_OrbitDays.ValueChanged += TextChangedBTNAddUpdateCheck;
            tb_ID.TextChanged += TextChangedBTNAddUpdateCheck;
            tb_Name.TextChanged += TextChangedBTNAddUpdateCheck;
            tb_TypeID.TextChanged += TextChangedBTNAddUpdateCheck;

            Load();

        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        #region focusStuff

        //orbit mode selection
        private void ComboBox_OrbitMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetOrbit();

            string orbitMode = cb_OrbitMode?.SelectedItem?.ToString();
            if (orbitMode == null || orbitMode == "") orbitMode = "Fixed Location";

            switch (orbitMode)//i dont have any idea on how switches work i work with ifs but why not go fancy when i got the chance
            {

                case "Fixed Location"://if orbit mode is 0 aka only coordinates

                    nud_X.Visible = true;
                    nud_Y.Visible = true;
                    lbl_x.Visible = true;
                    lbl_y.Visible = true;



                    break;//w3 schools says we need a break here but why? cant it just end when it hits the other piece?
                case "Circular Orbit":

                    ComboBox_FocusID.Visible = true;

                    nud_Angle.Visible = true;
                    nud_OrbitRadius.Visible = true;
                    nud_OrbitDays.Visible = true;
                    cb_Spin.Visible = true;
                    cb_PointingDown.Visible = true;

                    lbl_Angle.Visible = true;
                    lbl_OrbitRadius.Visible = true;
                    lbl_OrbitDays.Visible = true;
                    lbl_Focus.Visible = true;

                    btn_FocusRefresh.Visible = true;



                    break;

                default:
                    break;
            }

            TextChangedBTNAddUpdateCheck(sender, e);
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


        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            cb_OrbitMode.SelectedItem = item.orbitLocationMode;

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
            cb_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New " + context;//change this in different forms

            resetOrbit();

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_TypeID.Text = "";
        }

        //resets orbit values to the defaults, resetExtend alredy uses this so dont need to run this too
        private void resetOrbit()
        {

            lbl_x.Visible = false;
            lbl_y.Visible = false;
            lbl_Angle.Visible = false;
            lbl_OrbitRadius.Visible = false;
            lbl_OrbitDays.Visible = false;
            lbl_MinSpin.Visible = false;
            lbl_MaxSpin.Visible = false;

            lbl_Focus.Visible = false;

            btn_FocusRefresh.Visible = false;


            nud_X.Visible = false;

            nud_Y.Visible = false;

            nud_Angle.Visible = false;

            nud_OrbitRadius.Visible = false;

            nud_OrbitDays.Visible = false;

            nud_MinSpin.Visible = false;

            nud_MaxSpin.Visible = false;

            ComboBox_FocusID.Visible = false;

            cb_Spin.Visible = false;
            cb_PointingDown.Visible = false;

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

            cb_OrbitMode.Items.Clear();

            cb_OrbitMode.Items.AddRange(new string[]
            {
                "Fixed Location",
                "Circular Orbit"
            });

            cb_OrbitMode.SelectedIndex = 0;

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

            Helper.AddExtendValues(gettenStar, cb_OrbitMode, cb_PointingDown, cb_Spin, ComboBox_FocusID,nud_X,nud_Y,nud_Angle,nud_OrbitRadius,nud_OrbitDays,nud_MinSpin,nud_MaxSpin,tb_ID,tb_Name, tb_TypeID);

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

        // spin visiblity change
        private void cb_Spin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Spin.Checked)
            {
                nud_MinSpin.Visible = true;
                nud_MaxSpin.Visible = true;

                lbl_MinSpin.Visible = true;
                lbl_MaxSpin.Visible = true;
            }
            else
            {
                nud_MinSpin.Visible = false;
                nud_MaxSpin.Visible = false;

                lbl_MinSpin.Visible = false;
                lbl_MaxSpin.Visible = false;
            }

            if (cb_Spin.Checked)
            {
                cb_PointingDown.Checked = false;
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

        private void SpinMinMan(object sender, EventArgs e)
        {

            if (nud_MaxSpin.Value < nud_MinSpin.Value)
            {
                nud_MaxSpin.Value = nud_MinSpin.Value;
            }

        }
        //star selection
        private void ComboBox_Stars_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
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

                currStar = Star;

                btn_Star.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
            ComboBox_OrbitMode_SelectedIndexChanged(sender, e);
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

        private void cb_PointingDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PointingDown.Checked)
            {
                cb_Spin.Checked = false;
            }
        }

        #endregion

    }
}
