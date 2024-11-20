namespace SSSystemGenerator.Forms
{
    partial class CustomEntities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomEntities));
            this.btn_PlanetsRefresh = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_TypeID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_CustomEntity = new System.Windows.Forms.Button();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.ComboBox_Entities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Faction = new System.Windows.Forms.TextBox();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_Angle = new System.Windows.Forms.NumericUpDown();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.nud_MaxSpin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_MinSpin = new System.Windows.Forms.NumericUpDown();
            this.nud_OrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.ComboBox_OrbitMode = new System.Windows.Forms.ComboBox();
            this.tb_Info = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PlanetsRefresh
            // 
            this.btn_PlanetsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_PlanetsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PlanetsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_PlanetsRefresh.Location = new System.Drawing.Point(217, 80);
            this.btn_PlanetsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PlanetsRefresh.Name = "btn_PlanetsRefresh";
            this.btn_PlanetsRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_PlanetsRefresh.TabIndex = 128;
            this.btn_PlanetsRefresh.UseVisualStyleBackColor = true;
            this.btn_PlanetsRefresh.Click += new System.EventHandler(this.btn_CustomEntities_Refresh);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(217, 31);
            this.btn_SystemsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_SystemsRefresh.TabIndex = 127;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 126;
            this.label13.Text = "Type ID:";
            // 
            // tb_TypeID
            // 
            this.tb_TypeID.Location = new System.Drawing.Point(12, 224);
            this.tb_TypeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TypeID.Name = "tb_TypeID";
            this.tb_TypeID.Size = new System.Drawing.Size(233, 22);
            this.tb_TypeID.TabIndex = 96;
            this.tb_TypeID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 156);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 124;
            this.label16.Text = "Name (optional):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 125;
            this.label12.Text = "ID:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 176);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(233, 22);
            this.tb_Name.TabIndex = 95;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 128);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(233, 22);
            this.tb_ID.TabIndex = 94;
            this.tb_ID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(201, 532);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(49, 44);
            this.btn_Undo.TabIndex = 109;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(12, 532);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(181, 44);
            this.btn_Delete.TabIndex = 108;
            this.btn_Delete.Text = "Delete Entity";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_CustomEntity
            // 
            this.btn_CustomEntity.Enabled = false;
            this.btn_CustomEntity.Location = new System.Drawing.Point(12, 468);
            this.btn_CustomEntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CustomEntity.Name = "btn_CustomEntity";
            this.btn_CustomEntity.Size = new System.Drawing.Size(239, 57);
            this.btn_CustomEntity.TabIndex = 107;
            this.btn_CustomEntity.Text = "Add Custom Entity";
            this.btn_CustomEntity.UseVisualStyleBackColor = true;
            this.btn_CustomEntity.Click += new System.EventHandler(this.btn_CustomEntity_Click);
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(12, 31);
            this.ComboBox_Systems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(196, 24);
            this.ComboBox_Systems.TabIndex = 92;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // ComboBox_Entities
            // 
            this.ComboBox_Entities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Entities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Entities.FormattingEnabled = true;
            this.ComboBox_Entities.Location = new System.Drawing.Point(12, 80);
            this.ComboBox_Entities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_Entities.Name = "ComboBox_Entities";
            this.ComboBox_Entities.Size = new System.Drawing.Size(196, 24);
            this.ComboBox_Entities.TabIndex = 93;
            this.ComboBox_Entities.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Entities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Parent System:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Entities In The Selected System:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 130;
            this.label7.Text = "Faction ID:";
            // 
            // tb_Faction
            // 
            this.tb_Faction.Location = new System.Drawing.Point(12, 272);
            this.tb_Faction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Faction.Name = "tb_Faction";
            this.tb_Faction.Size = new System.Drawing.Size(233, 22);
            this.tb_Faction.TabIndex = 129;
            this.tb_Faction.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // nud_X
            // 
            this.nud_X.Enabled = false;
            this.nud_X.Location = new System.Drawing.Point(263, 128);
            this.nud_X.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_X.TabIndex = 100;
            // 
            // nud_Y
            // 
            this.nud_Y.Enabled = false;
            this.nud_Y.Location = new System.Drawing.Point(409, 128);
            this.nud_Y.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_Y.TabIndex = 101;
            // 
            // nud_Angle
            // 
            this.nud_Angle.Enabled = false;
            this.nud_Angle.Location = new System.Drawing.Point(263, 175);
            this.nud_Angle.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_Angle.TabIndex = 102;
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Enabled = false;
            this.nud_OrbitRadius.Location = new System.Drawing.Point(409, 175);
            this.nud_OrbitRadius.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_OrbitRadius.TabIndex = 103;
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Enabled = false;
            this.nud_MaxSpin.Location = new System.Drawing.Point(411, 271);
            this.nud_MaxSpin.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_MaxSpin.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "X";
            // 
            // nud_MinSpin
            // 
            this.nud_MinSpin.Enabled = false;
            this.nud_MinSpin.Location = new System.Drawing.Point(263, 271);
            this.nud_MinSpin.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_MinSpin.TabIndex = 105;
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Enabled = false;
            this.nud_OrbitDays.Location = new System.Drawing.Point(263, 224);
            this.nud_OrbitDays.Margin = new System.Windows.Forms.Padding(4);
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
            this.nud_OrbitDays.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Angle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 119;
            this.label9.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "Orbit Radius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 116;
            this.label5.Text = "Max Spin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 117;
            this.label10.Text = "Min Spin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 118;
            this.label6.Text = "Orbit Days";
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(263, 79);
            this.ComboBox_FocusID.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(197, 24);
            this.ComboBox_FocusID.TabIndex = 99;
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
            this.ComboBox_OrbitMode.Location = new System.Drawing.Point(263, 31);
            this.ComboBox_OrbitMode.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_OrbitMode.Name = "ComboBox_OrbitMode";
            this.ComboBox_OrbitMode.Size = new System.Drawing.Size(235, 24);
            this.ComboBox_OrbitMode.TabIndex = 98;
            this.ComboBox_OrbitMode.SelectedIndexChanged += new System.EventHandler(this.ComboBox_OrbitMode_SelectedIndexChanged);
            // 
            // tb_Info
            // 
            this.tb_Info.Location = new System.Drawing.Point(263, 303);
            this.tb_Info.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Info.Multiline = true;
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.ReadOnly = true;
            this.tb_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Info.Size = new System.Drawing.Size(235, 274);
            this.tb_Info.TabIndex = 120;
            this.tb_Info.Text = resources.GetString("tb_Info.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 121;
            this.label11.Text = "Orbit Mode:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Focus:";
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(469, 79);
            this.btn_FocusRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_FocusRefresh.TabIndex = 123;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            this.btn_FocusRefresh.Click += new System.EventHandler(this.btn_FocusRefresh_Click);
            // 
            // CustomEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Faction);
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
            this.Controls.Add(this.btn_CustomEntity);
            this.Controls.Add(this.ComboBox_Systems);
            this.Controls.Add(this.ComboBox_Entities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomEntities";
            this.Text = "CustomEntities";
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlanetsRefresh;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_TypeID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_CustomEntity;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.ComboBox ComboBox_Entities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Faction;
        private System.Windows.Forms.NumericUpDown nud_X;
        private System.Windows.Forms.NumericUpDown nud_Y;
        private System.Windows.Forms.NumericUpDown nud_Angle;
        private System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        private System.Windows.Forms.NumericUpDown nud_MaxSpin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_MinSpin;
        private System.Windows.Forms.NumericUpDown nud_OrbitDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_FocusID;
        private System.Windows.Forms.ComboBox ComboBox_OrbitMode;
        private System.Windows.Forms.TextBox tb_Info;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_FocusRefresh;
    }
}