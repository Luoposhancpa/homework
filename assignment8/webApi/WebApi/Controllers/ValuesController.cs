using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using WebApi.Models;
namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private OrderService OrderService;
        public ValuesController(OrderContext context ,ILogger<ValuesController> logger)
        {
            OrderService=new OrderService(context);
            _logger = logger;
        }
        [HttpPost]
        /*
         Post  http://localhost:5025/api/values/orderAdd
               body:
                {
                "Customer": {
        
                             "Name": "laal",
                             "ContactInformation": "1123",
                            "Password": "123",
                             "UserName": "123"
                            },
                 "Price": 8000,
                 "CreateTime": "2024-04-19T14:48:49.9739266+08:00",
                  "UpdateTime": "0001-01-01T00:00:00",
                  "Destination": "qwd",
                "Remark": "wdq",
                 "State": 0,
                "OrderDetails": [{
                                      "Nums":12,
                                     "Commodity":{
                                 
                                     "Name":"冰箱",
                                     "UnitPrice":123
                                 },
                               "TotalPrice":12345

                        }]
                    }
         */
      
        public ActionResult<string> orderAdd(Order order)
        {
            OrderService.addOrder(order);
            return "success";
        }
        [HttpGet]
        /*Get http://localhost:5025/api/values/orderAdd
         * 
         * 
         */
        public ActionResult<List<Order>> orderList() { 
            return OrderService.queryAll();
        }
        [HttpDelete]
        /*Delete http://localhost:5025/api/values/orderDelete?id=1
        * 
        * 
        */
        public ActionResult<string> orderDelete(int id)
        {
            var order=OrderService.queryById(id);
            if (order != null)
            {
                OrderService.remove(id);
                return "success";
            }
            return "未找到该订单";
        }
        [HttpPut]
        /*Put http://localhost:5025/api/values/orderUpdate
        * 
        *
        * 从上面的orderList函数返回的json里面拿一个对象json，任意更改除了id以外的属性
        *  {
                "Customer": {
        
                             "Name": "laal",
                             "ContactInformation": "1123",
                            "Password": "123",
                             "UserName": "123"
                            },
                 "Price": 8000,
                 "CreateTime": "2024-04-19T14:48:49.9739266+08:00",
                  "UpdateTime": "0001-01-01T00:00:00",
                  "Destination": "qwd",
                "Remark": "wdq",
                 "State": 0,
                "OrderDetails": [{
                                      "Nums":12,
                                     "Commodity":{
                                 
                                     "Name":"冰箱",
                                     "UnitPrice":123
                                 },
                               "TotalPrice":12345

                        }]
                    }
        */
        public ActionResult<string> orderUpdate(Order order)
        {
            try
            {
                OrderService.update(order);
            }
            catch(Exception e)
            {
                return e.Message;
            }    
            
            return "success" ;
        }
    }
}
