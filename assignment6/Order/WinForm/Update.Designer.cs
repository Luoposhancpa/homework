namespace WinForm
{
    partial class Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.TextBox();
            this.remark = new System.Windows.Forms.TextBox();
            this.comfirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(45, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "备注：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // destination
            // 
            this.destination.Font = new System.Drawing.Font("宋体", 17F);
            this.destination.Location = new System.Drawing.Point(218, 72);
            this.destination.Multiline = true;
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(714, 100);
            this.destination.TabIndex = 2;
            this.destination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            // 
            // remark
            // 
            this.remark.Font = new System.Drawing.Font("宋体", 17F);
            this.remark.Location = new System.Drawing.Point(218, 256);
            this.remark.Multiline = true;
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(714, 264);
            this.remark.TabIndex = 3;
            // 
            // comfirm
            // 
            this.comfirm.Font = new System.Drawing.Font("宋体", 15F);
            this.comfirm.Location = new System.Drawing.Point(663, 550);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(224, 75);
            this.comfirm.TabIndex = 4;
            this.comfirm.Text = "确定";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("宋体", 15F);
            this.cancel.Location = new System.Drawing.Point(267, 550);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(224, 75);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 664);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Button cancel;
    }
}