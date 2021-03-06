﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10
{
    class Program
    {
        private static object SumDoubleOnly(params object[] intArr)
        {
            double sum = 0;

            for (int i = 0; i < intArr.Length; i++) {
                if (intArr[i] is double) // 같은 클래스 타입이면 true
                {
                    sum += (double)intArr[i];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
        }
    }
}
