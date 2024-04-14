using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class program
    {
        static void Main(string[] args)
        {

            using (var context = new OrderContext())
            {

                Commodity commodity = new Commodity();
                commodity.Id = 100;
                context.Commodities.Add(commodity);
                context.SaveChanges();
               Console.ReadKey();
     

            }
        }
    }
}
