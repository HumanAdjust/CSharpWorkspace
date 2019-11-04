using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate09_AnonymousMethod
{
    delegate int Compare(int a, int b); // 두 값을 비교하여 정수 반환(-1, 0, 1)

    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;


        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i, j, temp;
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

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.WriteLine($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array1 = { 25, 23, 12, 9, 7 };
            Console.Write("초기 상태: ");
            PrintArray(array1);
            BubbleSort(array1, new Compare(delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a == b) return 0;
                else return -1;
            }));

            int[] array2 = { 25, 23, 12, 9, 7 };
            Console.Write("초기 상태: ");
            PrintArray(array2);
            BubbleSort(array2, new Compare(delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a == b) return 0;
                else return -1;
            }));
        }
    }
}
