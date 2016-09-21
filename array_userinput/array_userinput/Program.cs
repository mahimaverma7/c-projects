using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array_userinput
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} element",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("you entered {0}", array[i]);
            }
            Console.ReadLine();
        }
    }
}
