using Microsoft.WindowsAPICodePack.Dialogs;
using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class SettingsForm : Form, IFormInterface
    {
        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }
        public SettingsForm()
        {
            InitializeComponent();
            UpdateColors();
            Load();
        }

        private void Load()
        {
            lb_ModsToLoad.Items.Clear();
            lb_ModsToLoad.Items.Add(Paths.GameCoreCampaignFolder.FullName.ToString().Replace(Paths.GameRoot.FullName.ToString(), ""));

            Settings.ModsToLoad.ForEach(modPath =>
            {
                lb_ModsToLoad.Items.Add(modPath.FullName.ToString().Replace(Paths.ModsFolderRoot.FullName.ToString(), "") + @"\data\campaign");
            });

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

            if (Settings.ModsToLoad.Contains(new DirectoryInfo(path)))
                return;
            Settings.ModsToLoad.Add(new DirectoryInfo(path));
            Load();

        }

        private void RemoveModFromLoading(object sender, EventArgs e)
        {

        }

        private void lb_ModsToLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_ModsToLoad.SelectedItem == null)
            {
                btn_RemoveModFromLoad.Enabled = false;
                return;
            }
            btn_RemoveModFromLoad.Enabled = true;
        }

        private void btn_Properties_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReloadCSVs_Click(object sender, EventArgs e)
        {
            Statics.CSVs = CSVHelper.GetAllCSVs();
        }


    }
}
