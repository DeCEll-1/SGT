using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Systems : Form
    {



        public List<VeBlib_StarSystemData> deletedSystemsInThisSessionList { get; set; } = new List<VeBlib_StarSystemData> { };
        public VeBlib_StarSystemData currSystem { get; set; } = null;

        public Systems()
        {
            InitializeComponent();

            Load();
        }

        #region customFunctions

        private VeBlib_StarSystemData getSystemFromValues()
        {
            VeBlib_StarSystemData returnSystem = new VeBlib_StarSystemData();

            returnSystem.systemID = tb_ID.Text;
            returnSystem.backgroundTextureFilename = tb_StarBackgroundTexturePath.Text;

            returnSystem.minHyperspaceRadius = (float)nud_minHyperspaceRadius.Value;
            returnSystem.systemX = (float)nud_SystemX.Value;
            returnSystem.systemY = (float)nud_SystemY.Value;

            returnSystem.autoGenerateEntrancesAtGasGiants = cb_autoGenerateEntrancesAtGasGiants.Checked;
            returnSystem.autoGenerateFringeJumpPoint = cb_autoGenerateFringeJumpPoint.Checked;
            returnSystem.generatePlanetConditions = cb_generatePlanetConditions.Checked;

            return returnSystem;
        }

        private void Load()
        {
            ComboBox_SystemSelection.Items.Clear();

            ComboBox_SystemSelection.Items.Add("New System");
            ComboBox_SystemSelection.SelectedItem = "New System";

            ComboBox_SystemSelection.Items.AddRange(Helper.SystemListToSystemIDList().ToArray());

        }

        private void update(VeBlib_StarSystemData systemToUpdate)
        {

            if (systemToUpdate == null) return;

            currSystem = systemToUpdate;

            tb_ID.Text = systemToUpdate.systemID;
            tb_StarBackgroundTexturePath.Text = systemToUpdate.backgroundTextureFilename;

            nud_minHyperspaceRadius.Value = (decimal)systemToUpdate.minHyperspaceRadius;
            nud_SystemX.Value = (decimal)systemToUpdate.systemX;
            nud_SystemY.Value = (decimal)systemToUpdate.systemY;

            cb_autoGenerateEntrancesAtGasGiants.Checked = systemToUpdate.autoGenerateEntrancesAtGasGiants;
            cb_autoGenerateFringeJumpPoint.Checked = systemToUpdate.autoGenerateFringeJumpPoint;
            cb_generatePlanetConditions.Checked = systemToUpdate.generatePlanetConditions;
        }

        private void reset()
        {

            currSystem = null;

            tb_ID.Text = "";
            tb_StarBackgroundTexturePath.Text = "";

            nud_minHyperspaceRadius.Value = 0;
            nud_SystemX.Value = 0;
            nud_SystemY.Value = 0;

            cb_autoGenerateEntrancesAtGasGiants.Checked = false;
            cb_autoGenerateFringeJumpPoint.Checked = false;
            cb_generatePlanetConditions.Checked = false;

            ComboBox_SystemSelection.SelectedItem = "New System";
        }
        #endregion

        private void btn_Undo_Click(object sender, EventArgs e)
        {

            if (deletedSystemsInThisSessionList.Count != 0)
            {
                currSystem = deletedSystemsInThisSessionList.ElementAt(deletedSystemsInThisSessionList.Count - 1);

                deletedSystemsInThisSessionList.RemoveAt(deletedSystemsInThisSessionList.Count - 1);

                update(currSystem);

                #region adds the system back, copied from add system

                VeBlib_StarSystemData systemToAdd = getSystemFromValues();

                currSystem = getSystemFromValues();

                currSystem = systemToAdd;

                Statics.baseClass.StarSystemDataList.Add(systemToAdd);

                Load();

                ComboBox_SystemSelection.SelectedItem = systemToAdd.systemID;

                #endregion


            }

        }

        private void ComboBox_SystemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_SystemSelection.SelectedItem.ToString() == "New System")
            {
                btn_AddUpdateSystem.Text = "Add System";

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_SystemSelection.SelectedItem != null)
            {
                string selectedID = ComboBox_SystemSelection.SelectedItem.ToString();

                currSystem = Helper.GetSystemFromID(selectedID);

                update(currSystem);

                btn_AddUpdateSystem.Text = "Update System";

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }


        }

        private void btn_AddSystem_Click(object sender, EventArgs e)
        {

            if (btn_AddUpdateSystem.Text == "Add System")
            {
                VeBlib_StarSystemData systemToAdd = getSystemFromValues();

                currSystem = getSystemFromValues();

                currSystem = systemToAdd;

                Statics.baseClass.StarSystemDataList.Add(systemToAdd);

                Load();

                ComboBox_SystemSelection.SelectedItem = systemToAdd.systemID;
            }
            else//update system
            {

                VeBlib_StarSystemData updatedSystem = getSystemFromValues();

                updatedSystem = getSystemFromValues();

                Statics.baseClass.StarSystemDataList.Remove(currSystem);

                Statics.baseClass.StarSystemDataList.Add(updatedSystem);

                Load();

                ComboBox_SystemSelection.SelectedItem = updatedSystem.systemID;

                currSystem = updatedSystem;

            }

        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            if (tb_ID.Text == "")
            {
                btn_AddUpdateSystem.Enabled = false;
            }
            else
            {
                btn_AddUpdateSystem.Enabled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (currSystem == null) return;

            deletedSystemsInThisSessionList.Add(currSystem);

            Statics.baseClass.StarSystemDataList.Remove(currSystem);

            currSystem = new VeBlib_StarSystemData();

            Load();
            reset();

        }
    }
}
