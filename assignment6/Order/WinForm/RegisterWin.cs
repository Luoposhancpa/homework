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
    public partial class RegisterWin : Form
    {
        private OrderService orderService;
        public RegisterWin(OrderService orderService)
        {
            this.orderService = orderService;    
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.register(userName.Text, password.Text, passwordComfirm.Text);
                MessageBox.Show("注册成功");
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}
