using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please Enter the Point x-co-ordinate ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Point y-co-ordinate ");
            y = int.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origin");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine("first quadrant");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("second quadrant");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("third quadrant");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("fourth quadrant");
            }

        }
    }
}
