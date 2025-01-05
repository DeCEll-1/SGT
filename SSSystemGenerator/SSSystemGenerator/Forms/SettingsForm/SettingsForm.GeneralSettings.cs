using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Forms.SettingsForm
{
    public partial class SettingsForm
    {
        private void LoadGeneralSettings() => cb_DarkMode.Checked = SettingsController.ColorMode == ColorMode.DARK;

        private void cb_DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_DarkMode.Checked)
                SettingsController.ColorMode = ColorMode.DARK;
            else
                SettingsController.ColorMode = ColorMode.LIGHT;

            Statics.SGTBaseMDIContainer.UpdateColors();
        }
    }
}
