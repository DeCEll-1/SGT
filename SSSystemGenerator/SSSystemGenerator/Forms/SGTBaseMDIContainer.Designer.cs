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
            this.TSMI_SystemGeneration = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Systems = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Stars = new System.Windows.Forms.ToolStripMenuItem();
            this.planetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ringBandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.astreoidBeltsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_SystemGeneration});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(800, 24);
            this.MS_Main.TabIndex = 1;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(37, 20);
            this.TSMI_File.Text = "File";
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeAppToolStripMenuItem.Text = "Close App";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // TSMI_SystemGeneration
            // 
            this.TSMI_SystemGeneration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Systems,
            this.TSMI_Stars,
            this.planetsToolStripMenuItem,
            this.marketsToolStripMenuItem,
            this.customEntitiesToolStripMenuItem,
            this.ringBandsToolStripMenuItem,
            this.astreoidBeltsToolStripMenuItem,
            this.loadingOrderToolStripMenuItem,
            this.mapToolStripMenuItem});
            this.TSMI_SystemGeneration.Name = "TSMI_SystemGeneration";
            this.TSMI_SystemGeneration.Size = new System.Drawing.Size(118, 20);
            this.TSMI_SystemGeneration.Text = "System Generation";
            // 
            // TSMI_Systems
            // 
            this.TSMI_Systems.Name = "TSMI_Systems";
            this.TSMI_Systems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.TSMI_Systems.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Systems.Text = "Systems";
            this.TSMI_Systems.Click += new System.EventHandler(this.TSMI_Systems_Click);
            // 
            // TSMI_Stars
            // 
            this.TSMI_Stars.Name = "TSMI_Stars";
            this.TSMI_Stars.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.TSMI_Stars.Size = new System.Drawing.Size(199, 22);
            this.TSMI_Stars.Text = "Stars";
            this.TSMI_Stars.Click += new System.EventHandler(this.TSMI_Stars_Click);
            // 
            // planetsToolStripMenuItem
            // 
            this.planetsToolStripMenuItem.Name = "planetsToolStripMenuItem";
            this.planetsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.planetsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.planetsToolStripMenuItem.Text = "Planets";
            this.planetsToolStripMenuItem.Click += new System.EventHandler(this.planetsToolStripMenuItem_Click);
            // 
            // marketsToolStripMenuItem
            // 
            this.marketsToolStripMenuItem.Name = "marketsToolStripMenuItem";
            this.marketsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.marketsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.marketsToolStripMenuItem.Text = "Markets";
            this.marketsToolStripMenuItem.Click += new System.EventHandler(this.marketsToolStripMenuItem_Click);
            // 
            // customEntitiesToolStripMenuItem
            // 
            this.customEntitiesToolStripMenuItem.Name = "customEntitiesToolStripMenuItem";
            this.customEntitiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.customEntitiesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.customEntitiesToolStripMenuItem.Text = "Custom Entities";
            this.customEntitiesToolStripMenuItem.Click += new System.EventHandler(this.customEntitiesToolStripMenuItem_Click);
            // 
            // ringBandsToolStripMenuItem
            // 
            this.ringBandsToolStripMenuItem.Name = "ringBandsToolStripMenuItem";
            this.ringBandsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ringBandsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ringBandsToolStripMenuItem.Text = "Ring Bands";
            this.ringBandsToolStripMenuItem.Click += new System.EventHandler(this.ringBandsToolStripMenuItem_Click);
            // 
            // astreoidBeltsToolStripMenuItem
            // 
            this.astreoidBeltsToolStripMenuItem.Name = "astreoidBeltsToolStripMenuItem";
            this.astreoidBeltsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.astreoidBeltsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.astreoidBeltsToolStripMenuItem.Text = "Astreoid Belts";
            this.astreoidBeltsToolStripMenuItem.Click += new System.EventHandler(this.astreoidBeltsToolStripMenuItem_Click);
            // 
            // loadingOrderToolStripMenuItem
            // 
            this.loadingOrderToolStripMenuItem.Name = "loadingOrderToolStripMenuItem";
            this.loadingOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadingOrderToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadingOrderToolStripMenuItem.Text = "Loading Order";
            this.loadingOrderToolStripMenuItem.Click += new System.EventHandler(this.loadingOrderToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mapToolStripMenuItem.Text = "Map";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // SGTBaseMDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MS_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_Main;
            this.Name = "SGTBaseMDIContainer";
            this.Text = "SGTBaseMDIContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SystemGeneration;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Systems;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Stars;
        private System.Windows.Forms.ToolStripMenuItem planetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ringBandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem astreoidBeltsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadingOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
    }
}