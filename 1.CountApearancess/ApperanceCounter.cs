using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.CountApearancess
{
    class ApperanceCounter
    {
        static void Main(string[] args)
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> appearances = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (appearances.ContainsKey(numbers[i]))
                {
                    appearances[numbers[i]]++;
                }
                else
                {
                    appearances.Add(numbers[i], 1);
                }
            }

            foreach (var pair in appearances)
            {
                Console.WriteLine("The key "+ pair.Key +" appears ----> " + pair.Value + " times!");
            }
        }
    }
}
