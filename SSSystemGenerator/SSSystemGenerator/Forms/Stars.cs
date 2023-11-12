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
            ComboBox_OrbitMode.SelectedIndex = 0;
            Load();

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }
        }

        #region focus stuff

        private void ComboBox_FocusID_DropDown(object sender, EventArgs e)//when the drop box opens
        {

        }

        private void ComboBox_FocusID_SelectedIndexChanged(object sender, EventArgs e)//when selected thing changes
        {

        }

        private void addExtendValues(Extend item)
        {
            item.orbitLocationMode = Convert.ToInt32(ComboBox_OrbitMode.SelectedItem);

            if (ComboBox_FocusID.SelectedItem != null) item.focusID = ComboBox_FocusID.SelectedItem.ToString();
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

        private void updateExtends(Extend item)
        {
            ComboBox_OrbitMode.SelectedItem = item.orbitLocationMode;

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

        private void resetExtend()
        {
            ComboBox_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New Star";

            nud_X.Value = 0;
            nud_Y.Value = 0;

            nud_Angle.Value = 0;
            nud_OrbitRadius.Value = 0;
            nud_OrbitDays.Value = 0;

            nud_MinSpin.Value = 0;
            nud_MaxSpin.Value = 0;

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_TypeID.Text = "";
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
                    Helper.IDNameList(
                        Helper.LitsUpcasting(
                            Helper.GetSystemFromID(
                                ComboBox_Systems.SelectedItem.ToString()).starList.ToArray())).ToArray());
            }



        }

        private void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.LitsUpcasting(Statics.baseClass.StarSystemDataList.ToArray())).ToArray());

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

        private void btn_AddStar_Click(object sender, EventArgs e)
        {
            if (btn_AddUpdateStar.Text == "Add Star")
            {

                VeBlib_StarData starToAdd = getData();


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

                ItemEditingAdding.UpdateStar(updatedStar);

                Load();

                ComboBox_Stars.SelectedItem = updatedStar.ID + " - " + updatedStar.name;

                currStar = updatedStar;

            }
        }

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

        private void ComboBox_Systems_DropDown(object sender, EventArgs e)
        {
            LoadSystems();
        }

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

                currStar = Helper.GetStarOnSystem(ComboBox_Systems.SelectedItem.ToString(), selectedID);

                update(currStar);

                btn_AddUpdateStar.Text = "Update Star";

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextChangedBTNAddUpdateCheck(null, null);
        }

       

        
    }
}
