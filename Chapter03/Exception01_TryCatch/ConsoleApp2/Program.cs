using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                    arr[i] = i;

                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }            
        }
    }
}
