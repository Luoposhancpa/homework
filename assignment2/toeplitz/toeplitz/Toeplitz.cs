using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toeplitz
{
    
    public class Matrices
    {
        private int m;
        private int n;
        const int maxSize = 100;
        private int [,]edges;
        public Matrices(int n,int m,int[,] edges)
        {
            this.m = m;
            this.n = n;
            this.edges = edges;
        }
        //判断是不是托普利茨矩阵 
        public bool isToeplit()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (edges[i,j] != edges[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    internal class Toeplitz
    {
        public  static void stringToArray(string s)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵");
            Console.WriteLine("矩阵有几行？");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("矩阵有几列？");
            int m = Int32.Parse(Console.ReadLine());
            int[,] edges = new int[n,m];
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("请输入第{0}行数据", j);
                string input = Console.ReadLine();

                // 将字符串按空格分割成字符串数组
                string[] inputArray = input.Split(' ');

                // 将字符串数组转换为整数数组
                int[] numbers = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (int.TryParse(inputArray[i], out int num))
                    {
                        numbers[i] = num;
                    }
                    else
                    {
                        Console.WriteLine($"无法解析为整数: {inputArray[i]}");
                        return;
                    }

                }
                for(int index = 0;index<m;index++)
                {
                    edges[j, index] = numbers[index];
                }
            }

            Matrices matrices = new Matrices(n, m, edges);
            if (matrices.isToeplit()) {
                Console.WriteLine("是托普利茨矩阵");
            }
            else {
                Console.WriteLine("不是托普利茨矩阵");
            }
            Console.ReadKey();
        }

    }
}
