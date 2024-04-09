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
    public partial class OrderList : Form
    {
        private OrderService orderService;
        public OrderList(OrderService orderService)
        {
            this.orderService = orderService;
            InitializeComponent();
           queryAll();
        }
        private void queryAll()
        {
            flowLayoutPanel2.Controls.Clear();
            orderService.queryAll().ForEach(x => {
                OrderItem orderItem = new OrderItem(x);
                orderItem.RemoveEvent += new EventHandler(Order_Remove);
                flowLayoutPanel2.Controls.Add(orderItem);
            });
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Order_Remove(object sender, EventArgs e)
        {
            RemoveArgs rA=(RemoveArgs)e;
            Console.WriteLine(rA.Id);
            orderService.remove(rA.Id);
            queryAll();
        }
    }
}
