using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Commodity//商品
    {
        
        private int id;

        private string name;
        private double unitPrice;

        public string Name { get => name; set => name = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Id { get => id; set => id = value; }

        public Commodity() { }
        public Commodity(string name, double unitPrice)
        {
            
            this.name = name;
            this.unitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"编号:{id}\t商品名称：{name} \t 单价：{unitPrice}";
        }
    }
}
