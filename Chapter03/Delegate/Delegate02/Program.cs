using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1급 함수(first class function)로서의 델리게이트 */

namespace Delegate02
{
    // 델리게이트 선언
    delegate void PrintStr(string s);

    class PrintString
    {
        public static void sendString(string str, PrintStr ps)
        {
            Console.WriteLine("public static void sendString(string str, PrintStr ps)");
            ps(str);
        }
    }

    class Program
    {
        static StreamWriter sw;

        // 콘솔 출력 메소드
        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The String is: {str}");
        }

        // 파일 출력 메소드
        public static void WriteToFile(string str)
        {
            sw = File.CreateText("MyLog.txt");
            sw.WriteLine($"The String is : {str}");
            sw.Flush();
            sw.Close();
        }

        static void Main(string[] args)
        {
            PrintStr ps1 = new PrintStr(WriteToScreen);
            PrintString.sendString("Hello World", ps1);

            PrintStr ps2 = new PrintStr(WriteToScreen);
            PrintString.sendString("Hello Delegate!!!", ps2);
        }
    }
}
