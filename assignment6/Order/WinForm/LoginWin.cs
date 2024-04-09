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
    public partial class LoginWin : Form
    {
        private OrderService orderService;
        public event System.EventHandler loginButtonClick;
        public LoginWin(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.login(userName.Text, password.Text);
                loginButtonClick?.Invoke(sender,new EventArgs());
                //MessageBox.Show("登陆成功");
            }
            catch (Exception exception ){
                MessageBox.Show(exception.Message);
            }
           
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void user_Click_1(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
