using System;
using System.Collections.Generic;

namespace Csharp
{
    public class TestCsharp
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("a");
            list1.Add("dammio");
            list1.Add("b");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}