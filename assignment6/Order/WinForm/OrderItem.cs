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
    public partial class OrderItem : UserControl
    {
        private Order.Order order;
        public event EventHandler RemoveEvent;
        public OrderItem(Order.Order order)
        {
            this.order = order;
            InitializeComponent();
            id.DataBindings.Add("Text", order, "Id");
            price.DataBindings.Add("Text", order, "Price");
            destination.DataBindings.Add("Text", order, "Destination");
            remark.DataBindings.Add("Text", order, "Remark");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            new Update(order).ShowDialog();
           destination.Text = order.Destination;
            remark.Text = order.Remark;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Console.WriteLine(order.Id);
            RemoveEvent?.Invoke(this, new RemoveArgs(order.Id));
        }

        private void details_Click(object sender, EventArgs e)
        {
            new OrderDetailWin(order).ShowDialog();
        }
    }
    class RemoveArgs : EventArgs
    {
        private int id;

        public RemoveArgs(int id)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
    }
}
