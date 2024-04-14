namespace WinForm
{
    partial class OrderDetailWin
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 143);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1671, 780);
            this.flowLayoutPanel1.TabIndex = 3;
            
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("宋体", 25F);
            this.totalPrice.Location = new System.Drawing.Point(82, 9);
            this.totalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(226, 120);
            this.totalPrice.TabIndex = 4;
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDetailWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1719, 923);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OrderDetailWin";
            this.Text = "OrderDetailWin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label totalPrice;
    }
}