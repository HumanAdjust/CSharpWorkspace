using System;

/*
 * 참조에 의한 매개변수전달 : in, ref, out 
 */

namespace Method02
{
    class Program
    {
        static void UseParams(params int[] intArr)
        {
            for (int p = 0; p < intArr.Length; p++)
            {
                Console.Write(intArr[p] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            /***** params *****/
            int[] myintArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            UseParams(myintArray);
            UseParams(9, 8, 7, 6, 5, 4, 3, 2, 1);

            /****** in ******/
            int i = 44;
            InArgExample(i); // 44
            Console.WriteLine(i); // 44

            void InArgExample(in int InArg)
            {
                Console.WriteLine(InArg);
            }

            /***** ref : 참조에 의한 인수전달 *****/
            int r = 90;
            Console.WriteLine(r);  // 90
            RefArgExample(ref r);
            Console.WriteLine(r);  // 100

            void RefArgExample(ref int refArg)
            {
                refArg += 10;
            }

            int x = 100, y = 3, q = 0, d = 0;
            Divide(x, y, ref q, ref d);
            Console.WriteLine("몫: {0}, 나머지: {1}", q, d);

            void Divide(int a, int b, ref int quotient, ref int remainder)
            {
                quotient = a / b;
                remainder = a % b;
            }

            /***** out : 참조에 의한 인수 전달 *****/
            int outVar;
            OutArgExample(out outVar);
            Console.WriteLine(outVar);

            void OutArgExample(out int outArg)
            {
                outArg = 999;
            }

            string s = "1234";
            if(int.TryParse(s, out int result))
            {
                Console.WriteLine("result : {0}", result);
            }
            Console.WriteLine("result : {0}", result);   //ref << out

            x = 100;
            y = 7;
            OutDivide(x, y, ref q, ref d);
            Console.WriteLine("몫: {0}, 나머지: {1}", q, d);

            void OutDivide(int a, int b, ref int quotient, ref int remainder)
            {
                quotient = a / b;
                remainder = a % b;
            }
        }
    }
}
