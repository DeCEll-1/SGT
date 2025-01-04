using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Systems : Form, IFormInterface
    {

        public List<StarSystemData> deletedSystemsInThisSessionList { get; set; } = new List<StarSystemData> { };
        public StarSystemData currSystem { get; set; } = null;


        public Systems()
        {
            InitializeComponent();

            UpdateColors();

            Load();
        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        #region customFunctions

        private StarSystemData addValuesToSystem()
        {
            StarSystemData system = new StarSystemData();

            system.ID = tb_ID.Text;
            system.name = tb_Name.Text;
            system.backgroundTextureFilename = tb_StarBackgroundTexturePath.Text;

            system.minHyperspaceRadius = (float)nud_minHyperspaceRadius.Value;
            system.systemX = (float)nud_SystemX.Value;
            system.systemY = (float)nud_SystemY.Value;

            system.autoGenerateEntrancesAtGasGiants = cb_autoGenerateEntrancesAtGasGiants.Checked;
            system.autoGenerateFringeJumpPoint = cb_autoGenerateFringeJumpPoint.Checked;
            system.generatePlanetConditions = cb_generatePlanetConditions.Checked;

            return system;
        }

        private StarSystemData addValuesToSystem(StarSystemData system)
        {

            system.ID = tb_ID.Text;
            system.name = tb_Name.Text;
            system.backgroundTextureFilename = tb_StarBackgroundTexturePath.Text;

            system.minHyperspaceRadius = (float)nud_minHyperspaceRadius.Value;
            system.systemX = (float)nud_SystemX.Value;
            system.systemY = (float)nud_SystemY.Value;

            system.autoGenerateEntrancesAtGasGiants = cb_autoGenerateEntrancesAtGasGiants.Checked;
            system.autoGenerateFringeJumpPoint = cb_autoGenerateFringeJumpPoint.Checked;
            system.generatePlanetConditions = cb_generatePlanetConditions.Checked;

            return system;
        }

        private new void Load()
        {
            ComboBox_SystemSelection.Items.Clear();

            ComboBox_SystemSelection.Items.Add("New System");
            ComboBox_SystemSelection.SelectedItem = "New System";


            ComboBox_SystemSelection.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.BaseClass.StarSystemDataList.ToArray())).ToArray());
            //upcasts array of a list, turns it to the list for ids and then arrays that

        }

        private void update(StarSystemData systemToUpdate)
        {

            if (systemToUpdate == null) return;

            currSystem = systemToUpdate;

            tb_ID.Text = systemToUpdate.ID;
            tb_Name.Text = systemToUpdate.name;
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
            tb_Name.Text = "";
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

        //update / add
        private void btn_AddSystem_Click(object sender, EventArgs e)
        {

            if (btn_AddUpdateSystem.Text == "Add System")
            {
                StarSystemData systemToAdd = addValuesToSystem();

                if (Helper.DoesIDExists(systemToAdd.ID))
                {
                    MessageBox.Show("System ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                currSystem = systemToAdd;

                ItemEditingAdding.AddSystem(systemToAdd);

                Load();

                ComboBox_SystemSelection.SelectedItem = systemToAdd.ID + " - " + systemToAdd.name;
            }
            else//update system
            {


                StarSystemData updatedSystem = Helper.GetSystemFromGUID(currSystem.GUID);//get the old system with the guid to keep the stars and planets and such other things



                updatedSystem = addValuesToSystem(updatedSystem);//update the variables of system

                updatedSystem.GUID = currSystem.GUID;//OK
                                                     //this shit is actually very easy so
                                                     //i give the thing a guid for editing it and get the system to update with guid
                                                     //but for some reason this is liquidifieing my brain
                                                     //smoothbrain.png

                if (Helper.DoesIDExists(updatedSystem.ID, currSystem.ID))
                {
                    MessageBox.Show("System ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


                ItemEditingAdding.UpdateSystem(updatedSystem);//update the system

                Load();

                ComboBox_SystemSelection.SelectedItem = updatedSystem.ID + " - " + updatedSystem.name;

                currSystem = updatedSystem;

            }

        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                btn_AddUpdateSystem.Enabled = false;
            }
            else
            {
                btn_AddUpdateSystem.Enabled = true;
            }
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {

            //old ahh tech, check stars deletion thing and update this according to that
            //TODO: or some shit idk
            if (deletedSystemsInThisSessionList.Count != 0)
            {
                currSystem = deletedSystemsInThisSessionList.ElementAt(deletedSystemsInThisSessionList.Count - 1);

                deletedSystemsInThisSessionList.RemoveAt(deletedSystemsInThisSessionList.Count - 1);

                update(currSystem);

                #region adds the system back, copied from add system

                StarSystemData systemToAdd = addValuesToSystem();

                currSystem = addValuesToSystem();

                currSystem = systemToAdd;

                Statics.BaseClass.StarSystemDataList.Add(systemToAdd);

                Load();

                ComboBox_SystemSelection.SelectedItem = systemToAdd.ID + " - " + systemToAdd.name;

                #endregion


            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (currSystem == null) return;

            deletedSystemsInThisSessionList.Add(currSystem);

            Statics.BaseClass.StarSystemDataList.Remove(currSystem);

            currSystem = new StarSystemData();

            Load();
            reset();

        }

        private void btn_GetSystemBackground_Click(object sender, EventArgs e)
        {
            if (ofd_BackgroundTexture.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string filePath = ofd_BackgroundTexture.FileName;

                    if (!filePath.Contains(Paths.SGTFolderRoot.FullName) && !filePath.Contains(Paths.GameCore.FullName))
                    {
                        MessageBox.Show("Selected file should be under the games directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (filePath.Contains(Paths.SGTFolderRoot.FullName))
                    {
                        filePath = filePath.Replace(Paths.SGTFolderRoot.FullName, "");
                    }

                    if (filePath.Contains(Paths.GameCore.FullName))
                    {
                        filePath = filePath.Replace(Paths.GameCore.FullName, "");
                    }

                    filePath = filePath.Replace("\\", "/");

                    if (filePath[0] == '/')
                    {
                        filePath = filePath.Remove(0, 1);
                    }

                    tb_StarBackgroundTexturePath.Text = filePath;

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
