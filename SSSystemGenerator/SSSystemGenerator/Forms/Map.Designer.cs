namespace SSSystemGenerator.Forms
{
    partial class Map
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
            this.pnl_Map = new System.Windows.Forms.Panel();
            this.TrackBar_Zoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_PanelInfo = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.pnl_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Map
            // 
            this.pnl_Map.Controls.Add(this.TrackBar_Zoom);
            this.pnl_Map.Controls.Add(this.label2);
            this.pnl_Map.Controls.Add(this.lbl_PanelInfo);
            this.pnl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Map.Location = new System.Drawing.Point(0, 0);
            this.pnl_Map.Name = "pnl_Map";
            this.pnl_Map.Size = new System.Drawing.Size(1000, 1000);
            this.pnl_Map.TabIndex = 0;
            this.pnl_Map.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);
            this.pnl_Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Map_MouseDown);
            // 
            // TrackBar_Zoom
            // 
            this.TrackBar_Zoom.AutoSize = false;
            this.TrackBar_Zoom.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar_Zoom.Location = new System.Drawing.Point(862, 26);
            this.TrackBar_Zoom.Maximum = 200;
            this.TrackBar_Zoom.Name = "TrackBar_Zoom";
            this.TrackBar_Zoom.Size = new System.Drawing.Size(126, 20);
            this.TrackBar_Zoom.TabIndex = 5;
            this.TrackBar_Zoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Zoom.ValueChanged += new System.EventHandler(this.TrackBar_Zoom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select System:";
            // 
            // lbl_PanelInfo
            // 
            this.lbl_PanelInfo.AutoSize = true;
            this.lbl_PanelInfo.Location = new System.Drawing.Point(149, 25);
            this.lbl_PanelInfo.Name = "lbl_PanelInfo";
            this.lbl_PanelInfo.Size = new System.Drawing.Size(72, 13);
            this.lbl_PanelInfo.TabIndex = 0;
            this.lbl_PanelInfo.Text = "Panel Values:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(12, 25);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(103, 21);
            this.ComboBox_Systems.TabIndex = 1;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select System:";
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(121, 25);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_SystemsRefresh.TabIndex = 3;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.btn_SystemsRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Systems);
            this.Controls.Add(this.pnl_Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Map";
            this.Text = "Map";
            this.pnl_Map.ResumeLayout(false);
            this.pnl_Map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Zoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.Label lbl_PanelInfo;
        private System.Windows.Forms.TrackBar TrackBar_Zoom;
        private System.Windows.Forms.Label label2;
    }
}