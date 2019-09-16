using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요.");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            string result = (num % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}
