using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace WinForm
{
    public partial class LoginMain : Form
    {
        private OrderService orderService;
        private LoginWin loginWin;
        private RegisterWin registerWin;
        private bool isLogin = true;
        public void loginOrRegister(Form form)
        {
            isLogin = !isLogin;
            //设置子窗口不显示为顶级窗口

            form.TopLevel = false;

            //设置子窗口的样式，没有上面的标题栏

            form.FormBorderStyle = FormBorderStyle.None;

            //填充

            form.Dock = DockStyle.Fill;

            //清空Panel里面的控件

            this.panel1.Controls.Clear();

            //加入控件

            this.panel1.Controls.Add(form);

            //让窗体显示

            form.Show();
        }
        public LoginMain()
        {
           orderService = new OrderService();
            loginWin = new LoginWin(orderService);
            registerWin = new RegisterWin(orderService);
            InitializeComponent();
            loginOrRegister(loginWin);
            loginWin.loginButtonClick += new System.EventHandler(this.login);

        }
        public void login(object sender,EventArgs arg)
        {
            
            
                this.Hide();
                Shop shop = new Shop(orderService);
                shop.Show();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(isLogin)
            {
                loginRegister.Text = "注册";
                loginOrRegister(loginWin);
            }
            else
            {
                loginRegister.Text = "返回登陆";
                loginOrRegister(registerWin);
            }
            

        }
    }
}
