using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3.CountWordsFromText
{
    class FileReader
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("windows-1251"));
                using (reader)
                {
                    CountTheWords(reader);
                }
            }
            catch (FileNotFoundException)
            {

                throw new FileNotFoundException("The file wasn't found");
            }
            

        }

        private static void CountTheWords(StreamReader reader)
        {
            char[] separator = { ' '};
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            string text = reader.ReadToEnd();
            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string currentWord = word.ToLower();
                if (pairs.ContainsKey(currentWord))
                {
                    pairs[currentWord]++;
                }
                else
                {
                    pairs.Add(currentWord, 1);
                }
            }

            pairs = SortTheDictionaryByValue(pairs);
            PrintTheResults(pairs);
        }

        private static Dictionary<string, int> SortTheDictionaryByValue(Dictionary<string, int> pairs)
        {
            Dictionary<string, int> sortedDictionary = (from entry in pairs
                                                        orderby entry.Value ascending
                                                        select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
            return sortedDictionary;
        }

        private static void PrintTheResults(Dictionary<string, int> pairs)
        {
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair.Key + "------> " + pair.Value);
            }
        }
    }
}
