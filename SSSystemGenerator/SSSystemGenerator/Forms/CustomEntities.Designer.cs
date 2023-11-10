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
            this.label13 = new System.Windows.Forms.Label();
            this.tb_FactionID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_CustomEntityType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.nud_SystemY = new System.Windows.Forms.NumericUpDown();
            this.nud_SystemX = new System.Windows.Forms.NumericUpDown();
            this.btn_DeleteEntity = new System.Windows.Forms.Button();
            this.btn_AddEntity = new System.Windows.Forms.Button();
            this.ComboBox_Stars = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Faction ID:";
            // 
            // tb_FactionID
            // 
            this.tb_FactionID.Location = new System.Drawing.Point(15, 64);
            this.tb_FactionID.Name = "tb_FactionID";
            this.tb_FactionID.Size = new System.Drawing.Size(178, 20);
            this.tb_FactionID.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(15, 25);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(178, 20);
            this.tb_ID.TabIndex = 21;
            // 
            // tb_CustomEntityType
            // 
            this.tb_CustomEntityType.Location = new System.Drawing.Point(15, 103);
            this.tb_CustomEntityType.Name = "tb_CustomEntityType";
            this.tb_CustomEntityType.Size = new System.Drawing.Size(178, 20);
            this.tb_CustomEntityType.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Custom Entity Type (aka it\'s ID):";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(15, 142);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(178, 20);
            this.tb_Name.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Focus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Orbit Mode:";
            // 
            // tb_Info
            // 
            this.tb_Info.Enabled = false;
            this.tb_Info.Location = new System.Drawing.Point(200, 246);
            this.tb_Info.Multiline = true;
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.Size = new System.Drawing.Size(177, 223);
            this.tb_Info.TabIndex = 57;
            this.tb_Info.Text = resources.GetString("tb_Info.Text");
            // 
            // ComboBox_OrbitMode
            // 
            this.ComboBox_OrbitMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_OrbitMode.FormattingEnabled = true;
            this.ComboBox_OrbitMode.Location = new System.Drawing.Point(200, 64);
            this.ComboBox_OrbitMode.Name = "ComboBox_OrbitMode";
            this.ComboBox_OrbitMode.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_OrbitMode.TabIndex = 56;
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(199, 25);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_FocusID.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Orbit Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Min Spin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Max Spin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Orbit Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Angle";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Location = new System.Drawing.Point(201, 181);
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
            this.nud_OrbitDays.TabIndex = 44;
            // 
            // nud_MinSpin
            // 
            this.nud_MinSpin.Location = new System.Drawing.Point(201, 220);
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
            this.nud_MinSpin.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "X";
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Location = new System.Drawing.Point(311, 220);
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
            this.nud_MaxSpin.TabIndex = 42;
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Location = new System.Drawing.Point(310, 142);
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
            this.nud_OrbitRadius.TabIndex = 41;
            // 
            // nud_Angle
            // 
            this.nud_Angle.Location = new System.Drawing.Point(202, 142);
            this.nud_Angle.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Angle.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_Angle.Name = "nud_Angle";
            this.nud_Angle.Size = new System.Drawing.Size(69, 20);
            this.nud_Angle.TabIndex = 47;
            // 
            // nud_SystemY
            // 
            this.nud_SystemY.Location = new System.Drawing.Point(310, 104);
            this.nud_SystemY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_SystemY.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_SystemY.Name = "nud_SystemY";
            this.nud_SystemY.Size = new System.Drawing.Size(69, 20);
            this.nud_SystemY.TabIndex = 45;
            // 
            // nud_SystemX
            // 
            this.nud_SystemX.Location = new System.Drawing.Point(202, 103);
            this.nud_SystemX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_SystemX.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_SystemX.Name = "nud_SystemX";
            this.nud_SystemX.Size = new System.Drawing.Size(69, 20);
            this.nud_SystemX.TabIndex = 46;
            // 
            // btn_DeleteEntity
            // 
            this.btn_DeleteEntity.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DeleteEntity.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteEntity.Location = new System.Drawing.Point(12, 433);
            this.btn_DeleteEntity.Name = "btn_DeleteEntity";
            this.btn_DeleteEntity.Size = new System.Drawing.Size(178, 36);
            this.btn_DeleteEntity.TabIndex = 60;
            this.btn_DeleteEntity.Text = "Delete Entity";
            this.btn_DeleteEntity.UseVisualStyleBackColor = false;
            // 
            // btn_AddEntity
            // 
            this.btn_AddEntity.Location = new System.Drawing.Point(12, 391);
            this.btn_AddEntity.Name = "btn_AddEntity";
            this.btn_AddEntity.Size = new System.Drawing.Size(178, 36);
            this.btn_AddEntity.TabIndex = 61;
            this.btn_AddEntity.Text = "Add Entity";
            this.btn_AddEntity.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Stars
            // 
            this.ComboBox_Stars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Stars.FormattingEnabled = true;
            this.ComboBox_Stars.Location = new System.Drawing.Point(12, 364);
            this.ComboBox_Stars.Name = "ComboBox_Stars";
            this.ComboBox_Stars.Size = new System.Drawing.Size(178, 21);
            this.ComboBox_Stars.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Select Custom Entity To Edit:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(12, 324);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_Systems.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Systems:";
            // 
            // CustomEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 478);
            this.Controls.Add(this.ComboBox_Stars);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBox_Systems);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_DeleteEntity);
            this.Controls.Add(this.btn_AddEntity);
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
            this.Controls.Add(this.nud_SystemY);
            this.Controls.Add(this.nud_SystemX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_CustomEntityType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_FactionID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.Name = "CustomEntities";
            this.Text = "CustomEntities";
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_FactionID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_CustomEntityType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.NumericUpDown nud_SystemY;
        private System.Windows.Forms.NumericUpDown nud_SystemX;
        private System.Windows.Forms.Button btn_DeleteEntity;
        private System.Windows.Forms.Button btn_AddEntity;
        private System.Windows.Forms.ComboBox ComboBox_Stars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Label label15;
    }
}