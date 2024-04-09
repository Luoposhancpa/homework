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
    public partial class CommodityList : Form
    {
        private OrderService orderService;
        
        public CommodityList(OrderService orderService)
        {
            this.orderService = orderService;
           
            InitializeComponent();
            orderService.Commodities.ForEach(c => {
                CommodityItem commodityItem = new CommodityItem(c);
                flowLayoutPanel1.Controls.Add(commodityItem);
                commodityItem.CommodityNumChanged += new EventHandler(shoppingCartChaged);
            });
            flowLayoutPanel2.Controls.Add(new ShopingCart(orderService));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void shoppingCartChaged(object sender, EventArgs e)
        {
            CommodityNumchagedEventArgs cA=(CommodityNumchagedEventArgs)e;
            orderService.chooseCommodity(orderService.Order.OrderDetails, cA.Id,cA.UpDown);

        }
    }
}
