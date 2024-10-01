namespace SSSystemGenerator
{
    partial class SGTBaseMDIContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SystemGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Systems = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Planets = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Markets = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CustomEntities = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RingBands = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AstreoidBelts = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Map = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMII_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Preferances = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Saving = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSPB_Saving = new System.Windows.Forms.ToolStripProgressBar();
            this.TSSL_MadeIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS_Main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_SystemGeneration,
            this.TSMI_Info,
            this.TSMI_Preferances});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1067, 28);
            this.MS_Main.TabIndex = 1;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(46, 24);
            this.TSMI_File.Text = "File";
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.closeAppToolStripMenuItem.Text = "Close App";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // TSMI_SystemGeneration
            // 
            this.TSMI_SystemGeneration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Systems,
            this.TSMI_Stars,
            this.TSMI_Planets,
            this.TSMI_Markets,
            this.TSMI_CustomEntities,
            this.TSMI_RingBands,
            this.TSMI_AstreoidBelts,
            this.TSMI_Map});
            this.TSMI_SystemGeneration.Name = "TSMI_SystemGeneration";
            this.TSMI_SystemGeneration.Size = new System.Drawing.Size(147, 24);
            this.TSMI_SystemGeneration.Text = "System Generation";
            // 
            // TSMI_Systems
            // 
            this.TSMI_Systems.Name = "TSMI_Systems";
            this.TSMI_Systems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.TSMI_Systems.Size = new System.Drawing.Size(244, 26);
            this.TSMI_Systems.Text = "Systems";
            this.TSMI_Systems.Click += new System.EventHandler(this.TSMI_Systems_Click);
            // 
            // TSMI_Stars
            // 
            this.TSMI_Stars.Name = "TSMI_Stars";
            this.TSMI_Stars.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.TSMI_Stars.Size = new System.Drawing.Size(244, 26);
            this.TSMI_Stars.Text = "Stars";
            this.TSMI_Stars.Click += new System.EventHandler(this.TSMI_Stars_Click);
            // 
            // TSMI_Planets
            // 
            this.TSMI_Planets.Name = "TSMI_Planets";
            this.TSMI_Planets.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.TSMI_Planets.Size = new System.Drawing.Size(244, 26);
            this.TSMI_Planets.Text = "Planets";
            this.TSMI_Planets.Click += new System.EventHandler(this.planetsToolStripMenuItem_Click);
            // 
            // TSMI_Markets
            // 
            this.TSMI_Markets.Name = "TSMI_Markets";
            this.TSMI_Markets.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.TSMI_Markets.Size = new System.Drawing.Size(244, 26);
            this.TSMI_Markets.Text = "Markets";
            this.TSMI_Markets.Click += new System.EventHandler(this.marketsToolStripMenuItem_Click);
            // 
            // TSMI_CustomEntities
            // 
            this.TSMI_CustomEntities.Name = "TSMI_CustomEntities";
            this.TSMI_CustomEntities.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.TSMI_CustomEntities.Size = new System.Drawing.Size(244, 26);
            this.TSMI_CustomEntities.Text = "Custom Entities";
            this.TSMI_CustomEntities.Click += new System.EventHandler(this.customEntitiesToolStripMenuItem_Click);
            // 
            // TSMI_RingBands
            // 
            this.TSMI_RingBands.Name = "TSMI_RingBands";
            this.TSMI_RingBands.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.TSMI_RingBands.Size = new System.Drawing.Size(244, 26);
            this.TSMI_RingBands.Text = "Ring Bands";
            this.TSMI_RingBands.Click += new System.EventHandler(this.ringBandsToolStripMenuItem_Click);
            // 
            // TSMI_AstreoidBelts
            // 
            this.TSMI_AstreoidBelts.Name = "TSMI_AstreoidBelts";
            this.TSMI_AstreoidBelts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.TSMI_AstreoidBelts.Size = new System.Drawing.Size(244, 26);
            this.TSMI_AstreoidBelts.Text = "Astreoid Belts";
            this.TSMI_AstreoidBelts.Click += new System.EventHandler(this.astreoidBeltsToolStripMenuItem_Click);
            // 
            // TSMI_Map
            // 
            this.TSMI_Map.Name = "TSMI_Map";
            this.TSMI_Map.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.TSMI_Map.Size = new System.Drawing.Size(244, 26);
            this.TSMI_Map.Text = "Map";
            this.TSMI_Map.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // TSMI_Info
            // 
            this.TSMI_Info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMII_Info});
            this.TSMI_Info.Name = "TSMI_Info";
            this.TSMI_Info.Size = new System.Drawing.Size(49, 24);
            this.TSMI_Info.Text = "Info";
            // 
            // TSMII_Info
            // 
            this.TSMII_Info.Name = "TSMII_Info";
            this.TSMII_Info.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.TSMII_Info.Size = new System.Drawing.Size(164, 26);
            this.TSMII_Info.Text = "Info";
            this.TSMII_Info.Click += new System.EventHandler(this.TSMII_Info_Click);
            // 
            // TSMI_Preferances
            // 
            this.TSMI_Preferances.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DarkMode,
            this.settingsToolStripMenuItem});
            this.TSMI_Preferances.Name = "TSMI_Preferances";
            this.TSMI_Preferances.Size = new System.Drawing.Size(99, 24);
            this.TSMI_Preferances.Text = "Preferances";
            // 
            // TSMI_DarkMode
            // 
            this.TSMI_DarkMode.Name = "TSMI_DarkMode";
            this.TSMI_DarkMode.Size = new System.Drawing.Size(233, 26);
            this.TSMI_DarkMode.Text = "Switch To Dark Mode";
            this.TSMI_DarkMode.Click += new System.EventHandler(this.TSMI_DarkMode_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Saving,
            this.TSPB_Saving,
            this.TSSL_Spring,
            this.TSSL_MadeIn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Saving
            // 
            this.TSSL_Saving.Name = "TSSL_Saving";
            this.TSSL_Saving.Size = new System.Drawing.Size(0, 20);
            // 
            // TSPB_Saving
            // 
            this.TSPB_Saving.Name = "TSPB_Saving";
            this.TSPB_Saving.Size = new System.Drawing.Size(133, 18);
            // 
            // TSSL_MadeIn
            // 
            this.TSSL_MadeIn.Name = "TSSL_MadeIn";
            this.TSSL_MadeIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TSSL_MadeIn.Size = new System.Drawing.Size(110, 20);
            this.TSSL_MadeIn.Text = "Made In Turkey";
            this.TSSL_MadeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TSSL_Spring
            // 
            this.TSSL_Spring.Name = "TSSL_Spring";
            this.TSSL_Spring.Size = new System.Drawing.Size(763, 20);
            this.TSSL_Spring.Spring = true;
            // 
            // SGTBaseMDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MS_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SGTBaseMDIContainer";
            this.Text = "SGTBaseMDIContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SGTBaseMDIContainer_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SystemGeneration;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Systems;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Stars;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Planets;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Markets;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CustomEntities;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RingBands;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AstreoidBelts;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Map;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Info;
        private System.Windows.Forms.ToolStripMenuItem TSMII_Info;
        public System.Windows.Forms.ToolStripStatusLabel TSSL_Saving;
        public System.Windows.Forms.ToolStripProgressBar TSPB_Saving;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Preferances;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DarkMode;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_MadeIn;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Spring;
    }
}