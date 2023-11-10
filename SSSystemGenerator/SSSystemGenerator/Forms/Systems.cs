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



        public List<VeBlib_StarSystemData> systemList { get; set; }
        public VeBlib_StarSystemData undoSystem { get; set; }
        public VeBlib_StarSystemData currSystem { get; set; }

        public Systems()
        {
            InitializeComponent();
        }

        private void Systems_Load(object sender, EventArgs e)
        {
            Load();
        }

        #region customFunctions

        private VeBlib_StarSystemData getSystemFromValues()
        {
            VeBlib_StarSystemData returnSystem = null;

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

            ComboBox_SystemSelection.Items.AddRange(Helper.SystemListToSystemIDList().ToArray());

        }

        private void update(VeBlib_StarSystemData systemToUpdate)
        {
            undoSystem = currSystem;

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
            tb_ID.Text = "";
            tb_StarBackgroundTexturePath.Text = "";

            nud_minHyperspaceRadius.Value = 0;
            nud_SystemX.Value = 0;
            nud_SystemY.Value = 0;

            cb_autoGenerateEntrancesAtGasGiants.Checked = false;
            cb_autoGenerateFringeJumpPoint.Checked = false;
            cb_generatePlanetConditions.Checked = false;
        }
        #endregion

        private void btn_Undo_Click(object sender, EventArgs e)
        {

            update(undoSystem);

        }

        private void ComboBox_SystemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedID = ComboBox_SystemSelection.SelectedItem.ToString();

            undoSystem = currSystem;

            currSystem = Helper.GetSystemFromID(selectedID);

        }

        private void btn_Deselect_Click(object sender, EventArgs e)
        {
            undoSystem = currSystem;

            reset();
        }

        private void btn_AddSystem_Click(object sender, EventArgs e)
        {

            VeBlib_StarSystemData systemToAdd = getSystemFromValues();

            currSystem = systemToAdd;

            Statics.baseClass.StarSystemDataList.Add(systemToAdd);

            Load();

        }
    }
}
