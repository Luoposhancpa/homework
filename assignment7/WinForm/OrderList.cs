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
                orderItem.updateEvent += new EventHandler(Order_Update);
                flowLayoutPanel2.Controls.Add(orderItem);
            });
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Order_Remove(object sender, EventArgs e)
        {
            RemoveArgs rA=(RemoveArgs)e;
            
            orderService.remove(rA.Id);
            queryAll();
        }
        private void Order_Update(object sender, EventArgs e)
        {
            RemoveArgs rA = (RemoveArgs)e;
            
            
            orderService.Order=orderService.queryById(rA.Id);

            CommodityList commodityList=  new CommodityList(orderService,false);
            commodityList.ConformEvent += new EventHandler((s, ev) =>
            {
                orderService.remove(rA.Id);
            });
          
           
            commodityList.ShowDialog();
            

            queryAll();
        }
    }
}
