﻿using System;
using System.Threading;
namespace Csharp
{
    public class TestCsharp
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Bat dau Thread con!!!");
            // Thread nay dung khoang 5000 milisecond 
            int sleepfor = 5000;
            Console.WriteLine("Thread con dung trong khoang {0} giay",
         sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Thread con phuc hoi!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa quan ly Thread");
            Console.WriteLine("---------------------------");
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Trong Main Thread: tao Thread con.");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
