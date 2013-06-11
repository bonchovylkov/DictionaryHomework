using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ExtractOddNumberApperances
{
    class ExtractOdd
    {
        static void Main(string[] args)
        { 
            string[] words ={"C#", "SQL", "PHP", "PHP", "SQL", "SQL","HTML","CSS","Sass","Sass" } ;
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (pairs.ContainsKey(words[i]))
                {
                    pairs[words[i]]++;
                }
                else
                {
                    pairs.Add(words[i], 1);
                }
            }

            foreach (var pair in pairs)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key + "---> " +pair.Value );
                }
            }
        }
    }
}
