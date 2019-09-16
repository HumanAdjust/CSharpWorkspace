using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_ThisConstructor
{
    class Class1
    {
        int a, b, c;
        public Class1()
        {
            a = 1;
            Console.WriteLine($"Class1() 생성자 호출");
        }

        public Class1(int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"Class1({b}) 생성자 호출");
        }

        public Class1(int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine($"Class1(int {b}, int {c}) 생성자 호출");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}
