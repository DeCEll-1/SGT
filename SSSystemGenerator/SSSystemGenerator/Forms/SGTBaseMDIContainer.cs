using SSSystemGenerator.Classes;
using SSSystemGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator
{
    public partial class SGTBaseMDIContainer : Form
    {
        public SGTBaseMDIContainer()
        {
            InitializeComponent();
            object s = Statics.EXEPath;
            s = Statics.JSONPath;
            s = Statics.ModFolderRoot;
            s = Statics.ModsFolderRoot;
            s = Statics.ModCampaignRoot;
            s = Statics.GameRoot;
            s = Statics.GameCore;
            s = Statics.GameCoreCampaignFolder;
            s = Statics.baseClass;
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

        private void loadingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadingOrder loadingOrder = new LoadingOrder();
            bool a = true;
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == loadingOrder.GetType())
                {
                    this.ActivateMdiChild(item);
                    loadingOrder.BringToFront();
                    a = false;
                    break;
                }
            }
            if (a)
            {
                loadingOrder.MdiParent = this;
                loadingOrder.Show();
            }
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

    }
}
