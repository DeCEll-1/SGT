namespace SSSystemGenerator.Forms
{
    partial class LoadingOrder
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
            this.btn_Order = new System.Windows.Forms.Button();
            this.lb_Order = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(2, 2);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(182, 23);
            this.btn_Order.TabIndex = 0;
            this.btn_Order.Text = "Order Entities";
            this.btn_Order.UseVisualStyleBackColor = true;
            // 
            // lb_Order
            // 
            this.lb_Order.FormattingEnabled = true;
            this.lb_Order.Location = new System.Drawing.Point(2, 28);
            this.lb_Order.Name = "lb_Order";
            this.lb_Order.Size = new System.Drawing.Size(182, 420);
            this.lb_Order.TabIndex = 2;
            // 
            // LoadingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 450);
            this.Controls.Add(this.lb_Order);
            this.Controls.Add(this.btn_Order);
            this.Name = "LoadingOrder";
            this.Text = "Load Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.ListBox lb_Order;
    }
}