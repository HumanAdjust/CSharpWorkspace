using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2개의 실수를 입력하세요.");
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            double i = Convert.ToDouble(a);
            double j = Convert.ToDouble(b);
            double sum = i + j;

            Console.WriteLine("{0} + {1} = {2}", i, j, sum);
        }
    }
}
