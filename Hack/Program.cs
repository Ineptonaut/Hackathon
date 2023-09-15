using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Decrypt or encrypt? 1/2");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                decrypt();
            }
            else if (input == 2)
            {
                encrypt();
            }
        }

        public static void decrypt()
        {

        }

        public static void encrypt() 
        {

        }
    }
}
