using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Hack
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var input = 0;
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
            var temp = input.SplitInParts(3);
            foreach (string item in temp)
            {
                temp.Append(item);
            }
            //translate ascii codes into plaintext
            string output = "";
            foreach (var item in temp)
            {
                var result = char.ConvertFromUtf32(int.Parse(item));
                output += result;
            }
            //reassemble string 
            Console.WriteLine(output);
        }

        public static void encrypt() 
        {
            string input = "";
            Console.WriteLine("Enter input string");
            input = Console.ReadLine();
            byte[] bytes = Encoding.ASCII.GetBytes (input);
            string output = "";
            foreach (byte item in bytes)
            {
                output += item.ToString();
            }
            Console.WriteLine(output);
        }

        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }
}
