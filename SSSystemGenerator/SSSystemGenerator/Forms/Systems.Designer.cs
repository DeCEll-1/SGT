namespace SSSystemGenerator.Forms
{
    partial class Systems
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_SystemY = new System.Windows.Forms.NumericUpDown();
            this.nud_SystemX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_StarBackgroundTexturePath = new System.Windows.Forms.TextBox();
            this.cb_generatePlanetConditions = new System.Windows.Forms.CheckBox();
            this.cb_autoGenerateFringeJumpPoint = new System.Windows.Forms.CheckBox();
            this.cb_autoGenerateEntrancesAtGasGiants = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_minHyperspaceRadius = new System.Windows.Forms.NumericUpDown();
            this.btn_AddUpdateSystem = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.ComboBox_SystemSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minHyperspaceRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "X";
            // 
            // nud_SystemY
            // 
            this.nud_SystemY.Location = new System.Drawing.Point(87, 144);
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
            this.nud_SystemY.TabIndex = 5;
            // 
            // nud_SystemX
            // 
            this.nud_SystemX.Location = new System.Drawing.Point(12, 143);
            this.nud_SystemX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_SystemX.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_SystemX.Name = "nud_SystemX";
            this.nud_SystemX.Size = new System.Drawing.Size(69, 20);
            this.nud_SystemX.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 65);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(223, 20);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Background texture path (relative to mod root)";
            // 
            // tb_StarBackgroundTexturePath
            // 
            this.tb_StarBackgroundTexturePath.Location = new System.Drawing.Point(12, 183);
            this.tb_StarBackgroundTexturePath.Name = "tb_StarBackgroundTexturePath";
            this.tb_StarBackgroundTexturePath.Size = new System.Drawing.Size(223, 20);
            this.tb_StarBackgroundTexturePath.TabIndex = 6;
            // 
            // cb_generatePlanetConditions
            // 
            this.cb_generatePlanetConditions.AutoSize = true;
            this.cb_generatePlanetConditions.Location = new System.Drawing.Point(12, 271);
            this.cb_generatePlanetConditions.Name = "cb_generatePlanetConditions";
            this.cb_generatePlanetConditions.Size = new System.Drawing.Size(147, 17);
            this.cb_generatePlanetConditions.TabIndex = 9;
            this.cb_generatePlanetConditions.Text = "generatePlanetConditions";
            this.cb_generatePlanetConditions.UseVisualStyleBackColor = true;
            // 
            // cb_autoGenerateFringeJumpPoint
            // 
            this.cb_autoGenerateFringeJumpPoint.AutoSize = true;
            this.cb_autoGenerateFringeJumpPoint.Location = new System.Drawing.Point(12, 294);
            this.cb_autoGenerateFringeJumpPoint.Name = "cb_autoGenerateFringeJumpPoint";
            this.cb_autoGenerateFringeJumpPoint.Size = new System.Drawing.Size(169, 17);
            this.cb_autoGenerateFringeJumpPoint.TabIndex = 10;
            this.cb_autoGenerateFringeJumpPoint.Text = "autoGenerateFringeJumpPoint";
            this.cb_autoGenerateFringeJumpPoint.UseVisualStyleBackColor = true;
            // 
            // cb_autoGenerateEntrancesAtGasGiants
            // 
            this.cb_autoGenerateEntrancesAtGasGiants.AutoSize = true;
            this.cb_autoGenerateEntrancesAtGasGiants.Location = new System.Drawing.Point(12, 248);
            this.cb_autoGenerateEntrancesAtGasGiants.Name = "cb_autoGenerateEntrancesAtGasGiants";
            this.cb_autoGenerateEntrancesAtGasGiants.Size = new System.Drawing.Size(198, 17);
            this.cb_autoGenerateEntrancesAtGasGiants.TabIndex = 8;
            this.cb_autoGenerateEntrancesAtGasGiants.Text = "autoGenerateEntrancesAtGasGiants";
            this.cb_autoGenerateEntrancesAtGasGiants.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "minHyperspaceRadius";
            // 
            // nud_minHyperspaceRadius
            // 
            this.nud_minHyperspaceRadius.Location = new System.Drawing.Point(12, 222);
            this.nud_minHyperspaceRadius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_minHyperspaceRadius.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_minHyperspaceRadius.Name = "nud_minHyperspaceRadius";
            this.nud_minHyperspaceRadius.Size = new System.Drawing.Size(141, 20);
            this.nud_minHyperspaceRadius.TabIndex = 7;
            // 
            // btn_AddUpdateSystem
            // 
            this.btn_AddUpdateSystem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddUpdateSystem.Enabled = false;
            this.btn_AddUpdateSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_AddUpdateSystem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddUpdateSystem.Location = new System.Drawing.Point(12, 317);
            this.btn_AddUpdateSystem.Name = "btn_AddUpdateSystem";
            this.btn_AddUpdateSystem.Size = new System.Drawing.Size(223, 36);
            this.btn_AddUpdateSystem.TabIndex = 11;
            this.btn_AddUpdateSystem.Text = "Add System";
            this.btn_AddUpdateSystem.UseVisualStyleBackColor = true;
            this.btn_AddUpdateSystem.Click += new System.EventHandler(this.btn_AddSystem_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(12, 359);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(180, 36);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Delete System";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(198, 359);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(37, 36);
            this.btn_Undo.TabIndex = 13;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // ComboBox_SystemSelection
            // 
            this.ComboBox_SystemSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SystemSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_SystemSelection.FormattingEnabled = true;
            this.ComboBox_SystemSelection.Location = new System.Drawing.Point(12, 25);
            this.ComboBox_SystemSelection.Name = "ComboBox_SystemSelection";
            this.ComboBox_SystemSelection.Size = new System.Drawing.Size(223, 21);
            this.ComboBox_SystemSelection.TabIndex = 1;
            this.ComboBox_SystemSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SystemSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selected System:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 104);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(223, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name (optional):";
            // 
            // Systems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 403);
            this.Controls.Add(this.ComboBox_SystemSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AddUpdateSystem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nud_minHyperspaceRadius);
            this.Controls.Add(this.cb_generatePlanetConditions);
            this.Controls.Add(this.cb_autoGenerateFringeJumpPoint);
            this.Controls.Add(this.cb_autoGenerateEntrancesAtGasGiants);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_StarBackgroundTexturePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nud_SystemY);
            this.Controls.Add(this.nud_SystemX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Systems";
            this.Text = "Systems";
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SystemX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minHyperspaceRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_SystemY;
        private System.Windows.Forms.NumericUpDown nud_SystemX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_StarBackgroundTexturePath;
        private System.Windows.Forms.CheckBox cb_generatePlanetConditions;
        private System.Windows.Forms.CheckBox cb_autoGenerateFringeJumpPoint;
        private System.Windows.Forms.CheckBox cb_autoGenerateEntrancesAtGasGiants;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_minHyperspaceRadius;
        private System.Windows.Forms.Button btn_AddUpdateSystem;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.ComboBox ComboBox_SystemSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
    }
}