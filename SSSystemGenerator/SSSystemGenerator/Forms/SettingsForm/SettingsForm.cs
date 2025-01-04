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

namespace SSSystemGenerator.Forms.SettingsForm
{
    public partial class SettingsForm : Form, IFormInterface
    {
        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        public SettingsForm()
        {
            InitializeComponent();
            UpdateColors();
            TabControls_SelectedIndexChanged(null, null);
        }
        private void TabControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentTab = tc_main.SelectedTab.ToString();
            // cant use switch as it seems

            if (currentTab == tp_CSV.ToString())
                LoadCSVSettings();
            else if (currentTab == tp_General.ToString())
                LoadGeneralSettings();

        }

        private void cb_DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_DarkMode.Checked)
                Settings.ColorMode = ColorMode.DARK;
            else
                Settings.ColorMode = ColorMode.LIGHT;

            Statics.SGTBaseMDIContainer.UpdateColors();
        }

    }
}
