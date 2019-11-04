using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03_PrimeNumber
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if(number == 2)
            {
                return true;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            // 소수를 판별할 범위
            long startNum = 2, endNum = 10000;
            int taskCount = 4;

            Func<object, List<long>> FindPrimeFunc = (objRange) =>
            {
                long[] range = (long[])objRange;
                List<long> found = new List<long>();  // 찾은 소수를 저장할 리스트

                for (long i = range[0]; i < range[1]; i++)
                {
                    if (IsPrime(i))
                        found.Add(i);
                }
                return found;
            };

            //Task 배열
            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];

            //Task별 작업 숫자 버위 지정
            long currentStartNum = startNum;  // 2
            long currentEndNum = endNum / taskCount;  // 10000 / 4

            // 두 번째 Task부터 마지막 Task까지 숫자 범위 지정
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"Task[{i}] : {currentStartNum} ~ {currentEndNum}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentStartNum, currentEndNum });

                currentStartNum = currentEndNum + 1;
                currentEndNum = currentEndNum + (endNum / taskCount);
            }

            Console.WriteLine("Started...");
            DateTime startTime = DateTime.Now;

            // Task 모두 실행
            foreach(var task in tasks)
            {
                task.Start();
            }

            List<long> totalList = new List<long>();

            // 모든 작업이 종료되면 totalList로 합친다.
            foreach (var task in tasks)
            {
                task.Wait();  // 모든 작업이 끝날 때 까지 기다림.
                totalList.AddRange(task.Result); // 리스트에 리스트를 합치는 작업
            }
            DateTime endTime = DateTime.Now;
            TimeSpan elapsed = endTime - startTime; //
            Console.WriteLine($"{startNum} ~ {endNum} 소수 개수 = {totalList.Count}");
            Console.WriteLine($"실행 시간: {elapsed}");

        }
    }
}
