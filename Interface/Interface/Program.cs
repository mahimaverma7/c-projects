using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public interface Bank
    {
       void showTransaction();
       double showAmount();
       string showName();


    }
    public class Details : Bank
    {
      
        private string code = " ";
          private string name = " ";
          private string date = " ";
          private double amount = 0.0;

       /// <summary>
       /// 
       /// </summary>
       /// <param name="c"> This parameter is for code</param>
       /// <param name="n">This parameter is for customer name</param>
       /// <param name="d">This parameter is for date of transaction</param>
       /// <param name="a">This parameter is for amount to deposit</param>
        public Details(string c, string n, string d, double a)
        {
            code = c;
            name = n;
            date = d;
            amount = a;
        }

        public double showAmount()
        {
            return amount;
        }
        public string showName()
        {
            return name;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction Code is" + code);
            Console.WriteLine("Transaction Name is" + showName());
            Console.WriteLine("Transaction Date is" + date);
            Console.WriteLine("Transaction Amount is" + showAmount());
        }

    

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Details detail1 = new Details("0001", "John", "9/16/2016", 2000.00);
            Details detail2 = new Details("0002", "Kenny", "9/16/2016", 3000.0);
            detail1.showTransaction();
            detail2.showTransaction();
            Console.ReadLine();
           


        }
    }
}
