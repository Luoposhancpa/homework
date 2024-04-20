using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Order
    {
        [Key]
        private int id;
        
        private Customer customer;
        private double price;//该订单的总价格
        private DateTime createTime;//创建时间
        private DateTime updateTime;//最新修改时间
        private string destination;//目的地
        private string remark;//备注
        private int state;//0未支付，1已支付，2已交付，3交付失败
        private List<OrderDetails> orderDetails;


        public Customer Customer { get => customer; set => customer = value; }
        public double Price { get { price = 0; orderDetails.ForEach(x => { price += x.TotalPrice; }); return price; } set => price = value; }
        public DateTime CreateTime { get => createTime; set => createTime = value; }
        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Remark { get => remark; set => remark = value; }
        public int State { get => state; set => state = value; }
        public List<OrderDetails> OrderDetails { get => orderDetails; set => orderDetails = value; }
        public int Id { get => id; set => id = value; }
        

        public Order()
        {

            CreateTime = DateTime.Now;
            State = 0;
            Customer = new Customer();
            OrderDetails = new List<OrderDetails>();
        }
        public override string ToString()
        {
            string details = "";
            OrderDetails.ForEach(x => details += x.ToString());
            return $"订单编号：{id}\r\n客户信息：{Customer}\r\n创建日期:{CreateTime}\r\n修改日期{UpdateTime}\r\n状态：{State}\r\n订单详情:{details}\r\n订单总价：{Price}";
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
