using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Inheritance
{
    public class Details
    {
        protected double principal;
        protected double rate;
        protected int time;
        /// <summary>
        /// Entering details
         /// </summary>
        /// <param name="p">Enter Principal Amount</param>
        public void getprincipal(double p)
        {
            principal = p;
        }

        public void getrate(double r)
        {
            rate= r ;
        }
        public void gettime(int t)
        {
            time = t;
        }
        public void Display()
        {
            Console.WriteLine("Principal is : " + principal);
            Console.WriteLine("Rate is : " + rate);
            Console.WriteLine("Time is : " + time);
        }


    }

    public class Intrest : Details
    {
       
        public double IntrestCal()
        {
           return (principal * rate * time) / 100;
   
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Intrest intr = new Intrest();
            intr.getprincipal(5000.0);
            intr.getrate(2.0);
            intr.gettime(2);
            intr.Display();

            Console.WriteLine("Total Intrest will be : " + intr.IntrestCal() );
            Console.ReadLine();


        }
    }
}
