using Newtonsoft.Json.Linq;
using SSSystemGenerator.Classes;
using SSSystemGenerator.Forms;
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

        private void TSMI_Systems_Click(object sender, EventArgs e)
        {
            Systems systems = new Systems();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == systems.GetType())
                {
                    this.ActivateMdiChild(item);
                    systems.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                systems.MdiParent = this;
                systems.Show();
            }
        }

        private void TSMI_Stars_Click(object sender, EventArgs e)
        {
            Stars stars = new Stars();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == stars.GetType())
                {
                    this.ActivateMdiChild(item);
                    stars.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                stars.MdiParent = this;
                stars.Show();
            }
        }

        private void planetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planets planets = new Planets();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == planets.GetType())
                {
                    this.ActivateMdiChild(item);
                    planets.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                planets.MdiParent = this;
                planets.Show();
            }
        }

        private void marketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Markets markets = new Markets();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == markets.GetType())
                {
                    this.ActivateMdiChild(item);
                    markets.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                markets.MdiParent = this;
                markets.Show();
            }
        }

        private void customEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomEntities customEntities = new CustomEntities();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == customEntities.GetType())
                {
                    this.ActivateMdiChild(item);
                    customEntities.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                customEntities.MdiParent = this;
                customEntities.Show();
            }
        }

        private void ringBandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RingBands ringBands = new RingBands();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == ringBands.GetType())
                {
                    this.ActivateMdiChild(item);
                    ringBands.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                ringBands.MdiParent = this;
                ringBands.Show();
            }
        }

        private void astreoidBeltsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AstreoidBelts astreoidBelts = new AstreoidBelts();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == astreoidBelts.GetType())
                {
                    this.ActivateMdiChild(item);
                    astreoidBelts.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                astreoidBelts.MdiParent = this;
                astreoidBelts.Show();
            }
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == map.GetType())
                {
                    this.ActivateMdiChild(item);
                    map.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                map.MdiParent = this;
                map.Show();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == settings.GetType())
                {
                    this.ActivateMdiChild(item);
                    settings.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                settings.MdiParent = this;
                settings.Show();
            }
        }

        private void TSMII_Info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == info.GetType())
                {
                    this.ActivateMdiChild(item);
                    info.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                info.MdiParent = this;
                info.Show();
            }
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(null, null);

                Misc.WaitUntilSaveEnds();

                Statics.CloseTheForm = true;

            }

        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StartSave(Paths.JsonMetadataPath.ToString());

        }

        private void StartSave(string jsonPath)
        {
            ItemEditingAdding.UpdateLoadOrder();

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
            this.thread = new Thread(() => JsonHelper.SerialiseToBaseJSONFile(Statics.BaseClass,  jsonPath));

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

        private void TSMI_DarkMode_Click(object sender, EventArgs e)
        {
            Settings.ColorMode = !Settings.ColorMode;

            UpdateColors();

            if (Settings.ColorMode)//is light mode
            {
                TSMI_DarkMode.Text = "Switch To Dark Mode";

                foreach (IFormInterface form in this.MdiChildren)
                {

                    form.UpdateColors();

                }

            }
            else//on dark mode
            {
                TSMI_DarkMode.Text = "Switch To Light Mode";

                foreach (IFormInterface form in this.MdiChildren)
                {

                    form.UpdateColors();

                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog())
            {

                sfd.Filter = "JSON | *.json";

                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK)
                {

                    StartSave(sfd.FileName);

                }

            }


        }
    }
}
