using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Customer
    {//客户
        private static int totalId = 0;
        private int id;
        private string name;
        private string contactInformation;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactInformation { get => contactInformation; set => contactInformation = value; }

        public Customer(string name, string contactInformation)
        {
            this.id = totalId++;
            this.name = name;
            this.contactInformation = contactInformation;
        }
        public override string ToString()
        {
            return $"客户id：{id}\r\n客户姓名：{name}\r\n客户电话号码：{contactInformation}";
        }
    }
}
