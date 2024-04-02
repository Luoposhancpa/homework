using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class OrderService
    {
        private Customer customer;

        private List<Order> orderList;
        private List<Commodity> commodities;//商店卖的商品
        public OrderService()
        {

        }
        public void init()
        {
            signUp();
            //初始化商店的商品，这个项目只做订单，所以我把商品固定，给顾客选
            orderList = new List<Order>();
            commodities = new List<Commodity>();
            commodities.Add(new Commodity("冰箱", 4000));
            commodities.Add(new Commodity("电视", 3000));
            commodities.Add(new Commodity("洗衣机", 3658));
            commodities.Add(new Commodity("空调", 5928));
            commodities.Add(new Commodity("电风扇", 200));

        }
        public void signUp()//登陆
        {
            //这里先直接吧customer给赋初值，后续功能在增加
            customer = new Customer("hhh", "10086");

        }
        public void windows()//总窗口
        {
            init();
            bool isOrdering = true;
            while (isOrdering)
            {
                Console.Write("-------------------------\r\n" +
                              "1.添加订单\r\n" +
                              "2.删除订单\r\n" +
                              "3.修改订单\r\n" +
                              "4.查询订单\r\n" +
                              "e.退出\r\n" +
                              "-------------------------\r\n" +
                              "请选择你的选择（序号）\r\n"
                              );

                int select = _select(1, 4);
                switch (select)
                {
                    case 1:

                        if (chooseCommodity(out List<OrderDetails> orderDetails))//选择商品如果
                            add(orderDetails); //返回true，说明确认提交订单，将其存起来，反之就不作add操作

                        break;
                    case 2:
                        remove(); //删除订单
                        break;
                    case 3:
                        update(); //修改订单信息
                        break;
                    case 4:
                        query();//查询所有订单
                        Console.ReadKey();
                        break;
                    case int.MinValue:
                        isOrdering = false;
                        break;



                }
                Console.Clear();

            }


        }
        public void _chooseCommodity(List<OrderDetails> orderDetails)//选择商品，形成订单细节
        {


            while (true)
            {
                Console.Clear();

                commodities.ForEach(x => Console.WriteLine(x + "\r\n"));//展示商店的商品

                Console.WriteLine("--已选择商品--");

                orderDetails.ForEach(x => Console.WriteLine(x + "\r\n"));//展示已选择的商品细节

                Console.WriteLine("--请选择商品，推出选择按e");

                int s = _select(0, 4);//选择商品
                if (s == int.MinValue)
                    break;
                Console.WriteLine("请选择订购数量");

                int num = _select(1,int.MaxValue);//


                var query1 = from n in orderDetails where n.Commodity.Id == s select n;//看看编号s的商品是否之前已经选过
                foreach (var x in query1)
                {//如果选过那么修改其数量为num
                    x.Nums = num;
                    x.TotalPrice = num * x.Commodity.UnitPrice;
                }

                var query2 = from n in commodities where n.Id == s select n;//如果没选过，那就添加进去
                if (!query1.Any())
                {
                    orderDetails.Add(new OrderDetails(query2.ElementAt(0), num));

                }






            }
        }
        //添加订单
        public bool chooseCommodity(out List<OrderDetails> orderDetails)
        {

            orderDetails = new List<OrderDetails>();

            _chooseCommodity(orderDetails);//选择商品
            Console.WriteLine("是否提交该订单？0否，1是");

            return _select(0, 1) == 1 ? true : false;//确认提交，订单返回true
        }
        public void add(List<OrderDetails> orderDetails)
        { //订单提交到系统存储
            Order order = new Order();
            orderDetails.ForEach(x => order.Price += x.TotalPrice);//订单总价格
            order.Customer = customer;//顾客信息
            order.UpdateTime = order.CreateTime;//更新时间一开始等于创造时间，创造时间在构造函数中赋初值
            order.OrderDetails = orderDetails;
            orderList.Add(order);
        }
        //删除订单
        public void remove()
        {
            //根据订单编号id删除
            while (true)
            {
                Console.Clear();
                query();
                Console.WriteLine("---请选择需要删除的订单编号,按e退出--");
                try
                {
                    int select = _select(int.MinValue, int.MaxValue);
                    if (select == int.MinValue) break;
                    var e = orderList.FirstOrDefault(x => x.Id == select);
                    if (!orderList.Remove(e))
                        throw new Exception();



                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入选项有误，请重新输入");
                }
            }


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

            while (true)
            {
                Console.Clear();
                query();
                Console.WriteLine("---请选择需要更改的订单编号,e.退出--");
                try
                {
                    int select = _select(int.MinValue, int.MaxValue);
                    if (select == int.MinValue) break;
                    Order orderUpdate = selectOrder(select);//选择要修改的订单
                    if (orderUpdate == null)
                    {
                        throw new Exception();
                    }
                    bool exit = false;
                    while (!exit)
                    {
                        Console.Clear();
                        Console.WriteLine(orderUpdate.ToString()+"\r\n");
                        Console.Write(
                                                   "----请选择要修改的内容---\r\n" +
                                                   "1.顾客姓名\r\n" +
                                                   "2.顾客联系方式\r\n" +
                                                   "3.订单细节\r\n" +
                                                   "e.退出\r\n" +
                                                   "-------------------------\r\n" +
                                                   "请选择你的选择（序号）\r\n"
                                                   );
                        select = _select(1, 3);//选择要修改的内容
                        switch (select)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"原姓名：{orderUpdate.Customer.Name}\r\n更改为：");
                                    orderUpdate.Customer.Name = Console.ReadLine();

                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine($"原联系方式：{orderUpdate.Customer.ContactInformation}\r\n更改为：");
                                    orderUpdate.Customer.ContactInformation = Console.ReadLine();
                                    break;
                                }
                            case 3:
                                {
                                    _chooseCommodity(orderUpdate.OrderDetails);//订单细节更改和添加订单公用这个商品选择方法
                                    orderUpdate.Price = 0;
                                    orderUpdate.OrderDetails.ForEach(x => orderUpdate.Price += x.TotalPrice);//重新计算订单总价格
                                    orderUpdate.UpdateTime = DateTime.Now;//更新最新更改时间
                                    break;
                                }
                            case int.MinValue:
                                exit = true;
                                break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入选项有误，请重新输入");
                    continue;
                }

                
            }


        }
        //查询订单
        public void query()//查询订单
        {
            if (orderList.Count == 0) Console.WriteLine("当前没有订单");
            orderList.ForEach(x => Console.WriteLine(x + "\r\n"));

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
