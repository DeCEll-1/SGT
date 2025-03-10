﻿namespace SSSystemGenerator.Forms
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
            this.components = new System.ComponentModel.Container();
            this.ComboBox_PrimaryEntity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Market = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PrimaryEntityReset = new System.Windows.Forms.Button();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.lbl_DoesItHaveMarket = new System.Windows.Forms.Label();
            this.cb_MarketWithJunkAndChatter = new System.Windows.Forms.CheckBox();
            this.cb_MarketPirateMode = new System.Windows.Forms.CheckBox();
            this.nud_MarketSize = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_MarketFactionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.il_IndustryImages = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_IndustriesFilter = new System.Windows.Forms.TextBox();
            this.olv_Industries = new BrightIdeasSoftware.ObjectListView();
            this.olv_Industries_Enabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Industries_Owner = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Industries_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Industries_Image = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.il_Icons = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_ConditionsFilter = new System.Windows.Forms.TextBox();
            this.olv_Conditions = new BrightIdeasSoftware.ObjectListView();
            this.olv_Conditions_Enabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Conditions_Owner = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Conditions_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Conditions_Image = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.il_ConditionImages = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_SubmarketsFilter = new System.Windows.Forms.TextBox();
            this.olv_Submarkets = new BrightIdeasSoftware.ObjectListView();
            this.olv_Submarkets_Enabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Submarkets_Owner = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Submarkets_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_Submarkets_Image = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.il_SubmarketImages = new System.Windows.Forms.ImageList(this.components);
            this.btn_Undo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Industries)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Conditions)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Submarkets)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_PrimaryEntity
            // 
            this.ComboBox_PrimaryEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PrimaryEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_PrimaryEntity.FormattingEnabled = true;
            this.ComboBox_PrimaryEntity.Location = new System.Drawing.Point(21, 89);
            this.ComboBox_PrimaryEntity.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_PrimaryEntity.Name = "ComboBox_PrimaryEntity";
            this.ComboBox_PrimaryEntity.Size = new System.Drawing.Size(232, 24);
            this.ComboBox_PrimaryEntity.TabIndex = 2;
            this.ComboBox_PrimaryEntity.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PrimaryEntity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Select Object To Add/Edit Market:";
            // 
            // btn_Market
            // 
            this.btn_Market.Enabled = false;
            this.btn_Market.Location = new System.Drawing.Point(16, 370);
            this.btn_Market.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Market.Name = "btn_Market";
            this.btn_Market.Size = new System.Drawing.Size(309, 28);
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
            this.btn_Delete.Location = new System.Drawing.Point(16, 405);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(252, 43);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete Market";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Select System:";
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(21, 39);
            this.ComboBox_Systems.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(232, 24);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(309, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // btn_PrimaryEntityReset
            // 
            this.btn_PrimaryEntityReset.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_PrimaryEntityReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PrimaryEntityReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_PrimaryEntityReset.Location = new System.Drawing.Point(263, 89);
            this.btn_PrimaryEntityReset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PrimaryEntityReset.Name = "btn_PrimaryEntityReset";
            this.btn_PrimaryEntityReset.Size = new System.Drawing.Size(29, 27);
            this.btn_PrimaryEntityReset.TabIndex = 3;
            this.btn_PrimaryEntityReset.UseVisualStyleBackColor = true;
            this.btn_PrimaryEntityReset.Click += new System.EventHandler(this.btn_PrimaryEntityReset_Click);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(263, 39);
            this.btn_SystemsRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(29, 27);
            this.btn_SystemsRefresh.TabIndex = 1;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // lbl_DoesItHaveMarket
            // 
            this.lbl_DoesItHaveMarket.AutoSize = true;
            this.lbl_DoesItHaveMarket.Location = new System.Drawing.Point(17, 118);
            this.lbl_DoesItHaveMarket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DoesItHaveMarket.Name = "lbl_DoesItHaveMarket";
            this.lbl_DoesItHaveMarket.Size = new System.Drawing.Size(28, 16);
            this.lbl_DoesItHaveMarket.TabIndex = 63;
            this.lbl_DoesItHaveMarket.Text = "info";
            // 
            // cb_MarketWithJunkAndChatter
            // 
            this.cb_MarketWithJunkAndChatter.AutoSize = true;
            this.cb_MarketWithJunkAndChatter.Location = new System.Drawing.Point(20, 265);
            this.cb_MarketWithJunkAndChatter.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MarketWithJunkAndChatter.Name = "cb_MarketWithJunkAndChatter";
            this.cb_MarketWithJunkAndChatter.Size = new System.Drawing.Size(158, 20);
            this.cb_MarketWithJunkAndChatter.TabIndex = 5;
            this.cb_MarketWithJunkAndChatter.Text = "With Junk And Chatter";
            this.cb_MarketWithJunkAndChatter.UseVisualStyleBackColor = true;
            // 
            // cb_MarketPirateMode
            // 
            this.cb_MarketPirateMode.AutoSize = true;
            this.cb_MarketPirateMode.Location = new System.Drawing.Point(20, 293);
            this.cb_MarketPirateMode.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MarketPirateMode.Name = "cb_MarketPirateMode";
            this.cb_MarketPirateMode.Size = new System.Drawing.Size(102, 20);
            this.cb_MarketPirateMode.TabIndex = 6;
            this.cb_MarketPirateMode.Text = "Pirate Mode";
            this.cb_MarketPirateMode.UseVisualStyleBackColor = true;
            // 
            // nud_MarketSize
            // 
            this.nud_MarketSize.Location = new System.Drawing.Point(252, 264);
            this.nud_MarketSize.Margin = new System.Windows.Forms.Padding(4);
            this.nud_MarketSize.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_MarketSize.Name = "nud_MarketSize";
            this.nud_MarketSize.Size = new System.Drawing.Size(37, 22);
            this.nud_MarketSize.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(208, 266);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 97;
            this.label22.Text = "Size:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 318);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 99;
            this.label23.Text = "Faction ID:";
            // 
            // tb_MarketFactionID
            // 
            this.tb_MarketFactionID.Location = new System.Drawing.Point(20, 338);
            this.tb_MarketFactionID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MarketFactionID.Name = "tb_MarketFactionID";
            this.tb_MarketFactionID.Size = new System.Drawing.Size(304, 22);
            this.tb_MarketFactionID.TabIndex = 8;
            this.tb_MarketFactionID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 102;
            this.label1.Text = "Name Of The Market:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(20, 235);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(304, 22);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(20, 187);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(304, 22);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Market ID:";
            // 
            // il_IndustryImages
            // 
            this.il_IndustryImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_IndustryImages.ImageSize = new System.Drawing.Size(128, 64);
            this.il_IndustryImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(332, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 470);
            this.tabControl1.TabIndex = 104;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_IndustriesFilter);
            this.tabPage1.Controls.Add(this.olv_Industries);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Industries";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_IndustriesFilter
            // 
            this.tb_IndustriesFilter.Location = new System.Drawing.Point(3, 3);
            this.tb_IndustriesFilter.Name = "tb_IndustriesFilter";
            this.tb_IndustriesFilter.Size = new System.Drawing.Size(563, 22);
            this.tb_IndustriesFilter.TabIndex = 105;
            // 
            // olv_Industries
            // 
            this.olv_Industries.AllColumns.Add(this.olv_Industries_Enabled);
            this.olv_Industries.AllColumns.Add(this.olv_Industries_Owner);
            this.olv_Industries.AllColumns.Add(this.olv_Industries_Name);
            this.olv_Industries.AllColumns.Add(this.olv_Industries_Image);
            this.olv_Industries.CellEditUseWholeCell = false;
            this.olv_Industries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olv_Industries_Enabled,
            this.olv_Industries_Owner,
            this.olv_Industries_Name,
            this.olv_Industries_Image});
            this.olv_Industries.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_Industries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olv_Industries.GroupImageList = this.il_Icons;
            this.olv_Industries.HideSelection = false;
            this.olv_Industries.Location = new System.Drawing.Point(3, 29);
            this.olv_Industries.MultiSelect = false;
            this.olv_Industries.Name = "olv_Industries";
            this.olv_Industries.Size = new System.Drawing.Size(563, 409);
            this.olv_Industries.SmallImageList = this.il_IndustryImages;
            this.olv_Industries.TabIndex = 104;
            this.olv_Industries.UseCompatibleStateImageBehavior = false;
            this.olv_Industries.UseFiltering = true;
            this.olv_Industries.View = System.Windows.Forms.View.Details;
            // 
            // olv_Industries_Enabled
            // 
            this.olv_Industries_Enabled.AspectName = "enabled";
            this.olv_Industries_Enabled.CheckBoxes = true;
            this.olv_Industries_Enabled.Searchable = false;
            this.olv_Industries_Enabled.Text = "Enabled";
            // 
            // olv_Industries_Owner
            // 
            this.olv_Industries_Owner.AspectName = "owner";
            this.olv_Industries_Owner.Text = "Owner";
            this.olv_Industries_Owner.Width = 128;
            // 
            // olv_Industries_Name
            // 
            this.olv_Industries_Name.AspectName = "name";
            this.olv_Industries_Name.Groupable = false;
            this.olv_Industries_Name.Sortable = false;
            this.olv_Industries_Name.Text = "Name";
            this.olv_Industries_Name.Width = 128;
            this.olv_Industries_Name.WordWrap = true;
            // 
            // olv_Industries_Image
            // 
            this.olv_Industries_Image.Groupable = false;
            this.olv_Industries_Image.IsEditable = false;
            this.olv_Industries_Image.Searchable = false;
            this.olv_Industries_Image.Sortable = false;
            this.olv_Industries_Image.Text = "Image";
            this.olv_Industries_Image.Width = 128;
            // 
            // il_Icons
            // 
            this.il_Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_Icons.ImageSize = new System.Drawing.Size(40, 40);
            this.il_Icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_ConditionsFilter);
            this.tabPage2.Controls.Add(this.olv_Conditions);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conditions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_ConditionsFilter
            // 
            this.tb_ConditionsFilter.Location = new System.Drawing.Point(3, 3);
            this.tb_ConditionsFilter.Name = "tb_ConditionsFilter";
            this.tb_ConditionsFilter.Size = new System.Drawing.Size(563, 22);
            this.tb_ConditionsFilter.TabIndex = 107;
            // 
            // olv_Conditions
            // 
            this.olv_Conditions.AllColumns.Add(this.olv_Conditions_Enabled);
            this.olv_Conditions.AllColumns.Add(this.olv_Conditions_Owner);
            this.olv_Conditions.AllColumns.Add(this.olv_Conditions_Name);
            this.olv_Conditions.AllColumns.Add(this.olv_Conditions_Image);
            this.olv_Conditions.CellEditUseWholeCell = false;
            this.olv_Conditions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olv_Conditions_Enabled,
            this.olv_Conditions_Owner,
            this.olv_Conditions_Name,
            this.olv_Conditions_Image});
            this.olv_Conditions.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_Conditions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olv_Conditions.GroupImageList = this.il_Icons;
            this.olv_Conditions.HideSelection = false;
            this.olv_Conditions.Location = new System.Drawing.Point(3, 29);
            this.olv_Conditions.MultiSelect = false;
            this.olv_Conditions.Name = "olv_Conditions";
            this.olv_Conditions.Size = new System.Drawing.Size(563, 409);
            this.olv_Conditions.SmallImageList = this.il_ConditionImages;
            this.olv_Conditions.TabIndex = 106;
            this.olv_Conditions.UseCompatibleStateImageBehavior = false;
            this.olv_Conditions.UseFiltering = true;
            this.olv_Conditions.View = System.Windows.Forms.View.Details;
            // 
            // olv_Conditions_Enabled
            // 
            this.olv_Conditions_Enabled.AspectName = "enabled";
            this.olv_Conditions_Enabled.CheckBoxes = true;
            this.olv_Conditions_Enabled.Searchable = false;
            this.olv_Conditions_Enabled.Text = "Enabled";
            // 
            // olv_Conditions_Owner
            // 
            this.olv_Conditions_Owner.AspectName = "owner";
            this.olv_Conditions_Owner.Text = "Owner";
            this.olv_Conditions_Owner.Width = 128;
            // 
            // olv_Conditions_Name
            // 
            this.olv_Conditions_Name.AspectName = "name";
            this.olv_Conditions_Name.Groupable = false;
            this.olv_Conditions_Name.Sortable = false;
            this.olv_Conditions_Name.Text = "Name";
            this.olv_Conditions_Name.Width = 128;
            this.olv_Conditions_Name.WordWrap = true;
            // 
            // olv_Conditions_Image
            // 
            this.olv_Conditions_Image.Groupable = false;
            this.olv_Conditions_Image.IsEditable = false;
            this.olv_Conditions_Image.Searchable = false;
            this.olv_Conditions_Image.Sortable = false;
            this.olv_Conditions_Image.Text = "Image";
            this.olv_Conditions_Image.Width = 128;
            // 
            // il_ConditionImages
            // 
            this.il_ConditionImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_ConditionImages.ImageSize = new System.Drawing.Size(64, 64);
            this.il_ConditionImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_SubmarketsFilter);
            this.tabPage3.Controls.Add(this.olv_Submarkets);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(569, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Submarkets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_SubmarketsFilter
            // 
            this.tb_SubmarketsFilter.Location = new System.Drawing.Point(3, 3);
            this.tb_SubmarketsFilter.Name = "tb_SubmarketsFilter";
            this.tb_SubmarketsFilter.Size = new System.Drawing.Size(563, 22);
            this.tb_SubmarketsFilter.TabIndex = 107;
            // 
            // olv_Submarkets
            // 
            this.olv_Submarkets.AllColumns.Add(this.olv_Submarkets_Enabled);
            this.olv_Submarkets.AllColumns.Add(this.olv_Submarkets_Owner);
            this.olv_Submarkets.AllColumns.Add(this.olv_Submarkets_Name);
            this.olv_Submarkets.AllColumns.Add(this.olv_Submarkets_Image);
            this.olv_Submarkets.CellEditUseWholeCell = false;
            this.olv_Submarkets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olv_Submarkets_Enabled,
            this.olv_Submarkets_Owner,
            this.olv_Submarkets_Name,
            this.olv_Submarkets_Image});
            this.olv_Submarkets.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_Submarkets.GroupImageList = this.il_Icons;
            this.olv_Submarkets.HideSelection = false;
            this.olv_Submarkets.Location = new System.Drawing.Point(3, 29);
            this.olv_Submarkets.MultiSelect = false;
            this.olv_Submarkets.Name = "olv_Submarkets";
            this.olv_Submarkets.Size = new System.Drawing.Size(563, 409);
            this.olv_Submarkets.SmallImageList = this.il_SubmarketImages;
            this.olv_Submarkets.TabIndex = 106;
            this.olv_Submarkets.UseCompatibleStateImageBehavior = false;
            this.olv_Submarkets.UseFiltering = true;
            this.olv_Submarkets.View = System.Windows.Forms.View.Details;
            // 
            // olv_Submarkets_Enabled
            // 
            this.olv_Submarkets_Enabled.AspectName = "enabled";
            this.olv_Submarkets_Enabled.CheckBoxes = true;
            this.olv_Submarkets_Enabled.Searchable = false;
            this.olv_Submarkets_Enabled.Text = "Enabled";
            // 
            // olv_Submarkets_Owner
            // 
            this.olv_Submarkets_Owner.AspectName = "owner";
            this.olv_Submarkets_Owner.Text = "Owner";
            this.olv_Submarkets_Owner.Width = 128;
            // 
            // olv_Submarkets_Name
            // 
            this.olv_Submarkets_Name.AspectName = "name";
            this.olv_Submarkets_Name.Groupable = false;
            this.olv_Submarkets_Name.Sortable = false;
            this.olv_Submarkets_Name.Text = "Name";
            this.olv_Submarkets_Name.Width = 128;
            this.olv_Submarkets_Name.WordWrap = true;
            // 
            // olv_Submarkets_Image
            // 
            this.olv_Submarkets_Image.Groupable = false;
            this.olv_Submarkets_Image.IsEditable = false;
            this.olv_Submarkets_Image.Searchable = false;
            this.olv_Submarkets_Image.Sortable = false;
            this.olv_Submarkets_Image.Text = "Image";
            this.olv_Submarkets_Image.Width = 128;
            // 
            // il_SubmarketImages
            // 
            this.il_SubmarketImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_SubmarketImages.ImageSize = new System.Drawing.Size(102, 64);
            this.il_SubmarketImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.UndoLightMode;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(276, 405);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(49, 43);
            this.btn_Undo.TabIndex = 11;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // Markets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cb_MarketWithJunkAndChatter);
            this.Controls.Add(this.cb_MarketPirateMode);
            this.Controls.Add(this.nud_MarketSize);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.tb_MarketFactionID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Market);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Markets";
            this.Text = "Markets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MarketSize)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Industries)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Conditions)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_Submarkets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBox_PrimaryEntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Market;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ImageList il_IndustryImages;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView olv_Industries;
        private BrightIdeasSoftware.OLVColumn olv_Industries_Name;
        private BrightIdeasSoftware.OLVColumn olv_Industries_Image;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.OLVColumn olv_Industries_Enabled;
        private BrightIdeasSoftware.OLVColumn olv_Industries_Owner;
        private System.Windows.Forms.TextBox tb_IndustriesFilter;
        private System.Windows.Forms.ImageList il_Icons;
        private System.Windows.Forms.TextBox tb_ConditionsFilter;
        private BrightIdeasSoftware.ObjectListView olv_Conditions;
        private BrightIdeasSoftware.OLVColumn olv_Conditions_Enabled;
        private BrightIdeasSoftware.OLVColumn olv_Conditions_Owner;
        private BrightIdeasSoftware.OLVColumn olv_Conditions_Name;
        private BrightIdeasSoftware.OLVColumn olv_Conditions_Image;
        private System.Windows.Forms.ImageList il_ConditionImages;
        private System.Windows.Forms.ImageList il_SubmarketImages;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_SubmarketsFilter;
        private BrightIdeasSoftware.ObjectListView olv_Submarkets;
        private BrightIdeasSoftware.OLVColumn olv_Submarkets_Enabled;
        private BrightIdeasSoftware.OLVColumn olv_Submarkets_Owner;
        private BrightIdeasSoftware.OLVColumn olv_Submarkets_Name;
        private BrightIdeasSoftware.OLVColumn olv_Submarkets_Image;
    }
}