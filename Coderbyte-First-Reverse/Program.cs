using System;
using System.Linq;

namespace Coderbyte_First_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }

        public static string FirstReverse(string str)
        {
           // code goes here

           string reverseText = "";
           for (int i = str.Length - 1; i>=0 ; i--)
           {
                reverseText += str[i];
           }
           return reverseText;
        }

        // sayitsamikoca - Happy coding :)
    }
}
