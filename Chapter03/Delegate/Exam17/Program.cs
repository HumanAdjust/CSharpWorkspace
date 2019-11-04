using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam17
{
    delegate double AreaDelegate(double w, double h);

    class ShapeArea
    {
        public void PrintShapeArea(string name, double a, double b, AreaDelegate areaDelegate)
        {
            Console.WriteLine($"{name} 도형의 넓이 : {areaDelegate(a, b)}");
        }
    }

    class Program
    {
        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double TriangleArea(double a, double b)
        {
            return (a * b) / 2;
        }

        static void Main(string[] args)
        {
            ShapeArea ShowArea = new ShapeArea();
            ShowArea.PrintShapeArea("삼각형", 10, 10, TriangleArea);
            ShowArea.PrintShapeArea("사각형", 10, 10, RectangleArea);
        }
    }
}
