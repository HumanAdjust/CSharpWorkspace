using System;

namespace Exam08
{
    class Cube
    {
        public int x, y, z;
        public static int CountOfInstance;
        public int Volume;

        public void GetVolume()
        {
            Volume = x + y + z;
            Console.WriteLine("부피: {0}", Volume);
        }

        public static int GetCount()
        {
            return CountOfInstance;
        }

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            CountOfInstance++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube Cube1 = new Cube(4, 6, 7);
            Cube Cube2 = new Cube(3, 6, 9);
            Console.WriteLine($"생성된 객체 숫자: {Cube.GetCount()}");

            Cube1.GetVolume();
            Cube2.GetVolume();
        }
    }
}
