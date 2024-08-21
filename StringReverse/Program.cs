using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();

            string reversedString = ReverseString(input);

            Console.WriteLine("Reversed string: " + reversedString);
            Console.ReadLine();
        }

       public static string ReverseString(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
    

