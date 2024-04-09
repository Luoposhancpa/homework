namespace WinForm
{
    partial class Shop
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
            this.queryButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(0, 650);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(282, 96);
            this.queryButton.TabIndex = 0;
            this.queryButton.Text = "我的订单";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(0, 322);
            this.shopButton.Margin = new System.Windows.Forms.Padding(6);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(282, 96);
            this.shopButton.TabIndex = 1;
            this.shopButton.Text = "购物";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(294, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 1420);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2192, 1422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.queryButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Panel panel1;
    }
}