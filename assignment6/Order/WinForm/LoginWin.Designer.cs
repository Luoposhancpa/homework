namespace WinForm
{
    partial class LoginWin
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
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.Font = new System.Drawing.Font("宋体", 24F);
            this.password.Location = new System.Drawing.Point(199, 174);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(285, 36);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(83, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "密码:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Font = new System.Drawing.Font("宋体", 24F);
            this.loginButton.Location = new System.Drawing.Point(219, 252);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(165, 74);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登陆";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 24F);
            this.userName.Location = new System.Drawing.Point(199, 110);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(285, 36);
            this.userName.TabIndex = 2;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("宋体", 24F);
            this.user.Location = new System.Drawing.Point(51, 113);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(251, 64);
            this.user.TabIndex = 0;
            this.user.Text = "用户名:";
            this.user.Click += new System.EventHandler(this.user_Click_1);
            // 
            // LoginWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(565, 365);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.user);
            this.Name = "LoginWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label user;
    }
}

