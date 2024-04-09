using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace WinForm
{
    public partial class ShopingCart : UserControl
    {
        private OrderService orderService;
        
        public ShopingCart(OrderService orderService)
        {
            
            this.orderService = orderService;
            InitializeComponent();
            orderDetailShow();
            orderService.orderDetailChaged += new EventHandler(orderDetailChaged);
           
        }
        public void orderDetailShow()
        {
            flowLayoutPanel1.Controls.Clear();
            orderService.Order.OrderDetails.ForEach(x => { flowLayoutPanel1.Controls.Add(new OrderDetailItem(x)); });
            totalPrice.Text= orderService.Order.Price.ToString();
        }
        public void orderDetailChaged(object sender, EventArgs e)
        {
            orderDetailShow();
            
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                orderService.add();
                orderService.Order = new Order.Order();
                MessageBox.Show("提交成功");
                orderDetailShow();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            orderService.Order.Remark = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            orderService.Order.Destination = textBox2.Text;
        }
    }
}
