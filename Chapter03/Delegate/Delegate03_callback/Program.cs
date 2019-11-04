using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate03_callback
{
    delegate void CalcDelegateType(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            void Add(int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }

            void Subtract(int a, int b)
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }

            void Multiply(int a, int b)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }

            void Divide(int a, int b)
            {
                Console.WriteLine($"{a} ÷ {b} = {a / b}");
            }

            CalcDelegateType calcFunc;
            calcFunc = Add;
            Arithmetic(3, 4, calcFunc);

            calcFunc = Subtract;
            Arithmetic(3, 4, calcFunc);

            calcFunc = Add;
            calcFunc += Subtract;
            calcFunc += Multiply;
            calcFunc += Divide;
            Arithmetic(5, 7, calcFunc);
        }

        static void Arithmetic(int a, int b, CalcDelegateType calcFunc)
        {
            calcFunc(a, b);
            Console.WriteLine();
        }
    }
}
