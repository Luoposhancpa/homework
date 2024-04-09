using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Customer
    {//客户
        private static int totalId = 0;
        private int id;
        private string userName;
        private string name;
        private string password;
        private string contactInformation;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactInformation { get => contactInformation; set => contactInformation = value; }
        public string Password { get => password; set => password = value; }
        public string UserName { get => userName; set => userName = value; }

        public Customer( string password, string userName)
        {
            this.id = totalId++;
            
            this.userName = userName;
            this.password = password;
           
        }
        public override string ToString()
        {
            return $"客户id：{id}\r\n客户姓名：{name}\r\n客户电话号码：{contactInformation}";
        }
    }
}
