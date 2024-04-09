namespace WinForm
{
    partial class OrderItem
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
            this.id = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Location = new System.Drawing.Point(84, 30);
            this.id.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(246, 114);
            this.id.TabIndex = 0;
            this.id.Text = "订单编号";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // destination
            // 
            this.destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destination.Location = new System.Drawing.Point(84, 184);
            this.destination.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(782, 103);
            this.destination.TabIndex = 1;
            this.destination.Text = "地址";
            this.destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.destination.Click += new System.EventHandler(this.label1_Click);
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(459, 21);
            this.price.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(347, 123);
            this.price.TabIndex = 2;
            this.price.Text = "价格";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remark
            // 
            this.remark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remark.Location = new System.Drawing.Point(907, 21);
            this.remark.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(674, 266);
            this.remark.TabIndex = 3;
            this.remark.Text = "备注";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("宋体", 10F);
            this.update.Location = new System.Drawing.Point(1624, 21);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(152, 69);
            this.update.TabIndex = 4;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("宋体", 10F);
            this.remove.Location = new System.Drawing.Point(1624, 105);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(152, 69);
            this.remove.TabIndex = 5;
            this.remove.Text = "删除";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("宋体", 10F);
            this.details.Location = new System.Drawing.Point(1624, 196);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(152, 69);
            this.details.TabIndex = 6;
            this.details.Text = "订单详情";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.details);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.price);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.id);
            this.Font = new System.Drawing.Font("宋体", 20F);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1780, 298);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label remark;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button details;
    }
}
