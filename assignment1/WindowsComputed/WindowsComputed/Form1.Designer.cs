namespace WindowsComputed
{
    partial class Computed
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.driveListBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBoxArray(this.components);
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.oper = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driveListBoxArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("宋体", 20F);
            this.num1.Location = new System.Drawing.Point(12, 43);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(124, 37);
            this.num1.TabIndex = 0;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("宋体", 20F);
            this.num2.Location = new System.Drawing.Point(198, 43);
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(131, 37);
            this.num2.TabIndex = 1;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oper
            // 
            this.oper.Font = new System.Drawing.Font("宋体", 20F);
            this.oper.Location = new System.Drawing.Point(142, 34);
            this.oper.Name = "oper";
            this.oper.Size = new System.Drawing.Size(55, 50);
            this.oper.TabIndex = 2;
            this.oper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oper.Click += new System.EventHandler(this.label1_Click);
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("宋体", 20F);
            this.res.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.res.Location = new System.Drawing.Point(352, 43);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(142, 37);
            this.res.TabIndex = 4;
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.res.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.Location = new System.Drawing.Point(385, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 20F);
            this.button2.Location = new System.Drawing.Point(61, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 20F);
            this.button3.Location = new System.Drawing.Point(223, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 20F);
            this.button4.Location = new System.Drawing.Point(142, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 8;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 20F);
            this.button5.Location = new System.Drawing.Point(304, 108);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(323, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Computed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.oper);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Computed";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driveListBoxArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBoxArray driveListBoxArray1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label oper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}

