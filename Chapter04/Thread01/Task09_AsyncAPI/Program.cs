using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 파일을 복사하고, 파일의 크기를 반환한다.
namespace Task09_AsyncAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\파일 관리자\github\C#Workspace\Chapter04\Thread01\Task09_AsyncAPI";

            // 파일 생성 및 텍스트 기록
            CreateFile(path + @"\source.txt");

            #region 동기식 파일 복제
            // 1. StreamReader 사용
            Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target1.txt"));
            #endregion

            #region 비동기식 파일 복제
            // 1. StreamReader 사용
            Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target1.txt"));
            #endregion

            Console.WriteLine("메인 스레드 종료");
        }

        private static int CopySync(string fromPath, string toPath)
        {
            using (StreamReader sr = new StreamReader(fromPath))
            {
                using (StreamWriter sw = new StreamWriter(toPath))
                {
                    string line;
                    line = sr.ReadToEnd();
                    sw.Write(line);
                    return line.Length;
                }
            }
        }

        private static void CreateFile(string path)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.Write("Hello World");
            }
        }
    }
}
