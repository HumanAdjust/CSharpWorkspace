using System;

namespace Example05
{
    class Program
    {
        
        static int SumAndAverage(int a, int b)
        {
            int sum = 0;
            float count = 0;

            for(int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }
            Console.WriteLine("Sum: " + sum + ", Avg: " + sum / count);

            return sum;
        }

        static void Main(string[] args)
        {
            int x = SumAndAverage(11, 66);
        }
    }
}
