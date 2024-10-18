using System;
using System.Threading;
namespace Csharp
{
    Public class TestCsharp
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Thread con bat dau!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa cach tao Thread");
            Console.WriteLine("---------------------------");
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Trong Main Thread: tao thread con.");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
