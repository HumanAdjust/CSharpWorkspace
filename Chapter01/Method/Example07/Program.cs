using System;

namespace Example07
{
    class Program
    {
        static void FibonacciLoop(int limit)
        {
            int f = 0;
            int s = 1;

            int r = 0;
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine("FibonacciLoop(" + i + ") : " + f);
                r = f + s;
                f = s;
                s = r;
                
            }
        }

        static int FibonacciRecursive(int limit)
        {
           if (limit == 1) return 0; // 1항 값
           else if (limit == 2) return 1; // 2항 값
           else return FibonacciRecursive(limit - 1) + FibonacciRecursive(limit - 2); //n항 값
        }

        static void Main(string[] args)
        {
            Console.WriteLine("반복문을 이용한 피보나치");
            Console.Write("출력할 피보나치 수를 입력하세요: ");
            string a = Console.ReadLine();
            FibonacciLoop(int.Parse(a));

            Console.WriteLine("재귀 함수를 이용한 피보나치");
            Console.Write("출력할 피보나치 수를 입력하세요: ");
            string b = Console.ReadLine();

            for (int i = 1; i <= int.Parse(b) + 1; i++)
            {
                Console.WriteLine("FibonacciRecursive(" + i + ") : " + FibonacciRecursive(i));
            }
        }
    }
}
