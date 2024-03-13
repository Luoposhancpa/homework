using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory

{
    public interface Shape
    {
        //计算图形面积
        double area();
        //判断图形是否合法
        bool isLegal();
    }
    public class Rectangle : Shape
    {
        //矩形长宽
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double area()
        {
            //图形不合法，面积返回-1；
            if (!isLegal()) return -1;
            return length * width;
        }

        public bool isLegal()
        {
            return (length > 0) && (width > 0);

        }
    }
    //正方形就是特殊矩形
    public class Square : Rectangle
    {
        public Square(double length) : base(length, length)
        {


        }
    }
    public class Triangle : Shape
    {
        //三角形三条边
        double[] length;
        public Triangle(double x, double y, double z)
        {
            length = new double[3] { x, y, z };
        }
        public double area()
        {
            //图形不合法，面积返回-1；
            if (!isLegal()) return -1;
            double p = (length[0] + length[1] + length[2]) / 2;
            //海伦公式
            return Math.Sqrt(p * (p - length[0]) * (p - length[1]) * (p - length[2]));
        }

        public bool isLegal()
        {
            return (length[0] + length[1] > length[2]) && (length[0] + length[2] > length[1]) && (length[1] + length[2] > length[0]);
        }
    }
    class ShapeFactory
    {
        private ShapeFactory()
        {

        }
        public static Shape createShape(int num)
        {
           
            switch(num)
            {
                case 0:
                    return new Rectangle(4, 6);
                case 1:
                    return new Square(5);
                case 2:
                    return new Triangle(3,4,5);
                default:
                    return new Rectangle(4, 6);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            double totalArea = 0;
           for(int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                int num = rand.Next(0, 2);
                totalArea += ShapeFactory.createShape(num).area();
            }
           Console.WriteLine(totalArea);
            Console.ReadKey();
        }
    }
}
