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
  
    public partial class CommodityItem : UserControl
    {
        private Commodity commodity;
        public event EventHandler CommodityNumChanged;
        public CommodityItem(Commodity commodity)
        {
            this.commodity = commodity;
            InitializeComponent();
        }

        private void CommodityItem_Load(object sender, EventArgs e)
        {
            commodityName.DataBindings.Add("Text", commodity, "Name");
            commodityPrice.DataBindings.Add("Text", commodity, "UnitPrice");

        }

        private void add_Click(object sender, EventArgs e)
        {

            CommodityNumChanged?.Invoke(this, new CommodityNumchagedEventArgs (commodity.Id,true));
        }

        private void down_Click(object sender, EventArgs e)
        {
            CommodityNumChanged?.Invoke(this, new CommodityNumchagedEventArgs(commodity.Id,false));
        }
    }
    public class CommodityNumchagedEventArgs : EventArgs
    {
        private int id;
        private bool upDown;

        public CommodityNumchagedEventArgs(int id, bool upDown)
        {
            this.id = id;
            this.upDown = upDown;
        }

        public int Id { get => id; set => id = value; }
        public bool UpDown { get => upDown; set => upDown = value; }
    }
}
