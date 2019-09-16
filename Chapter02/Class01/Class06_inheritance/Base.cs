using System;
using System.Collections.Generic;
using System.Text;

namespace Class06_inheritance
{
    class Base
    {
        public Base() //ctor tap tap
        {
            Console.WriteLine("Base()");
        }

        ~Base()
        {
            Console.WriteLine("~Base()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
        }

        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
    }
}
