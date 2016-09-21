using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrom_string
{
    class Program
    {
        static void Main(string[] args)
        {
            String str, reverse = "";
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i-- )
            {
                reverse += str[i].ToString();
            }
            if (str == reverse)
            {
                Console.WriteLine("It is a Palindrom");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("It is not a Palindrom");
                Console.ReadKey();
            }
        }
    }
}
