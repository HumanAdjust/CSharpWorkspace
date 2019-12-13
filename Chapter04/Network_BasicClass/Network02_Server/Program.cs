using System;
using System.IO;
using System.Net.Sockets;

namespace Network02_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서버");

            TcpListener tcpListener = new TcpListener(3000);
            tcpListener.Start();  // 수신 대기 시작
            TcpClient tcpClient = tcpListener.AcceptTcpClient();  // 클라이언트의 요청 무한 대기
            Console.WriteLine($"클라이언트 연결: {tcpClient.Client.RemoteEndPoint}");

            using (NetworkStream ns = tcpClient.GetStream())  // 데이터 송수신 스트림
            {
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    sw.AutoFlush = true;  // 버퍼가 차지 않아도 보내라
                    string str = "";
                    while ((str = Console.ReadLine()) != "exit")
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            Console.WriteLine("서버 종료");
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}
