using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace struct_and_class
{

    public class ClassCor
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public struct StructCor
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public static class Program
    {
        public static void Main()
        {
    
            var pointref = new ClassCor{ a = 5, b = 10 };

            var ClassCor1 = pointref;
            ClassCor1.a = 0;

            
            Console.WriteLine("Original ClassCor is [{0},{1}]", pointref.a, pointref.b);

            var pointval = new StructCor{ a = 5, b = 10 };

            var StructCor1 = pointval;

            
            StructCor1.a = 0;


            Console.WriteLine("Original StructCor is [{0},{1}]", pointval.a, pointval.b);
            Console.ReadLine();
        }
    }

}