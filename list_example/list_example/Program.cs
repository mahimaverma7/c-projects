using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var carlist = new List<string>();
            carlist.Add("Ford");
            carlist.Add("GMC");
            carlist.Add("Camry");
            carlist.Add("Audi");

            carlist.Sort();
            foreach(var car in carlist)
            {
                Console.WriteLine(car);

            }
            finditem(carlist);
            Console.ReadKey();


            

        }

        static void finditem(List<string> cars)
        {
            string findword = cars.Contains("Honda", StringComparer.OrdinalIgnoreCase) ? "String Matches" : "String doesn't Match";
            Console.WriteLine(findword);
        }
    }
}
