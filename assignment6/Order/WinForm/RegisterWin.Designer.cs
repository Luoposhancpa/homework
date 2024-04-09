namespace WinForm
{
    partial class RegisterWin
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
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.passwordComfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("宋体", 24F);
            this.password.Location = new System.Drawing.Point(344, 318);
            this.password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(720, 78);
            this.password.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(142, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码:";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 24F);
            this.userName.Location = new System.Drawing.Point(344, 188);
            this.userName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(720, 78);
            this.userName.TabIndex = 8;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("宋体", 24F);
            this.user.Location = new System.Drawing.Point(78, 188);
            this.user.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(251, 64);
            this.user.TabIndex = 6;
            this.user.Text = "用户名:";
            
            // 
            // passwordComfirm
            // 
            this.passwordComfirm.Font = new System.Drawing.Font("宋体", 24F);
            this.passwordComfirm.Location = new System.Drawing.Point(344, 430);
            this.passwordComfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordComfirm.Multiline = true;
            this.passwordComfirm.Name = "passwordComfirm";
            this.passwordComfirm.PasswordChar = '*';
            this.passwordComfirm.Size = new System.Drawing.Size(720, 78);
            this.passwordComfirm.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F);
            this.label2.Location = new System.Drawing.Point(14, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 64);
            this.label2.TabIndex = 12;
            this.label2.Text = "确认密码:";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("宋体", 24F);
            this.registerButton.Location = new System.Drawing.Point(446, 564);
            this.registerButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(192, 86);
            this.registerButton.TabIndex = 14;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 730);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordComfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.user);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RegisterWin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox passwordComfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
    }
}