using System;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            if(System.DateTime.Now.Hour > 12)
            {
                Console.WriteLine("현재 오후 " + System.DateTime.Now.Hour + "시 입니다.");
            } else
            {
                Console.WriteLine("현재 오전 " + System.DateTime.Now.Hour + "시 입니다");
            }
        }
    }
}
