﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* 매개변수가 있는 스레드 함수 호출 */
namespace Thread03_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스레드 실행에 하나의 매개변수 전달
            Thread t1 = new Thread(ThreadFunc1);
            t1.Start(5);

            // 스레드 실행에 데이터를 가진 객체를 매개변수로 전달
            NameCard nameCard = new NameCard() { Name = "아이유", Age = 28 };
            Thread t2 = new Thread(ThreadFunc2);
            t2.Start(nameCard);
        }

        private static void ThreadFunc2(object obj)
        {
            NameCard nc = obj as NameCard;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"ThreadFunc2 : {nc.Name}, {nc.Age}");
            }
        }

        private static void ThreadFunc1(object count)
        {
            for (int i = 0; i < (int)count; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"ThreadFunc1 : {i}");
            }
        }
    }
}
