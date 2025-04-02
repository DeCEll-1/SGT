using Newtonsoft.Json.Linq;
using SSSystemGenerator.Classes;
using SSSystemGenerator.Forms;
using SSSystemGenerator.Forms.SettingsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties;

namespace SSSystemGenerator
{
    public partial class SGTBaseMDIContainer : Form, IFormInterface
    {
        public SGTBaseMDIContainer()
        {
            InitializeComponent();
        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        private void SGTBaseMDIContainer_Load(object sender, EventArgs e)
        {

            Statics.SGTBaseMDIContainer = this;

            fileHelper.SetupFiles();//generate the data/strings/STGSystems.json

            fileHelper.UpdateStaticWithSystemJson();

            UpdateColors();

        }

        public void AddFormToContainer(Form form)
        {
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == form.GetType() && item.Text == form.Text)
                {
                    this.ActivateMdiChild(item);
                    form.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void TSMI_Systems_Click(object sender, EventArgs e)
        {
            Systems systems = new Systems();
            AddFormToContainer(systems);
        }

        private void TSMI_Stars_Click(object sender, EventArgs e)
        {
            Stars stars = new Stars();
            AddFormToContainer(stars);
        }

        private void planetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planets planets = new Planets();
            AddFormToContainer(planets);
        }

        private void marketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Markets markets = new Markets();
            AddFormToContainer(markets);
        }

        private void customEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomEntities customEntities = new CustomEntities();
            AddFormToContainer(customEntities);
        }

        private void ringBandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RingBands ringBands = new RingBands();
            AddFormToContainer(ringBands);
        }

        private void astreoidBeltsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AstreoidBelts astreoidBelts = new AstreoidBelts();
            AddFormToContainer(astreoidBelts);
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            AddFormToContainer(map);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            AddFormToContainer(settings);
        }

        private void TSMII_Info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            AddFormToContainer(info);
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StartSave(Paths.JsonMetadataPath.ToString());

        }

        private void StartSave(string jsonPath)
        {
            ItemCRUD.UpdateLoadOrder();

            if (TSPB_Saving.Value == 100) TSPB_Saving.Value = 0;

            if (JsonHelper.saving == true) { MessageBox.Show("saving"); return; }

            var progress = new Progress<int>(
                value =>
                {
                    TSPB_Saving.Value = value;
                    if (value == 0)
                    {
                        TSSL_Saving.Text = "Starting Saving...";
                    }
                    else if (value != 0 || value != 100)
                    {
                        TSSL_Saving.Text = "Saved Successfully";
                    }
                    else
                    {
                        TSSL_Saving.Text = "Saving In Progress... Completion %: " + value;
                    }
                }
            );


            TSSL_Saving.Text = "Starting Saving...";

            //https://stackoverflow.com/questions/1195896/threadstart-with-parameters lambda is cool
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions yet i dont really know how they work
            this.thread = new Thread(() => JsonHelper.SerialiseToBaseJSONFile(Statics.BaseClass, jsonPath));

            this.thread.IsBackground = true;
            this.thread.Start();
        }

        public Thread thread = null;

        public void UpdateSaving(byte savePercent)
        {
            TSPB_Saving.Value = savePercent;
            if (savePercent == 0)
            {
                TSSL_Saving.Text = "Starting Saving...";
            }
            else if (savePercent == 100)
            {
                TSSL_Saving.Text = "Saved Successfully";
            }
            else
            {
                TSSL_Saving.Text = "Saving In Progress... Completion %: " + savePercent;
            }
        }

        public void ToggleDarkMode(object sender, EventArgs e)
        {

            UpdateColors();

            foreach (IFormInterface form in this.MdiChildren)
            {
                form.UpdateColors();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG | *.png";
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StartSave(sfd.FileName);
                }
            }
        }

        private void MS_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object k = MS_Main.Items;
            Form form = this.MdiChildren.FirstOrDefault(s => s.WindowState == FormWindowState.Maximized);
            if (form != null)
                form.WindowState = FormWindowState.Normal;
        }

        private void MS_Main_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (MS_Main.Items.Count == 8)
            {
                MS_Main.Items[0].Image = ColorManager.CloseButton();
                MS_Main.Items[1].Image = ColorManager.LastSizeButton();
                MS_Main.Items[2].Image = ColorManager.MinimizeButton();
            }
        }

        private void SGTBaseMDIContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save before exiting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes && e.CloseReason == CloseReason.UserClosing)
            {
                saveToolStripMenuItem_Click(null, null);

                Misc.WaitUntilSaveEnds();

                Statics.CloseTheForm = true;

                if (JsonHelper.saving)
                {
                    return;
                }

                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
