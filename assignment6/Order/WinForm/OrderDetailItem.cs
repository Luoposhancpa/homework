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
    public partial class OrderDetailItem : UserControl
    {
        private OrderDetails orderDetails;
        public OrderDetailItem(OrderDetails orderDetails)
        {
            this.orderDetails = orderDetails;
            InitializeComponent();
            commodityName.DataBindings.Add("Text", orderDetails.Commodity, "Name");
            UnitPrice.DataBindings.Add("Text", orderDetails.Commodity, "UnitPrice");
            num.DataBindings.Add("Text", orderDetails, "Nums");
            totalPrice.DataBindings.Add("Text", orderDetails, "TotalPrice");

        }

        
    }
}
