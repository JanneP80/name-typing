using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_typing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type your firstname: ");
            string strFirstName = Console.ReadLine();

            Console.WriteLine("type your lastname: ");
            string strLastName = Console.ReadLine();

            //Console.WriteLine("Your name is " + strName);
            Console.WriteLine("Your name is {0} and lastname {1}", strFirstName, strLastName);
            Console.ReadKey();
        }
    }
}
