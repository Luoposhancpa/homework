using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFactor
{
    internal class PrimeNumberFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            while(true)
            {
                try
                {
                    String nummber = Console.ReadLine();
                    int num = Int32.Parse(nummber);
                    Console.WriteLine(num + "的素数因子有：");
                    for (int i = 2; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                        while (num % i == 0)
                        {
                            num = num / i;
                        }
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("你的输入不是一个数字或者数字过大，请重新输入");
                }

            }


         
            Console.ReadKey();
        }
    }
}
