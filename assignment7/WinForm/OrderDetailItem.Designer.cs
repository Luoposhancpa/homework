namespace WinForm
{
    partial class OrderDetailItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.commodityName = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commodityName
            // 
            this.commodityName.Font = new System.Drawing.Font("宋体", 20F);
            this.commodityName.Location = new System.Drawing.Point(107, 6);
            this.commodityName.Name = "commodityName";
            this.commodityName.Size = new System.Drawing.Size(274, 144);
            this.commodityName.TabIndex = 0;
            this.commodityName.Text = "商品名称";
            this.commodityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Font = new System.Drawing.Font("宋体", 20F);
            this.UnitPrice.Location = new System.Drawing.Point(427, 0);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(239, 144);
            this.UnitPrice.TabIndex = 1;
            this.UnitPrice.Text = "单价";
            this.UnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("宋体", 20F);
            this.num.Location = new System.Drawing.Point(726, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(239, 144);
            this.num.TabIndex = 2;
            this.num.Text = "数量";
            this.num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("宋体", 20F);
            this.totalPrice.Location = new System.Drawing.Point(1015, 6);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(239, 144);
            this.totalPrice.TabIndex = 3;
            this.totalPrice.Text = "总价";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.num);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.commodityName);
            this.Name = "OrderDetailItem";
            this.Size = new System.Drawing.Size(1667, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label commodityName;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label totalPrice;
    }
}
