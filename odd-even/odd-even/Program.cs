using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("It is an even number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("It is an even number");
                Console.Read();
            }
        }
    }
}
