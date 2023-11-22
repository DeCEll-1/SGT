namespace SSSystemGenerator.Forms
{
    partial class RingBands
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
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tb_TextureID = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tb_TextureCategory = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.nud_BandWidthInEngine = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.nud_BandWidthInTexture = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.ComboBox_TerrainID = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_RingBand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboBox_FocusID = new System.Windows.Forms.ComboBox();
            this.btn_SystemsRefresh = new System.Windows.Forms.Button();
            this.ComboBox_Systems = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nud_Alpha = new System.Windows.Forms.NumericUpDown();
            this.nud_Blue = new System.Windows.Forms.NumericUpDown();
            this.nud_Green = new System.Windows.Forms.NumericUpDown();
            this.nud_Red = new System.Windows.Forms.NumericUpDown();
            this.TrackBar_Alpha = new System.Windows.Forms.TrackBar();
            this.TrackBar_Blue = new System.Windows.Forms.TrackBar();
            this.TrackBar_Green = new System.Windows.Forms.TrackBar();
            this.TrackBar_Red = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_OrbitRadius = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_OrbitDays = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.nud_MiddleRadius = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.nud_BandIndex = new System.Windows.Forms.NumericUpDown();
            this.btn_FocusRefresh = new System.Windows.Forms.Button();
            this.ComboBox_RingBands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Undo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandWidthInEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandWidthInTexture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MiddleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackColor = System.Drawing.Color.Red;
            this.pnl_Color.Location = new System.Drawing.Point(6, 177);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(170, 31);
            this.pnl_Color.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "ID:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 169);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(167, 20);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 55);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 13);
            this.label37.TabIndex = 53;
            this.label37.Text = "Texture ID:";
            // 
            // tb_TextureID
            // 
            this.tb_TextureID.Location = new System.Drawing.Point(6, 71);
            this.tb_TextureID.Name = "tb_TextureID";
            this.tb_TextureID.Size = new System.Drawing.Size(167, 20);
            this.tb_TextureID.TabIndex = 1;
            this.tb_TextureID.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 13);
            this.label36.TabIndex = 54;
            this.label36.Text = "Texture Category:";
            // 
            // tb_TextureCategory
            // 
            this.tb_TextureCategory.Location = new System.Drawing.Point(6, 32);
            this.tb_TextureCategory.Name = "tb_TextureCategory";
            this.tb_TextureCategory.Size = new System.Drawing.Size(167, 20);
            this.tb_TextureCategory.TabIndex = 0;
            this.tb_TextureCategory.TextChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 135);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(111, 13);
            this.label35.TabIndex = 59;
            this.label35.Text = "Band Width In Engine";
            // 
            // nud_BandWidthInEngine
            // 
            this.nud_BandWidthInEngine.Location = new System.Drawing.Point(6, 151);
            this.nud_BandWidthInEngine.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_BandWidthInEngine.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_BandWidthInEngine.Name = "nud_BandWidthInEngine";
            this.nud_BandWidthInEngine.Size = new System.Drawing.Size(167, 20);
            this.nud_BandWidthInEngine.TabIndex = 3;
            this.nud_BandWidthInEngine.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInEngine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInEngine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInEngine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 96);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(114, 13);
            this.label31.TabIndex = 60;
            this.label31.Text = "Band Width In Texture";
            // 
            // nud_BandWidthInTexture
            // 
            this.nud_BandWidthInTexture.Location = new System.Drawing.Point(6, 112);
            this.nud_BandWidthInTexture.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_BandWidthInTexture.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_BandWidthInTexture.Name = "nud_BandWidthInTexture";
            this.nud_BandWidthInTexture.Size = new System.Drawing.Size(167, 20);
            this.nud_BandWidthInTexture.TabIndex = 2;
            this.nud_BandWidthInTexture.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInTexture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInTexture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_BandWidthInTexture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 192);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(164, 13);
            this.label40.TabIndex = 62;
            this.label40.Text = "Terrain ID (type for custom ones):";
            // 
            // ComboBox_TerrainID
            // 
            this.ComboBox_TerrainID.FormattingEnabled = true;
            this.ComboBox_TerrainID.Location = new System.Drawing.Point(12, 208);
            this.ComboBox_TerrainID.Name = "ComboBox_TerrainID";
            this.ComboBox_TerrainID.Size = new System.Drawing.Size(164, 21);
            this.ComboBox_TerrainID.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(12, 248);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(167, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // btn_RingBand
            // 
            this.btn_RingBand.Enabled = false;
            this.btn_RingBand.Location = new System.Drawing.Point(12, 352);
            this.btn_RingBand.Name = "btn_RingBand";
            this.btn_RingBand.Size = new System.Drawing.Size(167, 30);
            this.btn_RingBand.TabIndex = 10;
            this.btn_RingBand.Text = "Add Ring Band";
            this.btn_RingBand.UseVisualStyleBackColor = true;
            this.btn_RingBand.Click += new System.EventHandler(this.btn_RingBand_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBox_RingBands);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ComboBox_FocusID);
            this.groupBox1.Controls.Add(this.btn_FocusRefresh);
            this.groupBox1.Controls.Add(this.btn_SystemsRefresh);
            this.groupBox1.Controls.Add(this.ComboBox_Systems);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 95;
            this.label14.Text = "Focus:";
            // 
            // ComboBox_FocusID
            // 
            this.ComboBox_FocusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_FocusID.FormattingEnabled = true;
            this.ComboBox_FocusID.Location = new System.Drawing.Point(6, 71);
            this.ComboBox_FocusID.Name = "ComboBox_FocusID";
            this.ComboBox_FocusID.Size = new System.Drawing.Size(139, 21);
            this.ComboBox_FocusID.TabIndex = 2;
            this.ComboBox_FocusID.SelectedIndexChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // btn_SystemsRefresh
            // 
            this.btn_SystemsRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_SystemsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SystemsRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_SystemsRefresh.Location = new System.Drawing.Point(151, 32);
            this.btn_SystemsRefresh.Name = "btn_SystemsRefresh";
            this.btn_SystemsRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_SystemsRefresh.TabIndex = 1;
            this.btn_SystemsRefresh.UseVisualStyleBackColor = true;
            this.btn_SystemsRefresh.Click += new System.EventHandler(this.btn_SystemsRefresh_Click);
            // 
            // ComboBox_Systems
            // 
            this.ComboBox_Systems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Systems.FormattingEnabled = true;
            this.ComboBox_Systems.Location = new System.Drawing.Point(5, 32);
            this.ComboBox_Systems.Name = "ComboBox_Systems";
            this.ComboBox_Systems.Size = new System.Drawing.Size(140, 21);
            this.ComboBox_Systems.TabIndex = 0;
            this.ComboBox_Systems.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Systems_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Parent System:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(12, 388);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 35);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete Ring Band";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.tb_TextureCategory);
            this.groupBox2.Controls.Add(this.tb_TextureID);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.nud_BandWidthInTexture);
            this.groupBox2.Controls.Add(this.nud_BandWidthInEngine);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "textures";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_Alpha);
            this.groupBox3.Controls.Add(this.nud_Blue);
            this.groupBox3.Controls.Add(this.nud_Green);
            this.groupBox3.Controls.Add(this.nud_Red);
            this.groupBox3.Controls.Add(this.TrackBar_Alpha);
            this.groupBox3.Controls.Add(this.TrackBar_Blue);
            this.groupBox3.Controls.Add(this.TrackBar_Green);
            this.groupBox3.Controls.Add(this.TrackBar_Red);
            this.groupBox3.Controls.Add(this.pnl_Color);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(201, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 219);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // nud_Alpha
            // 
            this.nud_Alpha.Location = new System.Drawing.Point(138, 149);
            this.nud_Alpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Alpha.Name = "nud_Alpha";
            this.nud_Alpha.Size = new System.Drawing.Size(38, 20);
            this.nud_Alpha.TabIndex = 7;
            this.nud_Alpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Alpha.ValueChanged += new System.EventHandler(this.nud_ColorNUD_ValueChanged);
            // 
            // nud_Blue
            // 
            this.nud_Blue.Location = new System.Drawing.Point(138, 110);
            this.nud_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Blue.Name = "nud_Blue";
            this.nud_Blue.Size = new System.Drawing.Size(38, 20);
            this.nud_Blue.TabIndex = 5;
            this.nud_Blue.ValueChanged += new System.EventHandler(this.nud_ColorNUD_ValueChanged);
            // 
            // nud_Green
            // 
            this.nud_Green.Location = new System.Drawing.Point(138, 71);
            this.nud_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Green.Name = "nud_Green";
            this.nud_Green.Size = new System.Drawing.Size(38, 20);
            this.nud_Green.TabIndex = 3;
            this.nud_Green.ValueChanged += new System.EventHandler(this.nud_ColorNUD_ValueChanged);
            // 
            // nud_Red
            // 
            this.nud_Red.Location = new System.Drawing.Point(138, 32);
            this.nud_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Red.Name = "nud_Red";
            this.nud_Red.Size = new System.Drawing.Size(38, 20);
            this.nud_Red.TabIndex = 1;
            this.nud_Red.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_Red.ValueChanged += new System.EventHandler(this.nud_ColorNUD_ValueChanged);
            // 
            // TrackBar_Alpha
            // 
            this.TrackBar_Alpha.AutoSize = false;
            this.TrackBar_Alpha.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar_Alpha.Location = new System.Drawing.Point(6, 149);
            this.TrackBar_Alpha.Maximum = 255;
            this.TrackBar_Alpha.Name = "TrackBar_Alpha";
            this.TrackBar_Alpha.Size = new System.Drawing.Size(126, 20);
            this.TrackBar_Alpha.TabIndex = 6;
            this.TrackBar_Alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Alpha.Value = 255;
            this.TrackBar_Alpha.ValueChanged += new System.EventHandler(this.TrackBar_ColorTrackBar_ValueChanged);
            // 
            // TrackBar_Blue
            // 
            this.TrackBar_Blue.AutoSize = false;
            this.TrackBar_Blue.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar_Blue.Location = new System.Drawing.Point(6, 110);
            this.TrackBar_Blue.Maximum = 255;
            this.TrackBar_Blue.Name = "TrackBar_Blue";
            this.TrackBar_Blue.Size = new System.Drawing.Size(126, 20);
            this.TrackBar_Blue.TabIndex = 4;
            this.TrackBar_Blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Blue.ValueChanged += new System.EventHandler(this.TrackBar_ColorTrackBar_ValueChanged);
            // 
            // TrackBar_Green
            // 
            this.TrackBar_Green.AutoSize = false;
            this.TrackBar_Green.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar_Green.Location = new System.Drawing.Point(6, 71);
            this.TrackBar_Green.Maximum = 255;
            this.TrackBar_Green.Name = "TrackBar_Green";
            this.TrackBar_Green.Size = new System.Drawing.Size(126, 20);
            this.TrackBar_Green.TabIndex = 2;
            this.TrackBar_Green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Green.ValueChanged += new System.EventHandler(this.TrackBar_ColorTrackBar_ValueChanged);
            // 
            // TrackBar_Red
            // 
            this.TrackBar_Red.AutoSize = false;
            this.TrackBar_Red.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar_Red.Location = new System.Drawing.Point(6, 32);
            this.TrackBar_Red.Maximum = 255;
            this.TrackBar_Red.Name = "TrackBar_Red";
            this.TrackBar_Red.Size = new System.Drawing.Size(126, 20);
            this.TrackBar_Red.TabIndex = 0;
            this.TrackBar_Red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_Red.Value = 255;
            this.TrackBar_Red.ValueChanged += new System.EventHandler(this.TrackBar_ColorTrackBar_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Alpha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Orbit Radius:";
            // 
            // nud_OrbitRadius
            // 
            this.nud_OrbitRadius.Location = new System.Drawing.Point(12, 326);
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
            this.nud_OrbitRadius.Size = new System.Drawing.Size(74, 20);
            this.nud_OrbitRadius.TabIndex = 6;
            this.nud_OrbitRadius.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitRadius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Orbit Days";
            // 
            // nud_OrbitDays
            // 
            this.nud_OrbitDays.Location = new System.Drawing.Point(12, 287);
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
            this.nud_OrbitDays.Size = new System.Drawing.Size(74, 20);
            this.nud_OrbitDays.TabIndex = 4;
            this.nud_OrbitDays.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_OrbitDays.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(105, 310);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 13);
            this.label32.TabIndex = 93;
            this.label32.Text = "Middle Radius";
            // 
            // nud_MiddleRadius
            // 
            this.nud_MiddleRadius.Location = new System.Drawing.Point(105, 326);
            this.nud_MiddleRadius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_MiddleRadius.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_MiddleRadius.Name = "nud_MiddleRadius";
            this.nud_MiddleRadius.Size = new System.Drawing.Size(74, 20);
            this.nud_MiddleRadius.TabIndex = 7;
            this.nud_MiddleRadius.ValueChanged += new System.EventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MiddleRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MiddleRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChangedBTNAddUpdateCheck);
            this.nud_MiddleRadius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextChangedBTNAddUpdateCheck);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(105, 271);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 13);
            this.label33.TabIndex = 91;
            this.label33.Text = "Band Index";
            // 
            // nud_BandIndex
            // 
            this.nud_BandIndex.Location = new System.Drawing.Point(105, 287);
            this.nud_BandIndex.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_BandIndex.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nud_BandIndex.Name = "nud_BandIndex";
            this.nud_BandIndex.Size = new System.Drawing.Size(74, 20);
            this.nud_BandIndex.TabIndex = 5;
            // 
            // btn_FocusRefresh
            // 
            this.btn_FocusRefresh.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_FocusRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FocusRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_FocusRefresh.Location = new System.Drawing.Point(151, 71);
            this.btn_FocusRefresh.Name = "btn_FocusRefresh";
            this.btn_FocusRefresh.Size = new System.Drawing.Size(22, 21);
            this.btn_FocusRefresh.TabIndex = 3;
            this.btn_FocusRefresh.UseVisualStyleBackColor = true;
            this.btn_FocusRefresh.Click += new System.EventHandler(this.btn_FocusRefresh_Click_1);
            // 
            // ComboBox_RingBands
            // 
            this.ComboBox_RingBands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_RingBands.FormattingEnabled = true;
            this.ComboBox_RingBands.Location = new System.Drawing.Point(6, 110);
            this.ComboBox_RingBands.Name = "ComboBox_RingBands";
            this.ComboBox_RingBands.Size = new System.Drawing.Size(167, 21);
            this.ComboBox_RingBands.TabIndex = 4;
            this.ComboBox_RingBands.SelectedIndexChanged += new System.EventHandler(this.ComboBox_RingBands_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Ring Bands On Selected System:";
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackgroundImage = global::SSSystemGenerator.Properties.Resources.Undo;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Undo.Location = new System.Drawing.Point(142, 388);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(37, 35);
            this.btn_Undo.TabIndex = 12;
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // RingBands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 434);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_OrbitRadius);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_OrbitDays);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.nud_MiddleRadius);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.nud_BandIndex);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RingBand);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.ComboBox_TerrainID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_ID);
            this.Name = "RingBands";
            this.Text = "RingBands";
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandWidthInEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandWidthInTexture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_OrbitDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MiddleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BandIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tb_TextureID;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tb_TextureCategory;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown nud_BandWidthInEngine;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown nud_BandWidthInTexture;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox ComboBox_TerrainID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_RingBand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar TrackBar_Red;
        private System.Windows.Forms.NumericUpDown nud_Red;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Alpha;
        private System.Windows.Forms.NumericUpDown nud_Blue;
        private System.Windows.Forms.NumericUpDown nud_Green;
        private System.Windows.Forms.TrackBar TrackBar_Alpha;
        private System.Windows.Forms.TrackBar TrackBar_Blue;
        private System.Windows.Forms.TrackBar TrackBar_Green;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_OrbitRadius;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_OrbitDays;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nud_MiddleRadius;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nud_BandIndex;
        private System.Windows.Forms.Button btn_SystemsRefresh;
        private System.Windows.Forms.ComboBox ComboBox_Systems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboBox_FocusID;
        private System.Windows.Forms.Button btn_FocusRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_RingBands;
        private System.Windows.Forms.Button btn_Undo;
    }
}