using System;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자 하나를 입력해주세요!");
            int input = Console.Read();

            if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
            {
                Console.WriteLine("알파벳 입니다");
            }
            else
            {
                Console.WriteLine("알파벳이 아닙니다");
            }

        }
    }
}
