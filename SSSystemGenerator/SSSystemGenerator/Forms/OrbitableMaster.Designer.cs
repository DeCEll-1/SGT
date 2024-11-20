namespace SSSystemGenerator.Forms
{
    partial class OrbitableMaster
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
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Spin = new System.Windows.Forms.CheckBox();
            this.cb_PointingDown = new System.Windows.Forms.CheckBox();
            this.lbl_Focus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_OrbitMode = new System.Windows.Forms.ComboBox();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.lbl_OrbitDays = new System.Windows.Forms.Label();
            this.lbl_MinSpin = new System.Windows.Forms.Label();
            this.lbl_MaxSpin = new System.Windows.Forms.Label();
            this.lbl_OrbitRadius = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_Angle = new System.Windows.Forms.Label();
            this.nud_OrbitDays = new System.Windows.Forms.NumericUpDown();
            this.nud_MinSpin = new System.Windows.Forms.NumericUpDown();
            this.lbl_x = new System.Windows.Forms.Label();
            this.nud_MaxSpin = new System.Windows.Forms.NumericUpDown();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.nud_Angle = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_TypeID = new System.Windows.Forms.TextBox();
            this.lbl_StuffOrbitingAround = new System.Windows.Forms.Label();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.btn_Clone = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ComboBox_Selectables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(13, 29);
            this.ComboBox_Systems.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(199, 24);
            this.ComboBox_Systems.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Systems:";
            // 
            // cb_Spin
            // 
            this.cb_Spin.AutoSize = true;
            this.cb_Spin.Location = new System.Drawing.Point(275, 246);
            this.cb_Spin.Name = "cb_Spin";
            this.cb_Spin.Size = new System.Drawing.Size(56, 20);
            this.cb_Spin.TabIndex = 115;
            this.cb_Spin.Text = "Spin";
            this.cb_Spin.UseVisualStyleBackColor = true;
            // 
            // cb_PointingDown
            // 
            this.cb_PointingDown.AutoSize = true;
            this.cb_PointingDown.Location = new System.Drawing.Point(275, 220);
            this.cb_PointingDown.Name = "cb_PointingDown";
            this.cb_PointingDown.Size = new System.Drawing.Size(114, 20);
            this.cb_PointingDown.TabIndex = 114;
            this.cb_PointingDown.Text = "Pointing Down";
            this.cb_PointingDown.UseVisualStyleBackColor = true;
            // 
            // lbl_Focus
            // 
            this.lbl_Focus.AutoSize = true;
            this.lbl_Focus.Location = new System.Drawing.Point(272, 57);
            this.lbl_Focus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Focus.Name = "lbl_Focus";
            this.lbl_Focus.Size = new System.Drawing.Size(47, 16);
            this.lbl_Focus.TabIndex = 112;
            this.lbl_Focus.Text = "Focus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 111;
            this.label11.Text = "Orbit Mode:";
            // 
            // cb_OrbitMode
            // 
            this.cb_OrbitMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OrbitMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_OrbitMode.FormattingEnabled = true;
            this.cb_OrbitMode.Items.AddRange(new object[] {
            "Fixed Location",
            "Circular Orbit"});
            this.cb_OrbitMode.Location = new System.Drawing.Point(275, 29);
            this.cb_OrbitMode.Margin = new System.Windows.Forms.Padding(4);
            this.cb_OrbitMode.Name = "cb_OrbitMode";
            this.cb_OrbitMode.Size = new System.Drawing.Size(231, 24);
            this.cb_OrbitMode.TabIndex = 95;
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(275, 78);
            this.ComboBox_FocusID.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(201, 24);
            this.ComboBox_FocusID.TabIndex = 96;
            // 
            // lbl_OrbitDays
            // 
            this.lbl_OrbitDays.AutoSize = true;
            this.lbl_OrbitDays.Location = new System.Drawing.Point(416, 200);
            this.lbl_OrbitDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrbitDays.Name = "lbl_OrbitDays";
            this.lbl_OrbitDays.Size = new System.Drawing.Size(70, 16);
            this.lbl_OrbitDays.TabIndex = 109;
            this.lbl_OrbitDays.Text = "Orbit Days";
            // 
            // lbl_MinSpin
            // 
            this.lbl_MinSpin.AutoSize = true;
            this.lbl_MinSpin.Location = new System.Drawing.Point(272, 269);
            this.lbl_MinSpin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MinSpin.Name = "lbl_MinSpin";
            this.lbl_MinSpin.Size = new System.Drawing.Size(58, 16);
            this.lbl_MinSpin.TabIndex = 108;
            this.lbl_MinSpin.Text = "Min Spin";
            // 
            // lbl_MaxSpin
            // 
            this.lbl_MaxSpin.AutoSize = true;
            this.lbl_MaxSpin.Location = new System.Drawing.Point(416, 269);
            this.lbl_MaxSpin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaxSpin.Name = "lbl_MaxSpin";
            this.lbl_MaxSpin.Size = new System.Drawing.Size(62, 16);
            this.lbl_MaxSpin.TabIndex = 107;
            this.lbl_MaxSpin.Text = "Max Spin";
            // 
            // lbl_OrbitRadius
            // 
            this.lbl_OrbitRadius.AutoSize = true;
            this.lbl_OrbitRadius.Location = new System.Drawing.Point(416, 155);
            this.lbl_OrbitRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrbitRadius.Name = "lbl_OrbitRadius";
            this.lbl_OrbitRadius.Size = new System.Drawing.Size(81, 16);
            this.lbl_OrbitRadius.TabIndex = 106;
            this.lbl_OrbitRadius.Text = "Orbit Radius";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(416, 109);
            this.lbl_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(16, 16);
            this.lbl_y.TabIndex = 110;
            this.lbl_y.Text = "Y";
            // 
            // lbl_Angle
            // 
            this.lbl_Angle.AutoSize = true;
            this.lbl_Angle.Location = new System.Drawing.Point(272, 155);
            this.lbl_Angle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Angle.Name = "lbl_Angle";
            this.lbl_Angle.Size = new System.Drawing.Size(42, 16);
            this.lbl_Angle.TabIndex = 105;
            this.lbl_Angle.Text = "Angle";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Location = new System.Drawing.Point(419, 220);
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
            this.nud_OrbitDays.TabIndex = 101;
            // 
            // nud_MinSpin
            // 
            this.nud_MinSpin.Location = new System.Drawing.Point(275, 289);
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
            this.nud_MinSpin.TabIndex = 102;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(272, 109);
            this.lbl_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(15, 16);
            this.lbl_x.TabIndex = 104;
            this.lbl_x.Text = "X";
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Location = new System.Drawing.Point(419, 289);
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
            this.nud_MaxSpin.TabIndex = 103;
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Location = new System.Drawing.Point(419, 175);
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
            this.nud_OrbitRadius.TabIndex = 100;
            // 
            // nud_Angle
            // 
            this.nud_Angle.Location = new System.Drawing.Point(275, 175);
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
            this.nud_Angle.TabIndex = 99;
            // 
            // nud_Y
            // 
            this.nud_Y.Location = new System.Drawing.Point(419, 128);
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
            this.nud_Y.TabIndex = 98;
            // 
            // nud_X
            // 
            this.nud_X.Location = new System.Drawing.Point(275, 127);
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
            this.nud_X.TabIndex = 97;
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(483, 78);
            this.btn_FocusRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(24, 24);
            this.btn_FocusRefresh.TabIndex = 113;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(220, 29);
            this.btn_SystemsRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(24, 24);
            this.btn_SystemsRefresh.TabIndex = 45;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 154);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 118;
            this.label16.Text = "Name (optional):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 119;
            this.label12.Text = "ID:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(13, 174);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(233, 22);
            this.tb_Name.TabIndex = 117;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(13, 126);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(233, 22);
            this.tb_ID.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Type ID:";
            // 
            // tb_TypeID
            // 
            this.tb_TypeID.Location = new System.Drawing.Point(13, 220);
            this.tb_TypeID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TypeID.Name = "tb_TypeID";
            this.tb_TypeID.Size = new System.Drawing.Size(233, 22);
            this.tb_TypeID.TabIndex = 120;
            // 
            // lbl_StuffOrbitingAround
            // 
            this.lbl_StuffOrbitingAround.AutoSize = true;
            this.lbl_StuffOrbitingAround.Location = new System.Drawing.Point(13, 327);
            this.lbl_StuffOrbitingAround.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StuffOrbitingAround.Name = "lbl_StuffOrbitingAround";
            this.lbl_StuffOrbitingAround.Size = new System.Drawing.Size(130, 16);
            this.lbl_StuffOrbitingAround.TabIndex = 122;
            this.lbl_StuffOrbitingAround.Text = "Stuff Orbiting Around:";
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Location = new System.Drawing.Point(13, 311);
            this.lbl_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(44, 16);
            this.lbl_Order.TabIndex = 123;
            this.lbl_Order.Text = "Order:";
            // 
            // btn_Clone
            // 
            this.btn_Clone.BackgroundImage = global::SSSystemGenerator.Properties.Resources.CloneLightMode;
            this.btn_Clone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Clone.Location = new System.Drawing.Point(202, 481);
            this.btn_Clone.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clone.Name = "btn_Clone";
            this.btn_Clone.Size = new System.Drawing.Size(49, 46);
            this.btn_Clone.TabIndex = 127;
            this.btn_Clone.UseVisualStyleBackColor = true;
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(202, 534);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(49, 44);
            this.btn_Undo.TabIndex = 126;
            this.btn_Undo.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(13, 534);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(181, 44);
            this.btn_Delete.TabIndex = 125;
            this.btn_Delete.Text = "Delete Context";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(13, 481);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(181, 46);
            this.btn_Add.TabIndex = 124;
            this.btn_Add.Text = "Add Context";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Selectables
            // 
            this.ComboBox_Selectables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Selectables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Selectables.FormattingEnabled = true;
            this.ComboBox_Selectables.Location = new System.Drawing.Point(13, 76);
            this.ComboBox_Selectables.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Selectables.Name = "ComboBox_Selectables";
            this.ComboBox_Selectables.Size = new System.Drawing.Size(233, 24);
            this.ComboBox_Selectables.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 129;
            this.label1.Text = "Selectables On The Selected System:";
            // 
            // OrbitableMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 591);
            this.Controls.Add(this.ComboBox_Selectables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clone);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_StuffOrbitingAround);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_TypeID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.cb_Spin);
            this.Controls.Add(this.cb_PointingDown);
            this.Controls.Add(this.btn_FocusRefresh);
            this.Controls.Add(this.lbl_Focus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_OrbitMode);
            this.Controls.Add(this.ComboBox_FocusID);
            this.Controls.Add(this.lbl_OrbitDays);
            this.Controls.Add(this.lbl_MinSpin);
            this.Controls.Add(this.lbl_MaxSpin);
            this.Controls.Add(this.lbl_OrbitRadius);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_Angle);
            this.Controls.Add(this.nud_OrbitDays);
            this.Controls.Add(this.nud_MinSpin);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.nud_MaxSpin);
            this.Controls.Add(this.nud_OrbitRadius);
            this.Controls.Add(this.nud_Angle);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.nud_X);
            this.Controls.Add(this.btn_SystemsRefresh);
            this.Controls.Add(this.ComboBox_Systems);
            this.Controls.Add(this.label2);
            this.Name = "OrbitableMaster";
            this.Text = "OrbitableMaster";
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

        internal System.Windows.Forms.Button btn_SystemsRefresh;
        internal System.Windows.Forms.ComboBox ComboBox_Systems;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.CheckBox cb_Spin;
        internal System.Windows.Forms.Button btn_FocusRefresh;
        internal System.Windows.Forms.Label lbl_Focus;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cb_OrbitMode;
        internal System.Windows.Forms.ComboBox ComboBox_FocusID;
        internal System.Windows.Forms.Label lbl_OrbitDays;
        internal System.Windows.Forms.Label lbl_MinSpin;
        internal System.Windows.Forms.Label lbl_MaxSpin;
        internal System.Windows.Forms.Label lbl_OrbitRadius;
        internal System.Windows.Forms.Label lbl_y;
        internal System.Windows.Forms.Label lbl_Angle;
        internal System.Windows.Forms.NumericUpDown nud_OrbitDays;
        internal System.Windows.Forms.NumericUpDown nud_MinSpin;
        internal System.Windows.Forms.Label lbl_x;
        internal System.Windows.Forms.NumericUpDown nud_MaxSpin;
        internal System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        internal System.Windows.Forms.NumericUpDown nud_Angle;
        internal System.Windows.Forms.NumericUpDown nud_Y;
        internal System.Windows.Forms.NumericUpDown nud_X;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox tb_Name;
        internal System.Windows.Forms.TextBox tb_ID;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox tb_TypeID;
        internal System.Windows.Forms.Label lbl_StuffOrbitingAround;
        internal System.Windows.Forms.Label lbl_Order;
        internal System.Windows.Forms.CheckBox cb_PointingDown;
        internal System.Windows.Forms.Button btn_Clone;
        internal System.Windows.Forms.Button btn_Undo;
        internal System.Windows.Forms.Button btn_Delete;
        internal System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.ComboBox ComboBox_Selectables;
        internal System.Windows.Forms.Label label1;
    }
}