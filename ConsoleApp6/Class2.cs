using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Class2
    {
       

            static void Main()
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();
                string result = new string(input.Distinct().ToArray());
                Console.WriteLine("String with duplicates removed: " + result);
                Console.ReadLine();
            }
    }

}
