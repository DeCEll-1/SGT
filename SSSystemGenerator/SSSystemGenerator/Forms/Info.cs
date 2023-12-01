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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lbl_Info.Text = "";

            lbl_Info.Text += "Version: " + Statics.Version + "\n";

            #region statics

            string s = "EXEPath: " + Statics.EXEPath.FullName + "\n\n";
            s += "JSONPath: " + Statics.JSONPath.FullName + "\n\n";
            s += "ModFolderRoot: " + Statics.ModFolderRoot.FullName + "\n\n";
            s += "ModsFolderRoot: " + Statics.ModsFolderRoot.FullName + "\n\n";
            s += "ModCampaignRoot: " + Statics.ModCampaignRoot.FullName + "\n\n";
            s += "GameRoot: " + Statics.GameRoot.FullName + "\n\n";
            s += "GameCore: " + Statics.GameCore.FullName + "\n\n";
            s += "GameCoreCampaignFolder: " + Statics.GameCoreCampaignFolder.FullName + "\n\n";

            lbl_Info.Text += "Statics\n" + s;

            #endregion

        }
    }
}
