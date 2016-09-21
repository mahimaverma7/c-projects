using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace swapnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2, temp;
            Console.WriteLine("Enter first number");
            numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            numb2 = int.Parse(Console.ReadLine());
            temp = numb1;
            numb1 = numb2;
            numb2 = temp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("First number" + numb1);
            Console.WriteLine("Second number" +numb2);
            Console.ReadKey();

        }
    }
}
