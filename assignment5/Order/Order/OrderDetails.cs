using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class OrderDetails
    {
        private static int orderDetailsId = 0;
        private int id;
        private Commodity commodity;
        private int nums;//买的该商品数量
        private double totalPrice;//这个订单细节的总价格

        public int Nums { get => nums; set => nums = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public Commodity Commodity { get => commodity; set => commodity = value; }
        public int Id { get => id; }

        public OrderDetails(Commodity commodity, int nums)
        {
            this.id = orderDetailsId++;
            this.commodity = commodity;
            this.nums = nums;
            this.totalPrice = nums * commodity.UnitPrice;
        }

        public override string ToString()
        {
            return $"商品信息：{commodity}\r\n购买数量：{nums}\r\n总价格：{totalPrice}";
        }

        public OrderDetails()
        {
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
