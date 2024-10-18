using System;
using System.Threading;
namespace Csharp
{
    public class TestCsharp
    {
        public static void Main()
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa Main Thread");
            Console.WriteLine("--------------------------");
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("Day la {0}", th.Name);
            Console.ReadKey();
        }
    }
}