using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameSorter2
{
    public class Utils
    {
        public static List<string> NameSort(List<string> inputList)
        {
            inputList.Sort(LastNameComparer);
            return inputList;
        }
        private static int LastNameComparer(string nameX, string nameY)
        {
            return ExtractLastName(nameX).CompareTo(ExtractLastName(nameY));
        }

        private static string ExtractLastName(string fullName)
        {
            string[] allNames = fullName.Split(" ");
            string lastName = allNames[^1];
            return lastName;
        }
    }
}
