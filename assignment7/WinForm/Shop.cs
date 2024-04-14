using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace WinForm
{
    public partial class Shop : Form
    {
        private OrderService orderService;
       
        public Shop()
        {
            orderService =new OrderService();
            InitializeComponent();
            whichWin(new CommodityList(orderService,true));
        }
        public void whichWin(Form form)
        {
            
            //设置子窗口不显示为顶级窗口

            form.TopLevel = false;

            //设置子窗口的样式，没有上面的标题栏

            form.FormBorderStyle = FormBorderStyle.None;

            //填充

            form.Dock = DockStyle.Fill;

            //清空Panel里面的控件

            this.panel1.Controls.Clear();

            //加入控件

            this.panel1.Controls.Add(form);

            //让窗体显示

            form.Show();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            whichWin(new CommodityList(orderService,true));
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            whichWin(new OrderList(orderService));
        }
    }
}
