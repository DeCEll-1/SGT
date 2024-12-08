using SSSystemGenerator.Forms;

namespace SSSystemGenerator
{
    partial class Stars : OrbitableMaster
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
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_CoronaSize = new System.Windows.Forms.NumericUpDown();
            this.nud_Radius = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CoronaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Radius)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(157, 252);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Corona Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Radius";
            // 
            // nud_CoronaSize
            // 
            this.nud_CoronaSize.Location = new System.Drawing.Point(161, 273);
            this.nud_CoronaSize.Margin = new System.Windows.Forms.Padding(4);
            this.nud_CoronaSize.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_CoronaSize.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_CoronaSize.Name = "nud_CoronaSize";
            this.nud_CoronaSize.Size = new System.Drawing.Size(89, 22);
            this.nud_CoronaSize.TabIndex = 6;
            // 
            // nud_Radius
            // 
            this.nud_Radius.Location = new System.Drawing.Point(13, 273);
            this.nud_Radius.Margin = new System.Windows.Forms.Padding(4);
            this.nud_Radius.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nud_Radius.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nud_Radius.Name = "nud_Radius";
            this.nud_Radius.Size = new System.Drawing.Size(92, 22);
            this.nud_Radius.TabIndex = 5;
            // 
            // Stars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 591);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nud_CoronaSize);
            this.Controls.Add(this.nud_Radius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stars";
            this.Text = "Stars";
            this.Controls.SetChildIndex(this.nud_Radius, 0);
            this.Controls.SetChildIndex(this.nud_CoronaSize, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CoronaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_CoronaSize;
        private System.Windows.Forms.NumericUpDown nud_Radius;
    }
}