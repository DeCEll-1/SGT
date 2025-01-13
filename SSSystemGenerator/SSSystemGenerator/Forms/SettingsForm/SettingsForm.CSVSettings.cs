using Microsoft.WindowsAPICodePack.Dialogs;
using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.CSVClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms.SettingsForm
{
    public partial class SettingsForm
    {

        private void LoadCSVSettings()
        {
            lb_ModsToLoad.Items.Clear();
            lb_ModsToLoad.Items.Add(Paths.GameCore.Name);

            SettingsController.ModsToLoad.ForEach(modPath =>
            {
                lb_ModsToLoad.Items.Add(modPath.Name );
            });

            lb_ModsToLoad.SelectedIndex = 0;
        }

        private void AddModToLoad(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Paths.ModsFolderRoot.FullName.ToString();
            dialog.IsFolderPicker = true;
            string path = "";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (
                    !dialog.FileName.Contains(Paths.ModsFolderRoot.FullName.ToString()) || // does the path contain the mods folders full name?
                    !File.Exists(dialog.FileName + @"\mod_info.json") // does the selected mod folder have mod_info.json under its path?
                    )
                {
                    MessageBox.Show("You must select a folder under your mods folder\n" + Paths.ModsFolderRoot.FullName.ToString());
                    return;
                }
                if (
                    !Directory.Exists(dialog.FileName + @"\data\campaign") // does the mod folder have a campaign folder?
                    )
                {
                    MessageBox.Show(@"The selected mod must have a \data\campaign folder but it does not exist for " + dialog.FileName.ToString());
                    return;
                }
                path = dialog.FileName;
            }
            else
                return;


            if (SettingsController.ModsToLoad.Contains(new DirectoryInfo(path)))
                return;
            SettingsController.ModsToLoad.Add(new DirectoryInfo(path));
            LoadCSVSettings();
            btn_ReloadCSVs_Click(sender, e);
        }

        private void RemoveModFromLoading(object sender, EventArgs e)
        {
            string pathOfModToRemove = lb_ModsToLoad.SelectedItem.ToString();

            SettingsController.ModsToLoad.RemoveAll(s => s.FullName.Contains(pathOfModToRemove));
            LoadCSVSettings();
            lb_ModsToLoad_SelectedIndexChanged(null, null);
        }

        private void btn_Properties_Click(object sender, EventArgs e)
        {

            if (lb_ModsToLoad.SelectedItem == null)
            {
                MessageBox.Show("Please select a mod.");
                return;
            }

            string modToCheck = lb_ModsToLoad.SelectedItem.ToString();

            List<IndustriesCSV> industries = Statics.CSVs.Industries.Where(s => s.owner == modToCheck).ToList();
            List<MarketConditionsCSV> conditions = Statics.CSVs.MarketConditions.Where(s => s.owner == modToCheck).ToList();
            List<SubmarketsCSV> submarkets = Statics.CSVs.Submarkets.Where(s => s.owner == modToCheck).ToList();

            CSVProperties properties = new CSVProperties(industries, conditions, submarkets);
            properties.Text = modToCheck;
            Statics.SGTBaseMDIContainer.AddFormToContainer(properties);
        }

        private void lb_ModsToLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_ModsToLoad.SelectedItem == null || lb_ModsToLoad.SelectedItem.ToString().Contains("starsector-core"))
            {
                btn_RemoveModFromLoad.Enabled = false;
                return;
            }
            if (lb_ModsToLoad.SelectedItem == null)
            {
                btn_Properties.Enabled = false;
            }
            btn_RemoveModFromLoad.Enabled = true;
            btn_Properties.Enabled = true;
        }

        private void btn_ReloadCSVs_Click(object sender, EventArgs e)
        {
            Statics.CSVs = CSVHelper.GetAllCSVs();
        }

    }
}
