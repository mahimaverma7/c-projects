using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_class
{

       abstract class ShapesClass
        {
            abstract public int Area();
        }
        class rectangle : ShapesClass
        {
              int side1 = 0;
              int side2 = 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="x">This is Length</param>
            /// <param name="y">This is Breadth</param>
                public rectangle(int x, int y)
                {
                     side1 = x;
                     side2 = y;
                 }
    
                 public override int Area()
                 {
                    return side1 * side2;
                    }
        }
    class Program
    {
        static void Main(string[] args)
        {
           rectangle rec = new rectangle(9,3);
           Console.WriteLine("Area of the Rectangle = {0}", rec.Area());
           Console.ReadLine();
        }
    }
}
