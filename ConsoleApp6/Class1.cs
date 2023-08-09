using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Class1
           
    {
        static void Main()
        {
          
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Result is:" + sum);
            Console.WriteLine("The end");
            Console.ReadLine();
        }
    }

}

