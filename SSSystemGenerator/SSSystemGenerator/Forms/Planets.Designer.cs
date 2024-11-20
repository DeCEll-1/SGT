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
            this.btn_PlanetsRefresh = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            this.btn_Clone = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.lbl_StuffOrbitingAround = new System.Windows.Forms.Label();
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
            this.label7.Location = new System.Drawing.Point(16, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Radius";
            // 
            // nud_Radius
            // 
            this.nud_Radius.Location = new System.Drawing.Point(15, 273);
            this.nud_Radius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_Radius.Size = new System.Drawing.Size(96, 22);
            this.nud_Radius.TabIndex = 6;
            this.nud_Radius.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // ComboBox_Planets
            // 
            this.ComboBox_Planets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Planets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Planets.FormattingEnabled = true;
            this.ComboBox_Planets.Location = new System.Drawing.Point(15, 80);
            this.ComboBox_Planets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Planets.Name = "ComboBox_Planets";
            this.ComboBox_Planets.Size = new System.Drawing.Size(196, 24);
            this.ComboBox_Planets.TabIndex = 1;
            this.ComboBox_Planets.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Planets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Planets On The Selected System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Parent System:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(15, 31);
            this.ComboBox_Systems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(196, 24);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // btn_Planet
            // 
            this.btn_Planet.Enabled = false;
            this.btn_Planet.Location = new System.Drawing.Point(16, 479);
            this.btn_Planet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Planet.Name = "btn_Planet";
            this.btn_Planet.Size = new System.Drawing.Size(181, 46);
            this.btn_Planet.TabIndex = 17;
            this.btn_Planet.Text = "Add Planet";
            this.btn_Planet.UseVisualStyleBackColor = true;
            this.btn_Planet.Click += new System.EventHandler(this.btn_Planet_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(15, 532);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(181, 44);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Delete Planet";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(265, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Focus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 81;
            this.label11.Text = "Orbit Mode:";
            // 
            // tb_Info
            // 
            this.tb_Info.Location = new System.Drawing.Point(265, 303);
            this.tb_Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Info.Multiline = true;
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.ReadOnly = true;
            this.tb_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Info.Size = new System.Drawing.Size(235, 274);
            this.tb_Info.TabIndex = 80;
            this.tb_Info.Text = resources.GetString("tb_Info.Text");
            // 
            // ComboBox_OrbitMode
            // 
            this.ComboBox_OrbitMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_OrbitMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_OrbitMode.FormattingEnabled = true;
            this.ComboBox_OrbitMode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.ComboBox_OrbitMode.Location = new System.Drawing.Point(265, 31);
            this.ComboBox_OrbitMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_OrbitMode.Name = "ComboBox_OrbitMode";
            this.ComboBox_OrbitMode.Size = new System.Drawing.Size(235, 24);
            this.ComboBox_OrbitMode.TabIndex = 7;
            this.ComboBox_OrbitMode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrbitMode_SelectedIndexChanged);
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(265, 79);
            this.ComboBox_FocusID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(197, 24);
            this.ComboBox_FocusID.TabIndex = 8;
            this.ComboBox_FocusID.SelectedIndexChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Orbit Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Min Spin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Max Spin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Orbit Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Angle";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Enabled = false;
            this.nud_OrbitDays.Location = new System.Drawing.Point(265, 224);
            this.nud_OrbitDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_OrbitDays.Size = new System.Drawing.Size(92, 22);
            this.nud_OrbitDays.TabIndex = 14;
            this.nud_OrbitDays.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_MinSpin
            // 
            this.nud_MinSpin.Enabled = false;
            this.nud_MinSpin.Location = new System.Drawing.Point(265, 271);
            this.nud_MinSpin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_MinSpin.Size = new System.Drawing.Size(92, 22);
            this.nud_MinSpin.TabIndex = 15;
            this.nud_MinSpin.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "X";
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Enabled = false;
            this.nud_MaxSpin.Location = new System.Drawing.Point(413, 271);
            this.nud_MaxSpin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_MaxSpin.Size = new System.Drawing.Size(92, 22);
            this.nud_MaxSpin.TabIndex = 16;
            this.nud_MaxSpin.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Enabled = false;
            this.nud_OrbitRadius.Location = new System.Drawing.Point(412, 175);
            this.nud_OrbitRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_OrbitRadius.Size = new System.Drawing.Size(92, 22);
            this.nud_OrbitRadius.TabIndex = 13;
            this.nud_OrbitRadius.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_Angle
            // 
            this.nud_Angle.Enabled = false;
            this.nud_Angle.Location = new System.Drawing.Point(265, 175);
            this.nud_Angle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_Angle.Size = new System.Drawing.Size(92, 22);
            this.nud_Angle.TabIndex = 12;
            this.nud_Angle.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_Y
            // 
            this.nud_Y.Enabled = false;
            this.nud_Y.Location = new System.Drawing.Point(412, 128);
            this.nud_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_Y.Size = new System.Drawing.Size(92, 22);
            this.nud_Y.TabIndex = 11;
            this.nud_Y.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_X
            // 
            this.nud_X.Enabled = false;
            this.nud_X.Location = new System.Drawing.Point(265, 128);
            this.nud_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.nud_X.Size = new System.Drawing.Size(92, 22);
            this.nud_X.TabIndex = 10;
            this.nud_X.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 89;
            this.label13.Text = "Type ID:";
            // 
            // tb_TypeID
            // 
            this.tb_TypeID.Location = new System.Drawing.Point(15, 224);
            this.tb_TypeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TypeID.Name = "tb_TypeID";
            this.tb_TypeID.Size = new System.Drawing.Size(233, 22);
            this.tb_TypeID.TabIndex = 5;
            this.tb_TypeID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 156);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 87;
            this.label16.Text = "Name (optional):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 88;
            this.label12.Text = "ID:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(15, 176);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(233, 22);
            this.tb_Name.TabIndex = 4;
            this.tb_Name.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(15, 128);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(233, 22);
            this.tb_ID.TabIndex = 3;
            this.tb_ID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // btn_PlanetsRefresh
            // 
            this.btn_PlanetsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_PlanetsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PlanetsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_PlanetsRefresh.Location = new System.Drawing.Point(220, 80);
            this.btn_PlanetsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PlanetsRefresh.Name = "btn_PlanetsRefresh";
            this.btn_PlanetsRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_PlanetsRefresh.TabIndex = 2;
            this.btn_PlanetsRefresh.UseVisualStyleBackColor = true;
            this.btn_PlanetsRefresh.Click += new System.EventHandler(this.btn_PlanetsRefresh_Click);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(220, 31);
            this.btn_SystemsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_SystemsRefresh.TabIndex = 90;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(472, 79);
            this.btn_FocusRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_FocusRefresh.TabIndex = 9;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            this.btn_FocusRefresh.Click += new System.EventHandler(this.btn_FocusRefresh_Click);
            // 
            // btn_Clone
            // 
            this.btn_Clone.BackgroundImage = global::SSSystemGenerator.Properties.Resources.CloneLightMode;
            this.btn_Clone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Clone.Location = new System.Drawing.Point(204, 479);
            this.btn_Clone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clone.Name = "btn_Clone";
            this.btn_Clone.Size = new System.Drawing.Size(49, 46);
            this.btn_Clone.TabIndex = 18;
            this.btn_Clone.UseVisualStyleBackColor = true;
            this.btn_Clone.Click += new System.EventHandler(this.btn_Clone_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(204, 532);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(49, 44);
            this.btn_Undo.TabIndex = 20;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Location = new System.Drawing.Point(16, 302);
            this.lbl_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(44, 16);
            this.lbl_Order.TabIndex = 91;
            this.lbl_Order.Text = "Order:";
            // 
            // lbl_StuffOrbitingAround
            // 
            this.lbl_StuffOrbitingAround.AutoSize = true;
            this.lbl_StuffOrbitingAround.Location = new System.Drawing.Point(16, 318);
            this.lbl_StuffOrbitingAround.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StuffOrbitingAround.Name = "lbl_StuffOrbitingAround";
            this.lbl_StuffOrbitingAround.Size = new System.Drawing.Size(130, 16);
            this.lbl_StuffOrbitingAround.TabIndex = 91;
            this.lbl_StuffOrbitingAround.Text = "Stuff Orbiting Around:";
            // 
            // Planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 586);
            this.Controls.Add(this.lbl_StuffOrbitingAround);
            this.Controls.Add(this.lbl_Order);
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
            this.Controls.Add(this.btn_Clone);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_Clone;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Label lbl_StuffOrbitingAround;
    }
}