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
            this.label14 = new System.Windows.Forms.Label();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_MaxOrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.nud_AstreoidAmount = new System.Windows.Forms.NumericUpDown();
            this.nud_MinOrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.ComboBox_TerrainID = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AstreoidBelt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxOrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AstreoidAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinOrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Focus:";
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(12, 63);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(170, 21);
            this.ComboBox_FocusID.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Max Orbit Days:";
            // 
            // nud_MaxOrbitDays
            // 
            this.nud_MaxOrbitDays.Location = new System.Drawing.Point(12, 103);
            this.nud_MaxOrbitDays.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MaxOrbitDays.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_MaxOrbitDays.Name = "nud_MaxOrbitDays";
            this.nud_MaxOrbitDays.Size = new System.Drawing.Size(82, 20);
            this.nud_MaxOrbitDays.TabIndex = 75;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 126);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 13);
            this.label33.TabIndex = 74;
            this.label33.Text = "Number Of Astreoids:";
            // 
            // nud_AstreoidAmount
            // 
            this.nud_AstreoidAmount.Location = new System.Drawing.Point(12, 142);
            this.nud_AstreoidAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_AstreoidAmount.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_AstreoidAmount.Name = "nud_AstreoidAmount";
            this.nud_AstreoidAmount.Size = new System.Drawing.Size(107, 20);
            this.nud_AstreoidAmount.TabIndex = 73;
            // 
            // nud_MinOrbitDays
            // 
            this.nud_MinOrbitDays.Location = new System.Drawing.Point(100, 103);
            this.nud_MinOrbitDays.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MinOrbitDays.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_MinOrbitDays.Name = "nud_MinOrbitDays";
            this.nud_MinOrbitDays.Size = new System.Drawing.Size(82, 20);
            this.nud_MinOrbitDays.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Min Orbit Days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Width:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 142);
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
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 25);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(170, 20);
            this.tb_ID.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Orbit Radius:";
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Location = new System.Drawing.Point(12, 181);
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
            this.nud_OrbitRadius.Size = new System.Drawing.Size(170, 20);
            this.nud_OrbitRadius.TabIndex = 83;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 260);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(170, 20);
            this.tb_Name.TabIndex = 87;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 204);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(164, 13);
            this.label40.TabIndex = 86;
            this.label40.Text = "Terrain ID (type for custom ones):";
            // 
            // ComboBox_TerrainID
            // 
            this.ComboBox_TerrainID.FormattingEnabled = true;
            this.ComboBox_TerrainID.Location = new System.Drawing.Point(12, 220);
            this.ComboBox_TerrainID.Name = "ComboBox_TerrainID";
            this.ComboBox_TerrainID.Size = new System.Drawing.Size(170, 21);
            this.ComboBox_TerrainID.TabIndex = 85;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(9, 322);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(173, 36);
            this.btn_Delete.TabIndex = 90;
            this.btn_Delete.Text = "Delete Ring Band";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_AstreoidBelt
            // 
            this.btn_AstreoidBelt.Location = new System.Drawing.Point(12, 286);
            this.btn_AstreoidBelt.Name = "btn_AstreoidBelt";
            this.btn_AstreoidBelt.Size = new System.Drawing.Size(170, 30);
            this.btn_AstreoidBelt.TabIndex = 89;
            this.btn_AstreoidBelt.Text = "Add Ring Band";
            this.btn_AstreoidBelt.UseVisualStyleBackColor = true;
            // 
            // AstreoidBelts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 366);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AstreoidBelt);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.ComboBox_TerrainID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_OrbitRadius);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ComboBox_FocusID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_MinOrbitDays);
            this.Controls.Add(this.nud_MaxOrbitDays);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.nud_AstreoidAmount);
            this.Name = "AstreoidBelts";
            this.Text = "AstreoidBelts";
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxOrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AstreoidAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinOrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboBox_FocusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_MaxOrbitDays;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nud_AstreoidAmount;
        private System.Windows.Forms.NumericUpDown nud_MinOrbitDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox ComboBox_TerrainID;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AstreoidBelt;
    }
}