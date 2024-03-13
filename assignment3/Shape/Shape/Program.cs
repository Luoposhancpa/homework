using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape

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
        private double length ;
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
            return length*width;
        }

        public bool isLegal()
        {
            return (length > 0) && (width > 0);
            
        }
    }
    //正方形就是特殊矩形
    public class Square : Rectangle
    {
        public Square(double length):base(length,length) 
        {
           

        }
    }
    public class Triangle : Shape
    {
        //三角形三条边
        double []length;
        public Triangle(double x,double y, double z)
        {
            length=new double[3] { x,y,z};
        }
        public double area()
        {
            //图形不合法，面积返回-1；
            if (!isLegal())return -1;
            double p = (length[0] + length[1] + length[2])/2;
            //海伦公式
            return Math.Sqrt(p * (p - length[0]) * (p - length[1]) * (p - length[2]));
        }

        public bool isLegal()
        {
            return (length[0] + length[1] > length[2])&& (length[0] + length[2] > length[1])&& (length[1] + length[2] > length[0]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 2);
            Console.WriteLine("矩形面积"+rectangle.area());
            Square square = new Square(4);
            Console.WriteLine("正方形面积"+square.area());
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("三角形面积"+triangle.area());
            Console.ReadKey();
        }
    }
}
