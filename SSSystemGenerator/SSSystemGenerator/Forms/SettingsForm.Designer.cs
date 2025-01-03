namespace SSSystemGenerator.Forms
{
    partial class SettingsForm
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
            this.ofd_AddMod = new System.Windows.Forms.OpenFileDialog();
            this.TabControls = new System.Windows.Forms.TabControl();
            this.tp_csv = new System.Windows.Forms.TabPage();
            this.btn_ReloadCSVs = new System.Windows.Forms.Button();
            this.btn_Properties = new System.Windows.Forms.Button();
            this.lb_ModsToLoad = new System.Windows.Forms.ListBox();
            this.btn_RemoveModFromLoad = new System.Windows.Forms.Button();
            this.btn_AddModToLoad = new System.Windows.Forms.Button();
            this.TabControls.SuspendLayout();
            this.tp_csv.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd_AddMod
            // 
            this.ofd_AddMod.FileName = "ofd_AddMod";
            this.ofd_AddMod.Filter = "PNG (*.png)|*.png|PJEG (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            // 
            // TabControls
            // 
            this.TabControls.Controls.Add(this.tp_csv);
            this.TabControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControls.Location = new System.Drawing.Point(0, 0);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedIndex = 0;
            this.TabControls.Size = new System.Drawing.Size(432, 453);
            this.TabControls.TabIndex = 2;
            // 
            // tp_csv
            // 
            this.tp_csv.Controls.Add(this.btn_ReloadCSVs);
            this.tp_csv.Controls.Add(this.btn_Properties);
            this.tp_csv.Controls.Add(this.lb_ModsToLoad);
            this.tp_csv.Controls.Add(this.btn_RemoveModFromLoad);
            this.tp_csv.Controls.Add(this.btn_AddModToLoad);
            this.tp_csv.Location = new System.Drawing.Point(4, 25);
            this.tp_csv.Name = "tp_csv";
            this.tp_csv.Padding = new System.Windows.Forms.Padding(3);
            this.tp_csv.Size = new System.Drawing.Size(424, 424);
            this.tp_csv.TabIndex = 0;
            this.tp_csv.Text = "CSV Settings";
            this.tp_csv.UseVisualStyleBackColor = true;
            // 
            // btn_ReloadCSVs
            // 
            this.btn_ReloadCSVs.Location = new System.Drawing.Point(218, 336);
            this.btn_ReloadCSVs.Name = "btn_ReloadCSVs";
            this.btn_ReloadCSVs.Size = new System.Drawing.Size(105, 38);
            this.btn_ReloadCSVs.TabIndex = 5;
            this.btn_ReloadCSVs.Text = "Reload CSVs";
            this.btn_ReloadCSVs.UseVisualStyleBackColor = true;
            this.btn_ReloadCSVs.Click += new System.EventHandler(this.btn_ReloadCSVs_Click);
            // 
            // btn_Properties
            // 
            this.btn_Properties.Location = new System.Drawing.Point(329, 337);
            this.btn_Properties.Name = "btn_Properties";
            this.btn_Properties.Size = new System.Drawing.Size(84, 38);
            this.btn_Properties.TabIndex = 5;
            this.btn_Properties.Text = "Properties";
            this.btn_Properties.UseVisualStyleBackColor = true;
            this.btn_Properties.Click += new System.EventHandler(this.btn_Properties_Click);
            // 
            // lb_ModsToLoad
            // 
            this.lb_ModsToLoad.FormattingEnabled = true;
            this.lb_ModsToLoad.ItemHeight = 16;
            this.lb_ModsToLoad.Location = new System.Drawing.Point(6, 6);
            this.lb_ModsToLoad.Name = "lb_ModsToLoad";
            this.lb_ModsToLoad.Size = new System.Drawing.Size(410, 324);
            this.lb_ModsToLoad.TabIndex = 4;
            this.lb_ModsToLoad.SelectedIndexChanged += new System.EventHandler(this.lb_ModsToLoad_SelectedIndexChanged);
            // 
            // btn_RemoveModFromLoad
            // 
            this.btn_RemoveModFromLoad.Enabled = false;
            this.btn_RemoveModFromLoad.Location = new System.Drawing.Point(218, 380);
            this.btn_RemoveModFromLoad.Name = "btn_RemoveModFromLoad";
            this.btn_RemoveModFromLoad.Size = new System.Drawing.Size(200, 38);
            this.btn_RemoveModFromLoad.TabIndex = 2;
            this.btn_RemoveModFromLoad.Text = "Remove mod from loading";
            this.btn_RemoveModFromLoad.UseVisualStyleBackColor = true;
            this.btn_RemoveModFromLoad.Click += new System.EventHandler(this.RemoveModFromLoading);
            // 
            // btn_AddModToLoad
            // 
            this.btn_AddModToLoad.Location = new System.Drawing.Point(6, 380);
            this.btn_AddModToLoad.Name = "btn_AddModToLoad";
            this.btn_AddModToLoad.Size = new System.Drawing.Size(200, 38);
            this.btn_AddModToLoad.TabIndex = 2;
            this.btn_AddModToLoad.Text = "Add new mod to loading";
            this.btn_AddModToLoad.UseVisualStyleBackColor = true;
            this.btn_AddModToLoad.Click += new System.EventHandler(this.AddModToLoad);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.TabControls);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.TabControls.ResumeLayout(false);
            this.tp_csv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_AddMod;
        private System.Windows.Forms.TabControl TabControls;
        private System.Windows.Forms.TabPage tp_csv;
        private System.Windows.Forms.Button btn_AddModToLoad;
        private System.Windows.Forms.Button btn_RemoveModFromLoad;
        private System.Windows.Forms.ListBox lb_ModsToLoad;
        private System.Windows.Forms.Button btn_Properties;
        private System.Windows.Forms.Button btn_ReloadCSVs;
    }
}