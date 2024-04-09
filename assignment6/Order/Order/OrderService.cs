using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderService
    {
        private List<Customer> customers;
        private Customer customer;
        private List<Order> orderList;
        private Order order;
        private List<Commodity> commodities;//商店卖的商品
        private bool isLogin=false;
        public event EventHandler orderDetailChaged;
        public bool IsLogin { get => isLogin; set => isLogin = value; }
        public List<Customer> Customers { get => customers; set => customers = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public List<Order> OrderList { get => orderList; set => orderList = value; }
        public List<Commodity> Commodities { get => commodities; set => commodities = value; }
        public Order Order { get => order; set => order = value; }

        public OrderService()
        {
            order=new Order();
            customers=new List<Customer>();
            orderList = new List<Order>();
            commodities = new List<Commodity>();
            commodities.Add(new Commodity("冰箱", 4000));
            commodities.Add(new Commodity("电视", 3000));
            commodities.Add(new Commodity("洗衣机", 3658));
            commodities.Add(new Commodity("空调", 5928));
            commodities.Add(new Commodity("电风扇", 200));
            commodities.Add(new Commodity("饮水机", 150));
        }
     
        public void login(string userName,string password)//登陆
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) throw new Exception("用户名或者密码不能为空");
           int index= customers.FindIndex(o=>o.UserName==userName);
            if (index < 0) throw new Exception("该用户名不存在");
            if (customers[index].Password!=password) throw new Exception("密码错误");
            customer = customers[index];

        }
        public void register(string userName, string password,string passwordComfirm) {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordComfirm)) throw new Exception("用户名或者密码不能为空");
            if (password!=passwordComfirm) throw new Exception("两个密码输入不同");
            customers.Add(new Customer(userName, password));
        }
       
       
        //添加订单
        public void chooseCommodity( List<OrderDetails> orderDetails,int commodityId,bool upDown)
        {

            int idx = orderDetails.FindIndex(o => o.Commodity.Id == commodityId);
            if (idx < 0 && !upDown) return;
            if(idx<0)
            {
                
               orderDetails.Add(new OrderDetails(Commodities.FirstOrDefault(c => c.Id==commodityId),1));
            }
            else if(upDown)orderDetails[idx].Nums ++;
            else
            {
                orderDetails[idx].Nums --;
                if (orderDetails[idx].Nums == 0) orderDetails.RemoveAt(idx);
            }
            orderDetailChaged?.Invoke(this, EventArgs.Empty);
        }
        public void add()
        { //订单提交到系统存储

            if (order.OrderDetails.Count == 0) throw new Exception("订单为空");
            if(String.IsNullOrEmpty(order.Remark)||String.IsNullOrEmpty(order.Destination)) throw new Exception("地址和备注不能为空");
            order.Customer = customer;//顾客信息
            Order.CreateTime = DateTime.Now;
            order.UpdateTime = order.CreateTime;//更新时间一开始等于创造时间，创造时间在构造函数中赋初值
            orderList.Add(order);
        }
        //删除订单
        public void remove(int id)
        {
            Console.WriteLine(id);
            //根据订单编号id删除
           orderList.RemoveAt( orderList.FindIndex(o => o.Id == id));


        }
        //修改订单
        private Order selectOrder(int id)//根据id选择订单
        {
            var query1 = from n in orderList where n.Id == id select n;
            if (!query1.Any()) return null;

            return query1.ElementAt(0);

        }
        public void update()
        {

           


        }
        //查询订单
        public List<Order> queryAll()//查询订单
        {
            return orderList;

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
