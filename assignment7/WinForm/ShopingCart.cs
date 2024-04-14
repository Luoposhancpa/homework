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
        public event EventHandler CloseEvent;
        private bool u;
        public ShopingCart(OrderService orderService,bool u)
        {
            this.u = u;
            this.orderService = orderService;
            InitializeComponent();
            orderDetailShow();
            orderService.orderDetailChaged += new EventHandler(orderDetailChaged);
            textBox1.Text = orderService.Order.Remark;
            textBox2.Text = orderService.Order.Destination;
            textBox3.Text = orderService.Order.Customer.Name;
            submit.Text = u ? "提交" : "修改";
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
                string m= u ? "提交" : "修改";
                MessageBox.Show(m+"成功");
                if (!u) CloseEvent?.Invoke(this, new EventArgs());
                orderDetailShow();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            orderService.Order.Customer.Name = textBox3.Text;
        }
    }
}
