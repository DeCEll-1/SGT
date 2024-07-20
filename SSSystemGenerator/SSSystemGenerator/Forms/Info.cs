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
    public partial class Info : Form, IFormInterface
    {
        public Info()
        {
            InitializeComponent();
            UpdateColors();
        }

        public void UpdateColors() { Helper.ChangeColorMode(this.Controls); }

        private void Info_Load(object sender, EventArgs e)
        {
            lbl_Info.Text = "";

            lbl_Info.Text += "Version: " + Statics.Version + "\n";

            #region statics

            string s = "EXEPath: " + Paths.EXEPath.FullName + "\n\n";
            s += "JSONPath: " + Paths.JsonMetadataPath.FullName + "\n\n";
            s += "ModFolderRoot: " + Paths.ModFolderRoot.FullName + "\n\n";
            s += "ModsFolderRoot: " + Paths.ModsFolderRoot.FullName + "\n\n";
            s += "ModCampaignRoot: " + Paths.ModCampaignRoot.FullName + "\n\n";
            s += "GameRoot: " + Paths.GameRoot.FullName + "\n\n";
            s += "GameCore: " + Paths.GameCore.FullName + "\n\n";
            s += "GameCoreCampaignFolder: " + Paths.GameCoreCampaignFolder.FullName + "\n\n";

            lbl_Info.Text += "Statics\n" + s;

            #endregion

        }
    }
}
