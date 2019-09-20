﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherExam09
{
    class Computer
    {
        public string name;
        public bool powerOn;

        public Computer(string name)
        {

        }

        public void Boot()
        {
            Console.WriteLine("부팅합니다");
        }

        public void Shutdown()
        {
            Console.WriteLine("전원을 종료합니다");
        }

        public void Reset()
        {
            Console.WriteLine("재부팅합니다");
        }
    }

    class Notebook : Computer
    {
        private static int touchpadSize;

        public static int GettouchpadSize()
        {
            Console.WriteLine($"터치패드 사이즈: {touchpadSize}");
            return touchpadSize;
        }

        public Notebook(string name, int touchpadSize) : base(name)
        {
            
        }

        public void useTouchpad()
        {
            Console.WriteLine("터치패드를 사용함");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("오디세이", 25);
            Notebook.GettouchpadSize();
            notebook1.Boot();
            notebook1.useTouchpad();
            notebook1.Reset();
            notebook1.Shutdown();
        }
    }
}
