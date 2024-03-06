using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    internal class Program
    {
        public static void sieveOfEratosthenes(int num)
        {
            //将2~num的数装填
            Console.WriteLine("2~{0}的以内的素数：",num);
            List<int> arrayList= new List<int>();
            for(int i = 2; i <= num; i++)
            {
                arrayList.Add(i);
            }
            //按照埃氏筛法筛选
            for (int i = 0;i < arrayList.Count; i++)
            {
                for(int j = i+1;j< arrayList.Count; j++)
                {
                    if (arrayList[j] % arrayList[i] == 0)
                    {
                        arrayList.RemoveAt(j);
                        j--;
                    }
                }
            }
            //打印剩余的数
            foreach(int i in arrayList)
            {
                Console.Write(i+" ");
            }
        }
        static void Main(string[] args)
            
        {
            Console.WriteLine("请输入一个数");
            int num = Int32.Parse(Console.ReadLine());
            sieveOfEratosthenes(num);
            Console.ReadKey();
        }
    }
}
