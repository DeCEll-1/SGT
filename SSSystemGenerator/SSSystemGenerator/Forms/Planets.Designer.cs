namespace SSSystemGenerator.Forms
{
    partial class Planets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planets));
            this.label7 = new System.Windows.Forms.Label();
            this.nud_Radius = new System.Windows.Forms.NumericUpDown();
            this.ComboBox_Planets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.btn_Planet = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Info = new System.Windows.Forms.TextBox();
            this.ComboBox_OrbitMode = new System.Windows.Forms.ComboBox();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_OrbitDays = new System.Windows.Forms.NumericUpDown();
            this.nud_MinSpin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_MaxSpin = new System.Windows.Forms.NumericUpDown();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.nud_Angle = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_TypeID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.btn_PlanetsRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Radius";
            // 
            // nud_Radius
            // 
            this.nud_Radius.Location = new System.Drawing.Point(11, 222);
            this.nud_Radius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Radius.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_Radius.Name = "nud_Radius";
            this.nud_Radius.Size = new System.Drawing.Size(72, 20);
            this.nud_Radius.TabIndex = 5;
            // 
            // ComboBox_Planets
            // 
            this.ComboBox_Planets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Planets.FormattingEnabled = true;
            this.ComboBox_Planets.Location = new System.Drawing.Point(11, 65);
            this.ComboBox_Planets.Name = "ComboBox_Planets";
            this.ComboBox_Planets.Size = new System.Drawing.Size(148, 21);
            this.ComboBox_Planets.TabIndex = 1;
            this.ComboBox_Planets.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Planets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Planets On The Selected System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Parent System:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(11, 25);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(148, 21);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // btn_Planet
            // 
            this.btn_Planet.Enabled = false;
            this.btn_Planet.Location = new System.Drawing.Point(11, 380);
            this.btn_Planet.Name = "btn_Planet";
            this.btn_Planet.Size = new System.Drawing.Size(179, 46);
            this.btn_Planet.TabIndex = 15;
            this.btn_Planet.Text = "Add Planet";
            this.btn_Planet.UseVisualStyleBackColor = true;
            this.btn_Planet.Click += new System.EventHandler(this.btn_Planet_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(11, 432);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(136, 36);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete Planet";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(153, 432);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(37, 36);
            this.btn_Undo.TabIndex = 17;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(354, 64);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(22, 22);
            this.btn_FocusRefresh.TabIndex = 83;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            this.btn_FocusRefresh.Click += new System.EventHandler(this.btn_FocusRefresh_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 82;
            this.label14.Text = "Focus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Orbit Mode:";
            // 
            // tb_Info
            // 
            this.tb_Info.Location = new System.Drawing.Point(199, 246);
            this.tb_Info.Multiline = true;
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.ReadOnly = true;
            this.tb_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Info.Size = new System.Drawing.Size(177, 223);
            this.tb_Info.TabIndex = 80;
            this.tb_Info.Text = resources.GetString("tb_Info.Text");
            // 
            // ComboBox_OrbitMode
            // 
            this.ComboBox_OrbitMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_OrbitMode.FormattingEnabled = true;
            this.ComboBox_OrbitMode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.ComboBox_OrbitMode.Location = new System.Drawing.Point(199, 25);
            this.ComboBox_OrbitMode.Name = "ComboBox_OrbitMode";
            this.ComboBox_OrbitMode.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_OrbitMode.TabIndex = 6;
            this.ComboBox_OrbitMode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrbitMode_SelectedIndexChanged);
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(199, 64);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(149, 21);
            this.ComboBox_FocusID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Orbit Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Min Spin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Max Spin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Orbit Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Angle";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Enabled = false;
            this.nud_OrbitDays.Location = new System.Drawing.Point(199, 182);
            this.nud_OrbitDays.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_OrbitDays.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_OrbitDays.Name = "nud_OrbitDays";
            this.nud_OrbitDays.Size = new System.Drawing.Size(69, 20);
            this.nud_OrbitDays.TabIndex = 12;
            // 
            // nud_MinSpin
            // 
            this.nud_MinSpin.Enabled = false;
            this.nud_MinSpin.Location = new System.Drawing.Point(199, 220);
            this.nud_MinSpin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MinSpin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_MinSpin.Name = "nud_MinSpin";
            this.nud_MinSpin.Size = new System.Drawing.Size(69, 20);
            this.nud_MinSpin.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "X";
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Enabled = false;
            this.nud_MaxSpin.Location = new System.Drawing.Point(310, 220);
            this.nud_MaxSpin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MaxSpin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_MaxSpin.Name = "nud_MaxSpin";
            this.nud_MaxSpin.Size = new System.Drawing.Size(69, 20);
            this.nud_MaxSpin.TabIndex = 14;
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Enabled = false;
            this.nud_OrbitRadius.Location = new System.Drawing.Point(309, 142);
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
            this.nud_OrbitRadius.Size = new System.Drawing.Size(69, 20);
            this.nud_OrbitRadius.TabIndex = 11;
            // 
            // nud_Angle
            // 
            this.nud_Angle.Enabled = false;
            this.nud_Angle.Location = new System.Drawing.Point(199, 142);
            this.nud_Angle.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Angle.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_Angle.Name = "nud_Angle";
            this.nud_Angle.Size = new System.Drawing.Size(69, 20);
            this.nud_Angle.TabIndex = 10;
            // 
            // nud_Y
            // 
            this.nud_Y.Enabled = false;
            this.nud_Y.Location = new System.Drawing.Point(309, 104);
            this.nud_Y.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Y.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(69, 20);
            this.nud_Y.TabIndex = 9;
            // 
            // nud_X
            // 
            this.nud_X.Enabled = false;
            this.nud_X.Location = new System.Drawing.Point(199, 104);
            this.nud_X.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_X.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(69, 20);
            this.nud_X.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 89;
            this.label13.Text = "Type ID:";
            // 
            // tb_TypeID
            // 
            this.tb_TypeID.Location = new System.Drawing.Point(11, 182);
            this.tb_TypeID.Name = "tb_TypeID";
            this.tb_TypeID.Size = new System.Drawing.Size(176, 20);
            this.tb_TypeID.TabIndex = 4;
            this.tb_TypeID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 87;
            this.label16.Text = "Name (optional):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "ID:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(11, 143);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(176, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(11, 104);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(176, 20);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(165, 25);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 22);
            this.btn_SystemsRefresh.TabIndex = 90;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // btn_PlanetsRefresh
            // 
            this.btn_PlanetsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_PlanetsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PlanetsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_PlanetsRefresh.Location = new System.Drawing.Point(165, 65);
            this.btn_PlanetsRefresh.Name = "btn_PlanetsRefresh";
            this.btn_PlanetsRefresh.Size = new System.Drawing.Size(22, 22);
            this.btn_PlanetsRefresh.TabIndex = 91;
            this.btn_PlanetsRefresh.UseVisualStyleBackColor = true;
            this.btn_PlanetsRefresh.Click += new System.EventHandler(this.btn_PlanetsRefresh_Click);
            // 
            // Planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 476);
            this.Controls.Add(this.btn_PlanetsRefresh);
            this.Controls.Add(this.btn_SystemsRefresh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_TypeID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.btn_FocusRefresh);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Info);
            this.Controls.Add(this.ComboBox_OrbitMode);
            this.Controls.Add(this.ComboBox_FocusID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_OrbitDays);
            this.Controls.Add(this.nud_MinSpin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nud_MaxSpin);
            this.Controls.Add(this.nud_OrbitRadius);
            this.Controls.Add(this.nud_Angle);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.nud_X);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Planet);
            this.Controls.Add(this.ComboBox_Systems);
            this.Controls.Add(this.ComboBox_Planets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nud_Radius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Planets";
            this.Text = "Planets";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_Radius;
        private System.Windows.Forms.ComboBox ComboBox_Planets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Button btn_Planet;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_FocusRefresh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Info;
        private System.Windows.Forms.ComboBox ComboBox_OrbitMode;
        private System.Windows.Forms.ComboBox ComboBox_FocusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_OrbitDays;
        private System.Windows.Forms.NumericUpDown nud_MinSpin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_MaxSpin;
        private System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        private System.Windows.Forms.NumericUpDown nud_Angle;
        private System.Windows.Forms.NumericUpDown nud_Y;
        private System.Windows.Forms.NumericUpDown nud_X;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_TypeID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.Button btn_PlanetsRefresh;
    }
}