using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;
namespace _6.PhoneFile
{
    class PhoneFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("phones.txt", Encoding.GetEncoding("windows-1251"));
            StreamReader commands = new StreamReader("commands.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                using (commands)
                {
                    char[] separator = { '|','\n', '\r'};
                    MultiDictionary<Tuple<string, string>, string> phonesFile = new MultiDictionary<Tuple<string, string>, string>(true);
                    string text = reader.ReadToEnd();

                    string[] parts = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    TrimTheParts(parts);
                    
                    for (int i = 0; i < parts.Length; i += 3)
                    {
                        phonesFile.Add(new Tuple<string, string>(parts[i], parts[i + 1]), parts[i + 2]);
                    }

                    Console.WriteLine("Only by name----------------------------");
                    var peopleByName = phonesFile.FindAll(key => key.Key.Item1 == "Moro");
                    foreach (var people in peopleByName)
                    {
                        Console.WriteLine(people);
                    }
                    Console.WriteLine("By name and town----------------------------");

                    var peopleByNameAndTown = phonesFile.FindAll(key => key.Key.Item1 == "Kireto" && key.Key.Item2 == "Varna");
                    foreach (var people  in peopleByNameAndTown)
                    {
                        Console.WriteLine(people);
                    }

                    Console.WriteLine("Only by name but diferent towns----------------------------");
                    var peopleByNameDifTowns = phonesFile.FindAll(key => key.Key.Item1 == "Kireto");
                    foreach (var people in peopleByNameDifTowns)
                    {
                        Console.WriteLine(people);
                    }
                }
             
            }


        }

        private static void TrimTheParts(string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
            }
        }
    }
}
