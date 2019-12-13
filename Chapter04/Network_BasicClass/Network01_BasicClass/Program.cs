using System;
using System.Net;

namespace Network01_BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. IPAddress 클래스: ip주소 <-> long형 값 변환
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            Console.WriteLine($"ipAddress.Address: {ipAddress.Address}");
            Console.WriteLine($"ipAddress.ToString(): {ipAddress.ToString()}");

            // 2. DNS 클래스
            Console.WriteLine($"ipAddress.ToString() : {Dns.GetHostName()}");
            IPAddress[] ipAdds = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var ip in ipAdds)
            {
                Console.WriteLine(ip);  // 0번은 IPv6, 1번은 IPv4
            }

            IPAddress[] ipAdds2 = Dns.GetHostAddresses("www.naver.com");
            foreach (var ip in ipAdds2)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine();

            // 3. IPHostEntry : 인터넷 호스트 주소 정보에 대한 컨테이너 클래스
            IPHostEntry naverIPHostEntry = Dns.GetHostEntry("www.naver.com");
            foreach (var ip in naverIPHostEntry.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine($"naverIPHostEntry.HostName : {naverIPHostEntry.HostName}");

            IPHostEntry myIPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in myIPHostEntry.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.WriteLine($"myIPHostEntry.HostName : {myIPHostEntry.HostName}");

            // 4. IPEndPoint : 목적지 ip주소, 포트번호 저장
            IPAddress ipAdd = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAdd, 3000);
            Console.WriteLine($"ipEndPoint.Address : {ipEndPoint.Address}");
            Console.WriteLine($"ipEndPoint.Port : {ipEndPoint.Port}");
            Console.WriteLine($"ipEndPoint.ToString() : {ipEndPoint.ToString()}");
        }
    }
}
