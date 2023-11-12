using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator
{
    public partial class Stars : Form
    {
        public List<VeBlib_StarData> deletedStarsInThisSessionList { get; set; } = new List<VeBlib_StarData> { };
        public VeBlib_StarData currStar { get; set; } = null;

        public Stars()
        {
            InitializeComponent();
            Load();

        }

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
        }

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); }

        //updates orbitables list
        private void loadOrbits()
        {
            List<Extend> orbitables = Helper.getOrbitablesInSystem(getSystem());

            if (orbitables == null) return;

            ComboBox_FocusID.Items.Clear();

            ComboBox_FocusID.Items.Add("");

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());
        }

        //when selected orbitable changes
        private void ComboBox_FocusID_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        //reset extend elements on the form to default values
        private void resetExtend()
        {
            ComboBox_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New Star";//change this in different forms

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



        }

        #endregion

        #region customFunctions

        private void Load()
        {
            LoadSystems();

            ComboBox_Stars.Items.Clear();

            ComboBox_Stars.Items.Add("New Star");
            ComboBox_Stars.SelectedItem = "New Star";

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
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.baseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }

        }

        private void update(VeBlib_StarData star)
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

        private VeBlib_StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        private VeBlib_StarData getData()
        {
            VeBlib_StarData gettenStar = new VeBlib_StarData();

            addExtendValues(gettenStar);

            gettenStar.systemID = ComboBox_Systems.SelectedItem.ToString();

            gettenStar.radius = (float)nud_Radius.Value;
            gettenStar.coronaSize = (float)nud_CoronaSize.Value;

            return gettenStar;
        }

        #endregion

        #region formFunction

        //adds / updates star
        private void btn_AddStar_Click(object sender, EventArgs e)
        {
            if (btn_AddUpdateStar.Text == "Add Star")
            {

                VeBlib_StarData starToAdd = getData();

                if (Helper.DoesStarIDExist(starToAdd.ID))
                {
                    MessageBox.Show("Star ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                ItemEditingAdding.AddStar(starToAdd);

                currStar = Helper.GetStarOnSystem(starToAdd.systemID, starToAdd.ID);

                Load();

                ComboBox_Stars.SelectedItem = starToAdd.ID + " - " + starToAdd.name;
            }
            else//update star
            {

                VeBlib_StarData updatedStar = getData();

                updatedStar.GUID = currStar.GUID;

                updatedStar.systemGUID = Helper.GetSystemFromID(updatedStar.systemID).GUID;

                if (Helper.DoesStarIDExist(updatedStar.ID))
                {
                    MessageBox.Show("Star ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                ItemEditingAdding.UpdateStar(updatedStar);

                Load();

                ComboBox_Stars.SelectedItem = updatedStar.ID + " - " + updatedStar.name;

                currStar = updatedStar;

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
                btn_AddUpdateStar.Enabled = false;
            }
            else
            {
                btn_AddUpdateStar.Enabled = true;
            }
        }

        //star selection
        private void ComboBox_Stars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Stars.SelectedItem.ToString() == "New Star")
            {
                btn_AddUpdateStar.Text = "Add Star";

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_Stars.SelectedItem != null)
            {
                string selectedID = ComboBox_Stars.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                VeBlib_StarData Star = Helper.GetStarOnSystem(systemID, selectedID);//get star in the system

                update(Star);// update the star with variables



                btn_AddUpdateStar.Text = "Update Star";

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { TextChangedBTNAddUpdateCheck(null, null); }

        //system list refresh
        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        #endregion

    }
}
