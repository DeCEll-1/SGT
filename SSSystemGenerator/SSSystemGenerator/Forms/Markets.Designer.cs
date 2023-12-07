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
            this.btn_AddAddable = new System.Windows.Forms.Button();
            this.ComboBox_Addables = new System.Windows.Forms.ComboBox();
            this.ComboBox_PrimaryEntity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Market = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tb_Selectables = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PrimaryEntityReset = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.lbl_DoesItHaveMarket = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CSVRefresh = new System.Windows.Forms.Button();
            this.cb_MarketWithJunkAndChatter = new System.Windows.Forms.CheckBox();
            this.cb_MarketPirateMode = new System.Windows.Forms.CheckBox();
            this.nud_MarketSize = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_MarketFactionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddAddable
            // 
            this.btn_AddAddable.Enabled = false;
            this.btn_AddAddable.Location = new System.Drawing.Point(14, 72);
            this.btn_AddAddable.Name = "btn_AddAddable";
            this.btn_AddAddable.Size = new System.Drawing.Size(203, 23);
            this.btn_AddAddable.TabIndex = 4;
            this.btn_AddAddable.Text = "Add To Market";
            this.btn_AddAddable.UseVisualStyleBackColor = true;
            this.btn_AddAddable.Click += new System.EventHandler(this.btn_AddAddable_Click);
            // 
            // ComboBox_Addables
            // 
            this.ComboBox_Addables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Addables.FormattingEnabled = true;
            this.ComboBox_Addables.Location = new System.Drawing.Point(14, 45);
            this.ComboBox_Addables.Name = "ComboBox_Addables";
            this.ComboBox_Addables.Size = new System.Drawing.Size(175, 21);
            this.ComboBox_Addables.TabIndex = 2;
            this.ComboBox_Addables.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Addables_SelectedIndexChanged);
            // 
            // ComboBox_PrimaryEntity
            // 
            this.ComboBox_PrimaryEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PrimaryEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_PrimaryEntity.FormattingEnabled = true;
            this.ComboBox_PrimaryEntity.Location = new System.Drawing.Point(16, 72);
            this.ComboBox_PrimaryEntity.Name = "ComboBox_PrimaryEntity";
            this.ComboBox_PrimaryEntity.Size = new System.Drawing.Size(175, 21);
            this.ComboBox_PrimaryEntity.TabIndex = 2;
            this.ComboBox_PrimaryEntity.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PrimaryEntity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Select Object To Add/Edit Market:";
            // 
            // btn_Market
            // 
            this.btn_Market.Enabled = false;
            this.btn_Market.Location = new System.Drawing.Point(12, 414);
            this.btn_Market.Name = "btn_Market";
            this.btn_Market.Size = new System.Drawing.Size(232, 23);
            this.btn_Market.TabIndex = 9;
            this.btn_Market.Text = "Add Market";
            this.btn_Market.UseVisualStyleBackColor = true;
            this.btn_Market.Click += new System.EventHandler(this.btn_AddMarket_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(12, 443);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(189, 35);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete Market";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Select System:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(16, 32);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(175, 21);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(14, 19);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(20, 20);
            this.btn_Prev.TabIndex = 0;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(197, 19);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(20, 20);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tb_Selectables
            // 
            this.tb_Selectables.Enabled = false;
            this.tb_Selectables.Location = new System.Drawing.Point(40, 19);
            this.tb_Selectables.Name = "tb_Selectables";
            this.tb_Selectables.Size = new System.Drawing.Size(151, 20);
            this.tb_Selectables.TabIndex = 93;
            this.tb_Selectables.Text = "Industry";
            this.tb_Selectables.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PrimaryEntityReset);
            this.groupBox1.Controls.Add(this.btn_SystemsRefresh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_DoesItHaveMarket);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBox_PrimaryEntity);
            this.groupBox1.Controls.Add(this.ComboBox_Systems);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // btn_PrimaryEntityReset
            // 
            this.btn_PrimaryEntityReset.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_PrimaryEntityReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrimaryEntityReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_PrimaryEntityReset.Location = new System.Drawing.Point(197, 72);
            this.btn_PrimaryEntityReset.Name = "btn_PrimaryEntityReset";
            this.btn_PrimaryEntityReset.Size = new System.Drawing.Size(22, 22);
            this.btn_PrimaryEntityReset.TabIndex = 3;
            this.btn_PrimaryEntityReset.UseVisualStyleBackColor = true;
            this.btn_PrimaryEntityReset.Click += new System.EventHandler(this.btn_PrimaryEntityReset_Click);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(197, 32);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 22);
            this.btn_SystemsRefresh.TabIndex = 1;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // lbl_DoesItHaveMarket
            // 
            this.lbl_DoesItHaveMarket.AutoSize = true;
            this.lbl_DoesItHaveMarket.Location = new System.Drawing.Point(13, 96);
            this.lbl_DoesItHaveMarket.Name = "lbl_DoesItHaveMarket";
            this.lbl_DoesItHaveMarket.Size = new System.Drawing.Size(24, 13);
            this.lbl_DoesItHaveMarket.TabIndex = 63;
            this.lbl_DoesItHaveMarket.Text = "info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Prev);
            this.groupBox3.Controls.Add(this.btn_AddAddable);
            this.groupBox3.Controls.Add(this.ComboBox_Addables);
            this.groupBox3.Controls.Add(this.tb_Selectables);
            this.groupBox3.Controls.Add(this.btn_CSVRefresh);
            this.groupBox3.Controls.Add(this.btn_Next);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btn_CSVRefresh
            // 
            this.btn_CSVRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_CSVRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CSVRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_CSVRefresh.Location = new System.Drawing.Point(195, 44);
            this.btn_CSVRefresh.Name = "btn_CSVRefresh";
            this.btn_CSVRefresh.Size = new System.Drawing.Size(22, 22);
            this.btn_CSVRefresh.TabIndex = 3;
            this.btn_CSVRefresh.UseVisualStyleBackColor = true;
            this.btn_CSVRefresh.Click += new System.EventHandler(this.btn_CSVRefresh_Click);
            // 
            // cb_MarketWithJunkAndChatter
            // 
            this.cb_MarketWithJunkAndChatter.AutoSize = true;
            this.cb_MarketWithJunkAndChatter.Location = new System.Drawing.Point(15, 329);
            this.cb_MarketWithJunkAndChatter.Name = "cb_MarketWithJunkAndChatter";
            this.cb_MarketWithJunkAndChatter.Size = new System.Drawing.Size(133, 17);
            this.cb_MarketWithJunkAndChatter.TabIndex = 5;
            this.cb_MarketWithJunkAndChatter.Text = "With Junk And Chatter";
            this.cb_MarketWithJunkAndChatter.UseVisualStyleBackColor = true;
            // 
            // cb_MarketPirateMode
            // 
            this.cb_MarketPirateMode.AutoSize = true;
            this.cb_MarketPirateMode.Location = new System.Drawing.Point(15, 352);
            this.cb_MarketPirateMode.Name = "cb_MarketPirateMode";
            this.cb_MarketPirateMode.Size = new System.Drawing.Size(83, 17);
            this.cb_MarketPirateMode.TabIndex = 6;
            this.cb_MarketPirateMode.Text = "Pirate Mode";
            this.cb_MarketPirateMode.UseVisualStyleBackColor = true;
            // 
            // nud_MarketSize
            // 
            this.nud_MarketSize.Location = new System.Drawing.Point(189, 328);
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
            this.nud_MarketSize.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(156, 330);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 97;
            this.label22.Text = "Size:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 372);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 99;
            this.label23.Text = "Faction ID:";
            // 
            // tb_MarketFactionID
            // 
            this.tb_MarketFactionID.Location = new System.Drawing.Point(15, 388);
            this.tb_MarketFactionID.Name = "tb_MarketFactionID";
            this.tb_MarketFactionID.Size = new System.Drawing.Size(229, 20);
            this.tb_MarketFactionID.TabIndex = 8;
            this.tb_MarketFactionID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Name Of The Market:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(15, 191);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(229, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(207, 443);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(37, 35);
            this.btn_Undo.TabIndex = 11;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(15, 152);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(229, 20);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Market ID:";
            // 
            // Markets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cb_MarketWithJunkAndChatter);
            this.Controls.Add(this.cb_MarketPirateMode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nud_MarketSize);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.tb_MarketFactionID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Market);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Markets";
            this.Text = "Markets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddAddable;
        private System.Windows.Forms.ComboBox ComboBox_Addables;
        private System.Windows.Forms.ComboBox ComboBox_PrimaryEntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Market;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Button btn_CSVRefresh;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox tb_Selectables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_MarketWithJunkAndChatter;
        private System.Windows.Forms.CheckBox cb_MarketPirateMode;
        private System.Windows.Forms.NumericUpDown nud_MarketSize;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_MarketFactionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.Button btn_PrimaryEntityReset;
        private System.Windows.Forms.Label lbl_DoesItHaveMarket;
    }
}