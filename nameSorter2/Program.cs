using System;
using System.Collections.Generic;
using System.IO;

namespace nameSorter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting string in file \"" + args[0] + "\"");
            List<string> names = new(File.ReadAllLines(args[0]));
            Console.WriteLine("Original:");
            foreach (string line in names)
            {
                Console.WriteLine(line);
            }

            Utils.NameSort(names);
            Console.WriteLine("sorted:");
            foreach (string line in names)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines("sorted-names-list.txt", names.ToArray());
        }
    }
}
