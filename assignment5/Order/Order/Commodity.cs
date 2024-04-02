using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Commodity//商品
    {
        private static int totalId = 0;
        private int id;
        private string name;
        private double unitPrice;

        public string Name { get => name; set => name = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Id { get => id; }

        public Commodity(string name, double unitPrice)
        {
            this.id = totalId++;
            this.name = name;
            this.unitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"编号:{id}\t商品名称：{name} \t 单价：{unitPrice}";
        }
    }
}
