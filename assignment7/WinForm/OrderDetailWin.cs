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
    public partial class OrderDetailWin : Form
    {
        private Order.Order order;
        public OrderDetailWin(Order.Order order)
        {
            this.order = order;
            InitializeComponent();
            orderDetailShow();
        }

        public void orderDetailShow()
        {
            flowLayoutPanel1.Controls.Clear();
            order.OrderDetails.ForEach(x => { flowLayoutPanel1.Controls.Add(new OrderDetailItem(x)); });
            totalPrice.Text = order.Price.ToString();
        }
    }
}
