namespace WinForm
{
    partial class LoginMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(126, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 404);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginRegister
            // 
            this.loginRegister.Location = new System.Drawing.Point(12, 26);
            this.loginRegister.Name = "loginRegister";
            this.loginRegister.Size = new System.Drawing.Size(76, 53);
            this.loginRegister.TabIndex = 1;
            this.loginRegister.Text = "注册";
            this.loginRegister.UseVisualStyleBackColor = true;
            this.loginRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(831, 548);
            this.Controls.Add(this.loginRegister);
            this.Controls.Add(this.panel1);
            this.Name = "LoginMain";
            this.Text = "LoginMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginRegister;

        
    }
}