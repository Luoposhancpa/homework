using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Order
{
    public class OrderService
    {
        
        private Customer customer;
        private Order order;
        private bool isLogin=false;
        public event EventHandler orderDetailChaged;
        public bool IsLogin { get => isLogin; set => isLogin = value; }
        
        public Customer Customer { get => customer; set => customer = value; }
        
        public List<Commodity> Commodities { get { return queryCommodites(); }  }
        public Order Order { get => order; set => order = value; }

        public OrderService()
        {
            order=new Order();



            List<Commodity> commodities = new List<Commodity>();
            commodities.Add(new Commodity("冰箱", 4000));
            commodities.Add(new Commodity("电视", 3000));
            commodities.Add(new Commodity("洗衣机", 3658));
            commodities.Add(new Commodity("空调", 5928));
            commodities.Add(new Commodity("电风扇", 200));
            commodities.Add(new Commodity("饮水机", 150));
            using (var context = new OrderContext())
            {
                commodities.ForEach(c =>
                {
                    if(context.Commodities.FirstOrDefault(x=>x.Name == c.Name) == null)
                    {
                        context.Commodities.Add(c);
                        context.SaveChanges();
                    }


                });

            }
        }
     
      
       public List<Commodity> queryCommodites()
        {
            using (var context = new OrderContext())
            {
                return context.Commodities.ToList();

            }
        }
       public Commodity queryCommodityById(int id)
        {
            using (var context = new OrderContext())
            {
                return context.Commodities.FirstOrDefault(c=>c.Id==id);

            }
        }
        //添加订单
        public void chooseCommodity( List<OrderDetails> orderDetails,int commodityId,bool upDown)
        {
            using(var context = new OrderContext())
            {
                Commodity c= context.Commodities.FirstOrDefault(x => x.Id == commodityId);
                
                int idx = orderDetails.FindIndex(o => c.Name == o.Commodity.Name);
                if (idx<0 && !upDown) return;
                if (idx < 0)
                {

                    orderDetails.Add(new OrderDetails(Commodities.FirstOrDefault(co => co.Id == commodityId), 1));
                }
                else if (upDown)
                {
                    orderDetails[idx].Nums++;
                    orderDetails[idx].TotalPrice = orderDetails[idx].Nums * orderDetails[idx].Commodity.UnitPrice;
                }
                else
                {
                    orderDetails[idx].Nums--;
                    orderDetails[idx].TotalPrice = orderDetails[idx].Nums * orderDetails[idx].Commodity.UnitPrice;
                    if (orderDetails[idx].Nums == 0) orderDetails.RemoveAt(idx);
                }
                orderDetailChaged?.Invoke(this, EventArgs.Empty);
            }
           
        }
        public void add()
        { //订单提交到系统存储

            if (order.OrderDetails.Count == 0) throw new Exception("订单为空");
            if(String.IsNullOrEmpty(order.Customer.Name) || String.IsNullOrEmpty(order.Remark)||String.IsNullOrEmpty(order.Destination)) throw new Exception("客户姓名和地址和备注不能为空");
            
            Order.CreateTime = DateTime.Now;
            order.UpdateTime = order.CreateTime;//更新时间一开始等于创造时间，创造时间在构造函数中赋初值
            
            using (var context = new OrderContext())
            {

              
                context.Orders.Add(order);
                order.OrderDetails.ForEach(o =>
                {
                    context.Entry(o.Commodity).State = EntityState.Unchanged;
                });

                context.SaveChanges();
                
            }
        }
        //删除订单
        public void remove(int id)
        {

            using (var context = new OrderContext())
            {
                var order = context.Orders.Include("Customer").Include("OrderDetails").SingleOrDefault(c => c.Id==id);

                var customer = context.Customers.SingleOrDefault(c => c.Id == order.Customer.Id);
                if (order != null)
                {
                    context.Customers.Remove(customer); 
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }

            }


        }
        //修改订单
        private Order selectOrder(int id)//根据id选择订单
        {
            return null;
        }
        public void update(int id)
        {
            remove(id);
            


        }
        //查询订单
        public List<Order> queryAll()//查询订单
        {

            using (var context = new OrderContext())
            {
               
                var query = context.Orders.Include("Customer").Where(o => 1 == 1).OrderByDescending(o=>o.UpdateTime);
                List < Order > orders = query.ToList();
                orders.ForEach(o =>
                {
                    o.OrderDetails=context.OrderDetails.Include("Commodity").Where(d=>d.OrderId==o.Id).ToList();
                });
                return orders;
                

            }
        }
        public Order queryById(int id)//查询订单
        {

            using (var context = new OrderContext())
            {

                var query = context.Orders.Include("Customer").SingleOrDefault(o => o.Id == id);
               query.OrderDetails = context.OrderDetails.Include("Commodity").Where(d => d.OrderId == query.Id).ToList();
                return query;


            }
        }
        public static int _select(int start, int end)//该系统中有很多次选择，所有写成一个方法
        {
            while (true)
            {
                try
                {
                    string select = Console.ReadLine();
                    if (select == "e") return int.MinValue;//输入的是e说明是退出，返回int.MinValue
                    int s = Int32.Parse(select);
                    if (s < start || s > end)//输入的选项必须是在start-end之间，否则抛出异常，以及非法输入的处理
                        throw new Exception();
                    return s;
                }
                catch (Exception e) { Console.WriteLine("请输入合法选项"); }
            }


        }

    }
}
