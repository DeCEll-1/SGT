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
            this.SuspendLayout();
            // 
            // lb_Industries
            // 
            this.lb_Industries.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_Industries.FormattingEnabled = true;
            this.lb_Industries.ItemHeight = 16;
            this.lb_Industries.Location = new System.Drawing.Point(0, 0);
            this.lb_Industries.Name = "lb_Industries";
            this.lb_Industries.Size = new System.Drawing.Size(150, 316);
            this.lb_Industries.TabIndex = 1;
            // 
            // lb_Conditions
            // 
            this.lb_Conditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Conditions.FormattingEnabled = true;
            this.lb_Conditions.ItemHeight = 16;
            this.lb_Conditions.Location = new System.Drawing.Point(150, 0);
            this.lb_Conditions.Name = "lb_Conditions";
            this.lb_Conditions.Size = new System.Drawing.Size(143, 316);
            this.lb_Conditions.TabIndex = 2;
            // 
            // lb_Submarkets
            // 
            this.lb_Submarkets.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Submarkets.FormattingEnabled = true;
            this.lb_Submarkets.ItemHeight = 16;
            this.lb_Submarkets.Location = new System.Drawing.Point(293, 0);
            this.lb_Submarkets.Name = "lb_Submarkets";
            this.lb_Submarkets.Size = new System.Drawing.Size(150, 316);
            this.lb_Submarkets.TabIndex = 3;
            // 
            // CSVProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 316);
            this.Controls.Add(this.lb_Conditions);
            this.Controls.Add(this.lb_Submarkets);
            this.Controls.Add(this.lb_Industries);
            this.KeyPreview = true;
            this.Name = "CSVProperties";
            this.ResizeEnd += new System.EventHandler(this.CSVProperties_ResizeEnd);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CSVProperties_KeyPress);
            this.Resize += new System.EventHandler(this.CSVProperties_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_Industries;
        private System.Windows.Forms.ListBox lb_Conditions;
        private System.Windows.Forms.ListBox lb_Submarkets;
    }
}
