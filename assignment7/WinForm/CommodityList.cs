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
        public EventHandler ConformEvent;
        public CommodityList(OrderService orderService,bool u)
        {
            this.orderService = orderService;
           
            InitializeComponent();
            orderService.Commodities.ForEach(c => {
                CommodityItem commodityItem = new CommodityItem(c);
                flowLayoutPanel1.Controls.Add(commodityItem);
                commodityItem.CommodityNumChanged += new EventHandler(shoppingCartChaged);
            });
            ShopingCart shopingCart = new ShopingCart(orderService, u);
            shopingCart.CloseEvent+= new EventHandler(Close);
            flowLayoutPanel2.Controls.Add(shopingCart);
        }
        private void Close(object sender, EventArgs e)
        {
            ConformEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
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
