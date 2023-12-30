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
            this.btn_DeZoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ResetMapVisuals = new System.Windows.Forms.Button();
            this.btn_Zoom = new System.Windows.Forms.Button();
            this.lbl_PanelInfo = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.btn_FormSizeDecrease = new System.Windows.Forms.Button();
            this.btn_FormSizeIncrease = new System.Windows.Forms.Button();
            this.pnl_Map.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Map
            // 
            this.pnl_Map.Controls.Add(this.ComboBox_Systems);
            this.pnl_Map.Controls.Add(this.btn_SystemsRefresh);
            this.pnl_Map.Controls.Add(this.btn_FormSizeIncrease);
            this.pnl_Map.Controls.Add(this.btn_DeZoom);
            this.pnl_Map.Controls.Add(this.label1);
            this.pnl_Map.Controls.Add(this.btn_ResetMapVisuals);
            this.pnl_Map.Controls.Add(this.btn_FormSizeDecrease);
            this.pnl_Map.Controls.Add(this.btn_Zoom);
            this.pnl_Map.Controls.Add(this.lbl_PanelInfo);
            this.pnl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Map.Location = new System.Drawing.Point(0, 0);
            this.pnl_Map.Name = "pnl_Map";
            this.pnl_Map.Size = new System.Drawing.Size(1000, 1000);
            this.pnl_Map.TabIndex = 0;
            this.pnl_Map.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMap_Paint);
            this.pnl_Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Map_MouseDown);
            // 
            // btn_DeZoom
            // 
            this.btn_DeZoom.Location = new System.Drawing.Point(201, 4);
            this.btn_DeZoom.Name = "btn_DeZoom";
            this.btn_DeZoom.Size = new System.Drawing.Size(20, 20);
            this.btn_DeZoom.TabIndex = 1;
            this.btn_DeZoom.Text = "-";
            this.btn_DeZoom.UseVisualStyleBackColor = true;
            this.btn_DeZoom.Click += new System.EventHandler(this.btn_DeZoom_Click);
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
            // btn_ResetMapVisuals
            // 
            this.btn_ResetMapVisuals.Location = new System.Drawing.Point(175, 4);
            this.btn_ResetMapVisuals.Name = "btn_ResetMapVisuals";
            this.btn_ResetMapVisuals.Size = new System.Drawing.Size(20, 20);
            this.btn_ResetMapVisuals.TabIndex = 1;
            this.btn_ResetMapVisuals.Text = "0";
            this.btn_ResetMapVisuals.UseVisualStyleBackColor = true;
            this.btn_ResetMapVisuals.Click += new System.EventHandler(this.btn_ResetMapVisuals_Click);
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.Location = new System.Drawing.Point(149, 4);
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.Size = new System.Drawing.Size(20, 20);
            this.btn_Zoom.TabIndex = 1;
            this.btn_Zoom.Text = "+";
            this.btn_Zoom.UseVisualStyleBackColor = true;
            this.btn_Zoom.Click += new System.EventHandler(this.btn_Zoom_Click);
            // 
            // lbl_PanelInfo
            // 
            this.lbl_PanelInfo.AutoSize = true;
            this.lbl_PanelInfo.Location = new System.Drawing.Point(227, 4);
            this.lbl_PanelInfo.Name = "lbl_PanelInfo";
            this.lbl_PanelInfo.Size = new System.Drawing.Size(72, 13);
            this.lbl_PanelInfo.TabIndex = 0;
            this.lbl_PanelInfo.Text = "Panel Values:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(12, 30);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(103, 21);
            this.ComboBox_Systems.TabIndex = 1;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(121, 29);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_SystemsRefresh.TabIndex = 3;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // btn_FormSizeDecrease
            // 
            this.btn_FormSizeDecrease.Location = new System.Drawing.Point(149, 30);
            this.btn_FormSizeDecrease.Name = "btn_FormSizeDecrease";
            this.btn_FormSizeDecrease.Size = new System.Drawing.Size(20, 20);
            this.btn_FormSizeDecrease.TabIndex = 1;
            this.btn_FormSizeDecrease.Text = "<";
            this.btn_FormSizeDecrease.UseVisualStyleBackColor = true;
            this.btn_FormSizeDecrease.Click += new System.EventHandler(this.btn_FormSizeDecrease_Click);
            // 
            // btn_FormSizeIncrease
            // 
            this.btn_FormSizeIncrease.Location = new System.Drawing.Point(201, 30);
            this.btn_FormSizeIncrease.Name = "btn_FormSizeIncrease";
            this.btn_FormSizeIncrease.Size = new System.Drawing.Size(20, 20);
            this.btn_FormSizeIncrease.TabIndex = 1;
            this.btn_FormSizeIncrease.Text = ">";
            this.btn_FormSizeIncrease.UseVisualStyleBackColor = true;
            this.btn_FormSizeIncrease.Click += new System.EventHandler(this.btn_FormSizeIncrease_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.pnl_Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Map";
            this.Text = "Map";
            this.pnl_Map.ResumeLayout(false);
            this.pnl_Map.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.Label lbl_PanelInfo;
        private System.Windows.Forms.Button btn_Zoom;
        private System.Windows.Forms.Button btn_DeZoom;
        private System.Windows.Forms.Button btn_ResetMapVisuals;
        private System.Windows.Forms.Button btn_FormSizeIncrease;
        private System.Windows.Forms.Button btn_FormSizeDecrease;
    }
}