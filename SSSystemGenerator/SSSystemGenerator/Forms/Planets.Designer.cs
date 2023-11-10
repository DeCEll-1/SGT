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
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bud_Radius = new System.Windows.Forms.NumericUpDown();
            this.tb_TypeID = new System.Windows.Forms.TextBox();
            this.ComboBox_Planets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_System = new System.Windows.Forms.ComboBox();
            this.btn_Planet = new System.Windows.Forms.Button();
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nud_Angle = new System.Windows.Forms.NumericUpDown();
            this.nud_SystemY = new System.Windows.Forms.NumericUpDown();
            this.nud_SystemX = new System.Windows.Forms.NumericUpDown();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bud_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 103);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(181, 20);
            this.tb_Name.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Type ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 25);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(181, 20);
            this.tb_ID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Radius";
            // 
            // bud_Radius
            // 
            this.bud_Radius.Location = new System.Drawing.Point(11, 143);
            this.bud_Radius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.bud_Radius.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.bud_Radius.Name = "bud_Radius";
            this.bud_Radius.Size = new System.Drawing.Size(72, 20);
            this.bud_Radius.TabIndex = 31;
            // 
            // tb_TypeID
            // 
            this.tb_TypeID.Location = new System.Drawing.Point(12, 64);
            this.tb_TypeID.Name = "tb_TypeID";
            this.tb_TypeID.Size = new System.Drawing.Size(181, 20);
            this.tb_TypeID.TabIndex = 19;
            // 
            // ComboBox_Planets
            // 
            this.ComboBox_Planets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Planets.FormattingEnabled = true;
            this.ComboBox_Planets.Location = new System.Drawing.Point(12, 369);
            this.ComboBox_Planets.Name = "ComboBox_Planets";
            this.ComboBox_Planets.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_Planets.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Planet List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Parent System:";
            // 
            // ComboBox_System
            // 
            this.ComboBox_System.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_System.FormattingEnabled = true;
            this.ComboBox_System.Location = new System.Drawing.Point(12, 329);
            this.ComboBox_System.Name = "ComboBox_System";
            this.ComboBox_System.Size = new System.Drawing.Size(182, 21);
            this.ComboBox_System.TabIndex = 35;
            // 
            // btn_Planet
            // 
            this.btn_Planet.Location = new System.Drawing.Point(12, 396);
            this.btn_Planet.Name = "btn_Planet";
            this.btn_Planet.Size = new System.Drawing.Size(182, 30);
            this.btn_Planet.TabIndex = 36;
            this.btn_Planet.Text = "Add Planet";
            this.btn_Planet.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Focus:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Orbit Mode:";
            // 
            // tb_Info
            // 
            this.tb_Info.Enabled = false;
            this.tb_Info.Location = new System.Drawing.Point(200, 245);
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
            this.ComboBox_OrbitMode.Location = new System.Drawing.Point(200, 63);
            this.ComboBox_OrbitMode.Name = "ComboBox_OrbitMode";
            this.ComboBox_OrbitMode.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_OrbitMode.TabIndex = 56;
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(199, 24);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(177, 21);
            this.ComboBox_FocusID.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Orbit Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Min Spin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Max Spin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Orbit Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Angle";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Location = new System.Drawing.Point(201, 180);
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
            this.nud_MinSpin.Location = new System.Drawing.Point(201, 219);
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
            this.label8.Location = new System.Drawing.Point(199, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "X";
            // 
            // nud_MaxSpin
            // 
            this.nud_MaxSpin.Location = new System.Drawing.Point(311, 219);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(310, 141);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 41;
            // 
            // nud_Angle
            // 
            this.nud_Angle.Location = new System.Drawing.Point(202, 141);
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
            this.nud_SystemY.Location = new System.Drawing.Point(310, 103);
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
            this.nud_SystemX.Location = new System.Drawing.Point(202, 102);
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
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(12, 432);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(178, 36);
            this.btn_Delete.TabIndex = 60;
            this.btn_Delete.Text = "Delete Planet";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 476);
            this.Controls.Add(this.btn_Delete);
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
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nud_Angle);
            this.Controls.Add(this.nud_SystemY);
            this.Controls.Add(this.nud_SystemX);
            this.Controls.Add(this.btn_Planet);
            this.Controls.Add(this.ComboBox_System);
            this.Controls.Add(this.ComboBox_Planets);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bud_Radius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_TypeID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.Name = "Planets";
            this.Text = "Planets";
            ((System.ComponentModel.ISupportInitialize)(this.bud_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown bud_Radius;
        private System.Windows.Forms.TextBox tb_TypeID;
        private System.Windows.Forms.ComboBox ComboBox_Planets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_System;
        private System.Windows.Forms.Button btn_Planet;
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nud_Angle;
        private System.Windows.Forms.NumericUpDown nud_SystemY;
        private System.Windows.Forms.NumericUpDown nud_SystemX;
        private System.Windows.Forms.Button btn_Delete;
    }
}