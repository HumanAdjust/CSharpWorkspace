using System;
using System.Collections.Generic;
using System.Text;

namespace Class02_Static
{
    class Actor
    {
        //인스턴스 필드
        public string name;
        public int CountOfInstance;

        //정적 필드
        public static int staticCountOfInstance;

        //인스턴스 메소드
        public void SetName(string name)
        {
            this.name = name;
        }

        public static int GetCount()
        {
            return staticCountOfInstance;
        }

        public Actor(string name)
        {
            this.name = name;
            CountOfInstance++;
            staticCountOfInstance++;
            Console.WriteLine($"{name} 객체 생성");
        }
    }
}
