using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Order
    {
        private static int orderId = 0;
        private int id;
        private Customer customer;
        private double price;//该订单的总价格
        private DateTime createTime;//创建时间
        private DateTime updateTime;//最新修改时间
        private int state;//0未支付，1已支付，2已交付，3交付失败
        private List<OrderDetails> orderDetails;
        public int Id { get => id; }
        public Customer Customer { get => customer; set => customer = value; }
        public double Price { get => price; set => price = value; }

        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
        public DateTime CreateTime { get => createTime; }
        internal List<OrderDetails> OrderDetails { get => orderDetails; set => orderDetails = value; }

        public Order()
        {
            id = orderId++;
            createTime = DateTime.Now;
            state = 0;

        }
        public override string ToString()
        {
            string details = "";
            orderDetails.ForEach(x => details += x.ToString());
            return $"订单编号：{id}\r\n客户信息：{customer}\r\n创建日期:{createTime}\r\n修改日期{updateTime}\r\n状态：{state}\r\n订单详情:{details}\r\n订单总价：{price}";
        }
        public override bool Equals(object obj)
        {
            Order orderDetails = obj as Order;
            if (orderDetails == null)
                return false;
            else
                return id == orderDetails.id;
        }

        //实现Equals重写同时，必须重写GetHashCode
        public override int GetHashCode()
        {
            return id;
        }
    }
}
