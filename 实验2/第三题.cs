using System;
using System.Collections.Generic;
namespace Test5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> g = new List<object>(100);
            Console.WriteLine("Temporary Capacity:{0}.", g.Capacity);
            for (int i = 0; i < 3; i++)
            {
                g.Add(Console.ReadLine());
                Console.WriteLine("Current units:{0}.", g.Count);
                foreach (object t in g)
                {
                    Console.WriteLine(t);
                }
            }
            Console.WriteLine("Clear all");
            g.Clear();
            Console.WriteLine("Current units:{0}.", g.Count);
        }
    }
}