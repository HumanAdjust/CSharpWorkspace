using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* 656p 예제 */
// async 한정자 : 비동기임을 나타내는 한정자
// await 연산자 : 비동기 코드
// async 한정자를 사용하는 메소드는 반환형식이 void, Task, Task<TResult>여야 함.
namespace Task05_AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");

            Console.ReadLine();
        }

        async private static void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i < count; i++)
                {
                    Console.WriteLine($"{i}/{count}");
                    //Thread.Sleep(100);
                    await Task.Delay(100);
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }
    }
}
