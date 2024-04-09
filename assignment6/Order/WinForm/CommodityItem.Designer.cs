namespace WinForm
{
    partial class CommodityItem
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
            this.commodityPrice = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commodityName
            // 
            this.commodityName.Font = new System.Drawing.Font("宋体", 25F);
            this.commodityName.Location = new System.Drawing.Point(440, 20);
            this.commodityName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.commodityName.Name = "commodityName";
            this.commodityName.Size = new System.Drawing.Size(376, 154);
            this.commodityName.TabIndex = 0;
            this.commodityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commodityPrice
            // 
            this.commodityPrice.Font = new System.Drawing.Font("宋体", 25F);
            this.commodityPrice.Location = new System.Drawing.Point(848, 20);
            this.commodityPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.commodityPrice.Name = "commodityPrice";
            this.commodityPrice.Size = new System.Drawing.Size(376, 154);
            this.commodityPrice.TabIndex = 1;
            this.commodityPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("宋体", 25F);
            this.add.Location = new System.Drawing.Point(1631, 53);
            this.add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 88);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("宋体", 25F);
            this.down.Location = new System.Drawing.Point(1458, 53);
            this.down.Margin = new System.Windows.Forms.Padding(6);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(144, 88);
            this.down.TabIndex = 3;
            this.down.Text = "-";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // CommodityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.down);
            this.Controls.Add(this.add);
            this.Controls.Add(this.commodityPrice);
            this.Controls.Add(this.commodityName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CommodityItem";
            this.Size = new System.Drawing.Size(1796, 196);
            this.Load += new System.EventHandler(this.CommodityItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label commodityName;
        private System.Windows.Forms.Label commodityPrice;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button down;
    }
}
