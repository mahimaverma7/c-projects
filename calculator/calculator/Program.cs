using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, result;
                String operation;
            Console.WriteLine("Enter the first value : ");
            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation to be performed : + , - , * , / ");
            operation = Console.ReadLine();

            Console.WriteLine("Enter the second value : ");
            value2 = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case "-":
                    result = value1 - value2;
                    
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                default:
                    result = 0;
                    break;

            }

            Console.WriteLine(value1.ToString() + " " + operation.ToString() + " "+ value2.ToString() + "=" + result.ToString() );

            Console.ReadKey();
        }
    }
}
