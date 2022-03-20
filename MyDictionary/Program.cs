using System;
using System.Collections.Generic;
using MyDictionary;

namespace IDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> persons1 = new Dictionary<int, string>();
            persons1.Add(18, "Melek");
            persons1.Add(23, "Tunahan");
            Console.WriteLine(persons1.Count);

            MyDictionary<int, string> persons2 = new MyDictionary<int, string>();
            persons1.Add(26, "Aybüke");
            persons2.Add(30, "Deniz");
            Console.WriteLine(persons2.Count);


        }
    }
}
