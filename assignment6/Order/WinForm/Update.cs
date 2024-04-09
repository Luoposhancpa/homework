using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Update : Form
    {
        private Order.Order order;
        public Update(Order.Order order)
        {
            this.order = order;
            InitializeComponent();
            destination.Text = order.Destination;
            remark.Text = order.Remark;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            order.Destination = destination.Text;
            order.Remark = remark.Text;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
