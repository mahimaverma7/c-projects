using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_implementation
{
    class Box
    {
        public double length;
        public double breadth;
        public double height; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Double vol = 0.0;

            box1.length = 10.0;
            box1.breadth = 20.0;
            box1.height = 30.0;

            vol = box1.length * box1.breadth * box1.height;
            Console.WriteLine("Volume for Box1 : " + vol  );

            box2.length = 3.0;
            box2.breadth = 4.0;
            box2.height = 2.0;

            vol = box2.length * box2.breadth * box2.height;
            Console.WriteLine("Volume for Box2 : " + vol);
            Console.ReadLine();

        }
    }
}
