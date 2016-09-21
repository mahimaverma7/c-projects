using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printing_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] array = new int[10];

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table for {0} is : " , num);
            for (int i =0 ; i <= 10; i++)
            {
                array[i] = (i+1) * num;
                Console.WriteLine(array[i]);
            }
        }
    }
}
