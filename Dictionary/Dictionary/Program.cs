using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*yaha karna h?
 */

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardictionary = new Dictionary<string, double>();
            cardictionary.Add("Ford",2010.0);
            cardictionary.Add("GMC", 2009.0);
            cardictionary.Add("Audi", 2011.0);
            cardictionary.Add("Camry", 2007.0);
            var cars = cardictionary.Keys;
            
            Console.WriteLine("Number of Keys are: " + cars.Count); 
            foreach (var car in cars)
            {
                Console.WriteLine("Elements in Car Dictionary : " + cardictionary[car]);  
            }
            string[] carsarray = cars.ToArray();
            Array.Sort(carsarray);

            foreach (var car in carsarray)
            {
                Console.WriteLine("Elements in Car Dictionary : " + cardictionary[car]);
            }
            Console.ReadKey();
        }
    }
}
