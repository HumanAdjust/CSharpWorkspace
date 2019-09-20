using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExam11
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a, int b) : base(a, b) { }

        public override int area()
        {
            Console.Write("사각형의 넓이: ");
            return width * height;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a, int b) : base(a, b) { }
        public override int area()
        {
            Console.Write("삼각형의 넓이: ");
            return width * height / 2;
        }
    }

    class Program
    {
        public static void PrintArea(Shape shape)
        {
            Console.WriteLine(shape.area());
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            PrintArea(r);
            PrintArea(t);
        }
    }
}
