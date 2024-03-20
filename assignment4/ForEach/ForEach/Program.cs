using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ForEach

{
    public class GenericArray<T>
    {
        private T[] array;
        private int size;

        public GenericArray(int size)
        {
            array = new T[size];
        }
        public int length() {
            return array.Length;
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
        

        public void ForEach(Action<T> f)
        {
            if (f == null)
                throw new ArgumentNullException();
            
            for(int i=0; i<array.Length; i++)
            {
                f(array[i]);
            } 

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericArray<int> array = new GenericArray<int>(5);
            for (int i = 0; i < array.length();i++)
            {
                array.setItem(i, i);
            }
            array.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            int max = int.MinValue;
            array.ForEach(x =>
            {
                if(max<x)
                    max = x;
            });
            Console.WriteLine("最大值：" + max);
            int min = int.MaxValue;
            array.ForEach(x =>
            {
                if (min> x)
                    min = x;
            });
            Console.WriteLine("最小值：" + min);
            int sum = 0;
            array.ForEach(x =>
            {
                sum += x;
            });
            Console.WriteLine("和：" + sum);
            Console.ReadKey();
        }
    }
}
