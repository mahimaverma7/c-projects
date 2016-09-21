using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multidim_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arraydesc = new string[3,3];
            arraydesc[0, 0] = "First Top";
            arraydesc[0, 1] = "Second Top";
            arraydesc[0, 2] = "Third Top";

            arraydesc[1, 0] = "First Middle";
            arraydesc[1, 1] = "Second Middle";
            arraydesc[1, 2] = "Third Middle";

            arraydesc[2, 0] = "First Bottom";
            arraydesc[2, 1] = "Second Bottom";
            arraydesc[2, 2] = "Third Bottom";

            for (int i = 0; i < 3;i++ )
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arraydesc[i,j] + "\t");
                    if((j+1)%3==0)
                    {
                        Console.WriteLine("");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
