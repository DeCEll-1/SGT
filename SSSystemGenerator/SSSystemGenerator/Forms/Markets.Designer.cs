namespace SSSystemGenerator.Forms
{
    partial class Markets
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
            this.label40 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_MarketFactionID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.nud_MarketSize = new System.Windows.Forms.NumericUpDown();
            this.cb_MarketWithJunkAndChatter = new System.Windows.Forms.CheckBox();
            this.cb_MarketPirateMode = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ComboBox_TerrainID = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_WhatListIsThis = new System.Windows.Forms.Label();
            this.ComboBox_Addables = new System.Windows.Forms.ComboBox();
            this.ComboBox_PlanetSelected = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_AddablesList = new System.Windows.Forms.ComboBox();
            this.btn_AddMarket = new System.Windows.Forms.Button();
            this.btn_DeleteMarket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 88);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 13);
            this.label40.TabIndex = 63;
            this.label40.Text = "Terrain ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 277);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Faction ID:";
            // 
            // tb_MarketFactionID
            // 
            this.tb_MarketFactionID.Location = new System.Drawing.Point(12, 293);
            this.tb_MarketFactionID.Name = "tb_MarketFactionID";
            this.tb_MarketFactionID.Size = new System.Drawing.Size(203, 20);
            this.tb_MarketFactionID.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(115, 251);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 58;
            this.label22.Text = "Size:";
            // 
            // nud_MarketSize
            // 
            this.nud_MarketSize.Location = new System.Drawing.Point(148, 249);
            this.nud_MarketSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MarketSize.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_MarketSize.Name = "nud_MarketSize";
            this.nud_MarketSize.Size = new System.Drawing.Size(28, 20);
            this.nud_MarketSize.TabIndex = 57;
            // 
            // cb_MarketWithJunkAndChatter
            // 
            this.cb_MarketWithJunkAndChatter.AutoSize = true;
            this.cb_MarketWithJunkAndChatter.Location = new System.Drawing.Point(12, 227);
            this.cb_MarketWithJunkAndChatter.Name = "cb_MarketWithJunkAndChatter";
            this.cb_MarketWithJunkAndChatter.Size = new System.Drawing.Size(133, 17);
            this.cb_MarketWithJunkAndChatter.TabIndex = 56;
            this.cb_MarketWithJunkAndChatter.Text = "With Junk And Chatter";
            this.cb_MarketWithJunkAndChatter.UseVisualStyleBackColor = true;
            // 
            // cb_MarketPirateMode
            // 
            this.cb_MarketPirateMode.AutoSize = true;
            this.cb_MarketPirateMode.Location = new System.Drawing.Point(12, 250);
            this.cb_MarketPirateMode.Name = "cb_MarketPirateMode";
            this.cb_MarketPirateMode.Size = new System.Drawing.Size(83, 17);
            this.cb_MarketPirateMode.TabIndex = 55;
            this.cb_MarketPirateMode.Text = "Pirate Mode";
            this.cb_MarketPirateMode.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 198);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(203, 23);
            this.btn_Add.TabIndex = 50;
            this.btn_Add.Text = "Add To Market";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // ComboBox_TerrainID
            // 
            this.ComboBox_TerrainID.FormattingEnabled = true;
            this.ComboBox_TerrainID.Location = new System.Drawing.Point(12, 104);
            this.ComboBox_TerrainID.Name = "ComboBox_TerrainID";
            this.ComboBox_TerrainID.Size = new System.Drawing.Size(203, 21);
            this.ComboBox_TerrainID.TabIndex = 49;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 65);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(203, 20);
            this.tb_Name.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Name Of The Market:";
            // 
            // lbl_WhatListIsThis
            // 
            this.lbl_WhatListIsThis.AutoSize = true;
            this.lbl_WhatListIsThis.Location = new System.Drawing.Point(9, 128);
            this.lbl_WhatListIsThis.Name = "lbl_WhatListIsThis";
            this.lbl_WhatListIsThis.Size = new System.Drawing.Size(40, 13);
            this.lbl_WhatListIsThis.TabIndex = 63;
            this.lbl_WhatListIsThis.Text = "List Of:";
            // 
            // ComboBox_Addables
            // 
            this.ComboBox_Addables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Addables.FormattingEnabled = true;
            this.ComboBox_Addables.Location = new System.Drawing.Point(12, 171);
            this.ComboBox_Addables.Name = "ComboBox_Addables";
            this.ComboBox_Addables.Size = new System.Drawing.Size(203, 21);
            this.ComboBox_Addables.TabIndex = 64;
            // 
            // ComboBox_PlanetSelected
            // 
            this.ComboBox_PlanetSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PlanetSelected.FormattingEnabled = true;
            this.ComboBox_PlanetSelected.Location = new System.Drawing.Point(12, 25);
            this.ComboBox_PlanetSelected.Name = "ComboBox_PlanetSelected";
            this.ComboBox_PlanetSelected.Size = new System.Drawing.Size(203, 21);
            this.ComboBox_PlanetSelected.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Select Planet For Editing / Adding Market:";
            // 
            // ComboBox_AddablesList
            // 
            this.ComboBox_AddablesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AddablesList.FormattingEnabled = true;
            this.ComboBox_AddablesList.Location = new System.Drawing.Point(12, 144);
            this.ComboBox_AddablesList.Name = "ComboBox_AddablesList";
            this.ComboBox_AddablesList.Size = new System.Drawing.Size(203, 21);
            this.ComboBox_AddablesList.TabIndex = 64;
            // 
            // btn_AddMarket
            // 
            this.btn_AddMarket.Location = new System.Drawing.Point(12, 319);
            this.btn_AddMarket.Name = "btn_AddMarket";
            this.btn_AddMarket.Size = new System.Drawing.Size(202, 23);
            this.btn_AddMarket.TabIndex = 50;
            this.btn_AddMarket.Text = "Add The Market To The Planet";
            this.btn_AddMarket.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteMarket
            // 
            this.btn_DeleteMarket.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DeleteMarket.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteMarket.Location = new System.Drawing.Point(12, 348);
            this.btn_DeleteMarket.Name = "btn_DeleteMarket";
            this.btn_DeleteMarket.Size = new System.Drawing.Size(203, 36);
            this.btn_DeleteMarket.TabIndex = 65;
            this.btn_DeleteMarket.Text = "Delete Market";
            this.btn_DeleteMarket.UseVisualStyleBackColor = false;
            // 
            // Markets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 395);
            this.Controls.Add(this.btn_DeleteMarket);
            this.Controls.Add(this.ComboBox_PlanetSelected);
            this.Controls.Add(this.ComboBox_AddablesList);
            this.Controls.Add(this.ComboBox_Addables);
            this.Controls.Add(this.lbl_WhatListIsThis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_MarketFactionID);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.nud_MarketSize);
            this.Controls.Add(this.cb_MarketWithJunkAndChatter);
            this.Controls.Add(this.cb_MarketPirateMode);
            this.Controls.Add(this.btn_AddMarket);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ComboBox_TerrainID);
            this.Name = "Markets";
            this.Text = "Markets";
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_MarketFactionID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nud_MarketSize;
        private System.Windows.Forms.CheckBox cb_MarketWithJunkAndChatter;
        private System.Windows.Forms.CheckBox cb_MarketPirateMode;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox ComboBox_TerrainID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_WhatListIsThis;
        private System.Windows.Forms.ComboBox ComboBox_Addables;
        private System.Windows.Forms.ComboBox ComboBox_PlanetSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_AddablesList;
        private System.Windows.Forms.Button btn_AddMarket;
        private System.Windows.Forms.Button btn_DeleteMarket;
    }
}