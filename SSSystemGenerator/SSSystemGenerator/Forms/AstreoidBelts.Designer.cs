namespace SSSystemGenerator.Forms
{
    partial class AstreoidBelts
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
            this.btn_Undo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_AstreoidCount = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.nud_MinOrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_AstreoidBelts = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_RingBand = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.ComboBox_TerrainID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.nud_MaxOrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AstreoidCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinOrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxOrbitDays)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(165, 464);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(30, 30);
            this.btn_Undo.TabIndex = 7;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Width:";
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(125, 438);
            this.nud_Width.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(55, 20);
            this.nud_Width.TabIndex = 5;
            this.nud_Width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_Width.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "Number Of Astreoids:";
            // 
            // nud_AstreoidCount
            // 
            this.nud_AstreoidCount.Location = new System.Drawing.Point(12, 438);
            this.nud_AstreoidCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_AstreoidCount.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_AstreoidCount.Name = "nud_AstreoidCount";
            this.nud_AstreoidCount.Size = new System.Drawing.Size(103, 20);
            this.nud_AstreoidCount.TabIndex = 4;
            this.nud_AstreoidCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_AstreoidCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_AstreoidCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 13);
            this.label32.TabIndex = 113;
            this.label32.Text = "Min Orbit Days:";
            // 
            // nud_MinOrbitDays
            // 
            this.nud_MinOrbitDays.Location = new System.Drawing.Point(6, 79);
            this.nud_MinOrbitDays.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MinOrbitDays.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_MinOrbitDays.Name = "nud_MinOrbitDays";
            this.nud_MinOrbitDays.Size = new System.Drawing.Size(74, 20);
            this.nud_MinOrbitDays.TabIndex = 1;
            this.nud_MinOrbitDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MinOrbitDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MinOrbitDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 13);
            this.label33.TabIndex = 112;
            this.label33.Text = "Orbit Radius:";
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Location = new System.Drawing.Point(6, 37);
            this.nud_OrbitRadius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_OrbitRadius.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_OrbitRadius.Name = "nud_OrbitRadius";
            this.nud_OrbitRadius.Size = new System.Drawing.Size(74, 20);
            this.nud_OrbitRadius.TabIndex = 0;
            this.nud_OrbitRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitRadius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(12, 500);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(183, 35);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete Astreoid Belt";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBox_AstreoidBelts);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ComboBox_FocusID);
            this.groupBox1.Controls.Add(this.btn_FocusRefresh);
            this.groupBox1.Controls.Add(this.btn_SystemsRefresh);
            this.groupBox1.Controls.Add(this.ComboBox_Systems);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Astreoid Belts On Selected System:";
            // 
            // ComboBox_AstreoidBelts
            // 
            this.ComboBox_AstreoidBelts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AstreoidBelts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_AstreoidBelts.FormattingEnabled = true;
            this.ComboBox_AstreoidBelts.Location = new System.Drawing.Point(6, 110);
            this.ComboBox_AstreoidBelts.Name = "ComboBox_AstreoidBelts";
            this.ComboBox_AstreoidBelts.Size = new System.Drawing.Size(167, 21);
            this.ComboBox_AstreoidBelts.TabIndex = 4;
            this.ComboBox_AstreoidBelts.SelectedIndexChanged += new System.EventHandler(this.ComboBox_RingBands_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 95;
            this.label14.Text = "Focus:";
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(6, 71);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(139, 21);
            this.ComboBox_FocusID.TabIndex = 2;
            this.ComboBox_FocusID.SelectedIndexChanged += new System.EventHandler(this.ComboBox_FocusID_SelectedIndexChanged);
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(151, 71);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_FocusRefresh.TabIndex = 3;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            this.btn_FocusRefresh.Click += new System.EventHandler(this.btn_FocusRefresh_Click);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(151, 32);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_SystemsRefresh.TabIndex = 1;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(5, 32);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(140, 21);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Parent System:";
            // 
            // btn_RingBand
            // 
            this.btn_RingBand.Enabled = false;
            this.btn_RingBand.Location = new System.Drawing.Point(12, 464);
            this.btn_RingBand.Name = "btn_RingBand";
            this.btn_RingBand.Size = new System.Drawing.Size(147, 30);
            this.btn_RingBand.TabIndex = 6;
            this.btn_RingBand.Text = "Add Astreoid Belt";
            this.btn_RingBand.UseVisualStyleBackColor = true;
            this.btn_RingBand.Click += new System.EventHandler(this.btn_AstreoidBelt_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 111;
            this.label18.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(6, 72);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(171, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 16);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(164, 13);
            this.label40.TabIndex = 110;
            this.label40.Text = "Terrain ID (type for custom ones):";
            // 
            // ComboBox_TerrainID
            // 
            this.ComboBox_TerrainID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_TerrainID.FormattingEnabled = true;
            this.ComboBox_TerrainID.Location = new System.Drawing.Point(6, 32);
            this.ComboBox_TerrainID.Name = "ComboBox_TerrainID";
            this.ComboBox_TerrainID.Size = new System.Drawing.Size(171, 21);
            this.ComboBox_TerrainID.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 109;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 169);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(183, 20);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_MaxOrbitDays
            // 
            this.nud_MaxOrbitDays.Location = new System.Drawing.Point(94, 79);
            this.nud_MaxOrbitDays.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MaxOrbitDays.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_MaxOrbitDays.Name = "nud_MaxOrbitDays";
            this.nud_MaxOrbitDays.Size = new System.Drawing.Size(74, 20);
            this.nud_MaxOrbitDays.TabIndex = 2;
            this.nud_MaxOrbitDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MaxOrbitDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MaxOrbitDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Max Orbit Days:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.ComboBox_TerrainID);
            this.groupBox2.Controls.Add(this.tb_Name);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optional";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.nud_OrbitRadius);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.nud_MinOrbitDays);
            this.groupBox3.Controls.Add(this.nud_MaxOrbitDays);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 108);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orbit";
            // 
            // AstreoidBelts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_Width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_AstreoidCount);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RingBand);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AstreoidBelts";
            this.Text = "AstreoidBelts";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AstreoidCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinOrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxOrbitDays)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_AstreoidCount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nud_MinOrbitDays;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_AstreoidBelts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboBox_FocusID;
        private System.Windows.Forms.Button btn_FocusRefresh;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_RingBand;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox ComboBox_TerrainID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.NumericUpDown nud_MaxOrbitDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}