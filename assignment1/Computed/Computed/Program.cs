using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computed
{
    internal class Caculate
    {
        public static double caculate(double num1, double num2,char oper,Boolean sucecss )
        {
            switch (oper)
            {
                case '+':
                    sucecss = true;
                    return num1 +num2;

                case '-':
                    sucecss = true;
                    return num1 - num2;
                case '*':
                    sucecss = true;
                    return num1 * num2;
                case '/'://除数不能为0
                    if (num2 == 0) {
                        sucecss = false;
                        return -1;
                    }
                    sucecss = true;
                    return num1 / num2;
                default: 
                    sucecss = false; 
                    return -1;
            }
        }
        static void Main(string[] args)
        {

            
            Boolean sucecss = true;
            while (sucecss)
            {
                Console.WriteLine("请输入第一个数");
                double num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个数");
                double num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("请输入运算符");
                char oper = (char)Console.Read();
                double res = caculate(num1, num2, oper, sucecss);
                if(!sucecss)
                {
                    Console.WriteLine("输入运算数或运算符有误，请重新输入");
                    sucecss = true;
                }
                
                Console.WriteLine(""+num1+oper+num2+"="+res);
                sucecss = false;
                Console.ReadKey();
            }
             
                                                
        }
    }
}
