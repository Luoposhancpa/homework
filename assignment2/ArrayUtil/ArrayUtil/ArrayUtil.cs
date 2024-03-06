using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtil
{
    internal class ArrayUtil
    {

        public static void showArray(int[] array)
        {
            Console.WriteLine("你输入的数组是");
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("其最大值是："+maxOfArray(array));
            Console.WriteLine("其最小值是：" + minOfArray(array));
            Console.WriteLine("其和是：" + sumOfArray(array));
            Console.WriteLine("其平均值是：" + averageOfArray(array));
        }
        public static int maxOfArray(int [] array)
        {
            int maxNum = (int)array[0];
            foreach(int num in array)
            {
                if(num > maxNum)
                {
                    maxNum = num;
                }
                   
            }
            return maxNum;
        }
        public static int minOfArray(int [] array)
        {
            int minNum = array[0];
            foreach (int num in array)
            {
                if (num < minNum)
                {
                    minNum = num;
                }

            }
            return minNum;
        }
        public static int sumOfArray(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;

            }
            return sum;
        }
        public static int averageOfArray(int[] array)
        {
            
           
            return sumOfArray(array)/array.Length;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                //----控制台输入数组并转化--------
                Console.WriteLine("请输入以空格分隔的整数数组:");

                string input = Console.ReadLine();

                // 将字符串按空格分割成字符串数组
                string[] inputArray = input.Split(' ');

                // 将字符串数组转换为整数数组
                int[] array = new int[inputArray.Length];
                bool inputSucces = true;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (int.TryParse(inputArray[i], out int num))
                    {
                        array[i] = num;
                    }
                    else
                    {
                        Console.WriteLine($"无法解析为整数: {inputArray[i]}");
                        inputSucces = false;
                    }
                }
                //---------------------------------------
                //展示数组的信息
                if (inputSucces)
                {
                    showArray(array);
                    break;
                }
                
            }
           
           
            Console.ReadKey();

          
        }
    }
}
