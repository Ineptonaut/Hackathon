using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

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
            Console.ReadKey();
        }

        public static void decrypt()
        {
            //input string of numbers
            string input = "";
            Console.WriteLine("Enter input string: ");
            input = Console.ReadLine();
            //split string by each 3rd number
            string[] temp = input.Split();
            foreach (string item in temp)
            {
                temp.Append(item);
            }
            //translate ascii codes into plaintext
            string output = "";
            foreach (var item in temp)
            {
                var result = (char.ConvertFromUtf32(int.Parse(item)));
                output += result;
            }
            //reassemble string 
            Console.WriteLine(output);
        }

        public static void encrypt() 
        {

        }
    }
}
