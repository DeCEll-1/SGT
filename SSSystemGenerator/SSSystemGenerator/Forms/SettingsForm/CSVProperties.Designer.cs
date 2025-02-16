namespace SSSystemGenerator.Forms.SettingsForm
{
    partial class CSVProperties
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Industries = new System.Windows.Forms.ListBox();
            this.lb_Conditions = new System.Windows.Forms.ListBox();
            this.lb_Submarkets = new System.Windows.Forms.ListBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lb_PlanetTypes = new System.Windows.Forms.ListBox();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Industries
            // 
            this.lb_Industries.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Industries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Industries.FormattingEnabled = true;
            this.lb_Industries.ItemHeight = 18;
            this.lb_Industries.Location = new System.Drawing.Point(0, 0);
            this.lb_Industries.Name = "lb_Industries";
            this.lb_Industries.Size = new System.Drawing.Size(150, 153);
            this.lb_Industries.TabIndex = 1;
            // 
            // lb_Conditions
            // 
            this.lb_Conditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Conditions.FormattingEnabled = true;
            this.lb_Conditions.ItemHeight = 18;
            this.lb_Conditions.Location = new System.Drawing.Point(150, 0);
            this.lb_Conditions.Name = "lb_Conditions";
            this.lb_Conditions.Size = new System.Drawing.Size(143, 153);
            this.lb_Conditions.TabIndex = 2;
            // 
            // lb_Submarkets
            // 
            this.lb_Submarkets.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Submarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_Submarkets.FormattingEnabled = true;
            this.lb_Submarkets.ItemHeight = 18;
            this.lb_Submarkets.Location = new System.Drawing.Point(293, 0);
            this.lb_Submarkets.Name = "lb_Submarkets";
            this.lb_Submarkets.Size = new System.Drawing.Size(150, 153);
            this.lb_Submarkets.TabIndex = 3;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.lb_Conditions);
            this.pnl_top.Controls.Add(this.lb_Industries);
            this.pnl_top.Controls.Add(this.lb_Submarkets);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(443, 153);
            this.pnl_top.TabIndex = 4;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.lb_PlanetTypes);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 159);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(443, 210);
            this.pnl_bottom.TabIndex = 5;
            // 
            // lb_PlanetTypes
            // 
            this.lb_PlanetTypes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_PlanetTypes.FormattingEnabled = true;
            this.lb_PlanetTypes.ItemHeight = 16;
            this.lb_PlanetTypes.Location = new System.Drawing.Point(0, 0);
            this.lb_PlanetTypes.Name = "lb_PlanetTypes";
            this.lb_PlanetTypes.Size = new System.Drawing.Size(120, 210);
            this.lb_PlanetTypes.TabIndex = 0;
            // 
            // CSVProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 369);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.KeyPreview = true;
            this.Name = "CSVProperties";
            this.ResizeEnd += new System.EventHandler(this.CSVProperties_ResizeEnd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CSVProperties_KeyPress);
            this.Resize += new System.EventHandler(this.CSVProperties_Resize);
            this.pnl_top.ResumeLayout(false);
            this.pnl_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_Industries;
        private System.Windows.Forms.ListBox lb_Conditions;
        private System.Windows.Forms.ListBox lb_Submarkets;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.ListBox lb_PlanetTypes;
    }
}
