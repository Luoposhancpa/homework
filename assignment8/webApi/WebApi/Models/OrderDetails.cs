using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class OrderDetails
    {

        private int id;
        private Commodity commodity;
        private int nums;//买的该商品数量
        private double totalPrice;//这个订单细节的总价格
        private int orderId;
        public int Nums { get => nums; set => nums = value; }

        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public int Id { get => id; set => id = value; }
        public int OrderId { get => orderId; set => orderId = value; }
        public Commodity Commodity { get => commodity; set => commodity = value; }

        public OrderDetails() { }

        public OrderDetails(Commodity commodity, int nums)
        {

            this.commodity = commodity;
            this.nums = nums;
            totalPrice = nums * commodity.UnitPrice;
        }

        public override string ToString()
        {
            return $"商品信息：{commodity}\r\n购买数量：{nums}\r\n总价格：{totalPrice}";
        }


        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
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
