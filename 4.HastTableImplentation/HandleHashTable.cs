using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.HastTableImplentation
{
    class HandleHashTable
    {
        static void Main(string[] args)
        {
            OurHashTable<string, int> test = new OurHashTable<string, int>();
            test.Add("gosho", 5);
            test.Add("pesho", 10);
            test.Add("Sasho", 15);
            Console.WriteLine(test.Find("pesho"));
            Console.WriteLine(test["gosho"]);
        }
    }
}
