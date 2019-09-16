using System;

/*
 * 문자열 ↔ 숫자 변환
 */

namespace DataType03
{
    class Program
    {
        static void Main(string[] args)
        {
            String strNum = "12345";
            int num = int.Parse(strNum);

            strNum = 12345.ToString();

            string input = Console.ReadLine();
            Console.WriteLine(input.GetType());
            int i = Convert.ToInt32(input);
            Console.WriteLine(i.GetType());
        }
    }
}
