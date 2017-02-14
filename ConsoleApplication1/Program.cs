using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type number: ");
            int iNro = int.Parse(Console.ReadLine()); // numbers are also characters, change to interger

            if (iNro < 0) // { } Lohkomerkintä on hyvää ohjelmointityyliä
            {
                Console.WriteLine("Number {0} is negative.", iNro);
            }
            else
            if (iNro > 0) // larger than zero
            {
                Console.WriteLine("Number {0} is positive.", iNro);
            }
            else
            if (iNro == 0) // is zero
            {
                Console.WriteLine("Number {0} is zero.", iNro);
            }
            else return;
            Console.ReadKey();

        }
    }
}
