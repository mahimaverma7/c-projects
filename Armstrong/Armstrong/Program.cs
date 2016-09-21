using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, remainder, sum = 0;
            Console.WriteLine("Enter the number to check : ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                remainder = num%10;
                sum = sum + remainder*remainder*remainder;
                num = num/10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Its Armstrong");
         
            }
            else
            {
                Console.WriteLine("Its not Armstrong");
                Console.ReadKey();
            }


        }
    }
}
