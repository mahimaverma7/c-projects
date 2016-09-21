using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindrom_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb, a , remainder, reverse = 0;
            Console.WriteLine("Enter number to be checked : ");
           numb = int.Parse(Console.ReadLine());
           a = numb;
           while (numb > 0)
           {
               remainder = numb % 10;
               reverse = reverse * 10 + remainder;
               numb = numb / 10;
           }

           if (reverse == a)
           {
               Console.WriteLine("Number is Palindrom");
               Console.ReadKey();
           }
           else
           {
               Console.WriteLine("Number is not a Palindrom");
               Console.ReadKey();
           }
        }
    }
}
