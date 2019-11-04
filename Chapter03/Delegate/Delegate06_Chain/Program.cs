using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate06_Chain
{
    class Program
    {
        // 1. 델리게이트 선언
        delegate void ThereIsAFire(string location);

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? {location}에 불이 났어요!!!");
        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"피하세요! {location}에 불이 났어요!!!");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나갑시다!!!");
        }

        static void Main(string[] args)
        {
            // 2. 델리게이트 인스턴스 생성 + 3. 인스턴스에 메소드를 연결
            ThereIsAFire fire = new ThereIsAFire(Call119);
            fire += ShotOut;
            fire += Escape;

            // 4. 델리게이트 실행
            fire("송정동");

            ThereIsAFire fire2 = new ThereIsAFire(Call119) + new ThereIsAFire(ShotOut) + new ThereIsAFire(Escape);
            fire2("");
        }
    }
}
