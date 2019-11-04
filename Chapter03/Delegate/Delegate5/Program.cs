using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate05_Generic
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i, j;
            T temp;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[i + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        private static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array1 = { 25, 23, 12, 9, 7 };
            Console.Write("초기 상태: ");
            PrintArray(array1);
            BubbleSort<int>(array1, new Compare<int>(AscendCompare));

            double[] array2 = { 2.5, 2.3, 1.2, 0.9, 0.7 };
            Console.Write("초기 상태: ");
            PrintArray(array2);
            BubbleSort<double>(array2, new Compare<double>(DescendCompare));
        }
    }
}
