using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
        //This is test commit
            Console.WriteLine("Even numbers:");
            for (int i = 0; i <=20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        Console.WriteLine( "end");
            Console.ReadLine();
        }
    }


   
