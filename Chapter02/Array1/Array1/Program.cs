using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //방법1 : 코드를 읽기 좋음
            string[] array1 = new string[3] {"안녕", "Hello", "World"};
            foreach(string s in array1)
                Console.WriteLine($"{s} ");
            Console.WriteLine('\n');

            //방법2: 코드가 짧음, 동적으로 저장 가능
            string[] array2 = new string[] { "안녕", "Hello", "World" };
            foreach (string s in array2)
                Console.WriteLine($"{s} ");
            Console.WriteLine('\n');

            //방법3: 코드가 매우 짧음, 동적으로 저장 가능
            string[] array3 = { "안녕", "Hello", "World" };
            foreach (string s in array3)
                Console.WriteLine($"{s} ");
            Console.WriteLine('\n');

            Console.WriteLine(array1.GetType());
            Console.WriteLine(array1.GetType().BaseType);
        }
    }
}
