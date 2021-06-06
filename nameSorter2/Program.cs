using System;
using System.Collections.Generic;
using System.IO;

namespace nameSorter2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("Error: Name sorter requires exactly 1 argument [file to be sorted]");
            } else
            {
                try
                {
                    Console.WriteLine("Sorting names in file \"" + args[0] + "\":");
                    List<string> names = new(File.ReadAllLines(args[0]));
                    Utils.NameSort(names);
                    File.WriteAllLines(System.IO.Directory.GetCurrentDirectory() + 
                        "\\sorted-names-list.txt", names.ToArray());
                    foreach(string name in names)
                    {
                        Console.WriteLine(name);
                    }
                } catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
