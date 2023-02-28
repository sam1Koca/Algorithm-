using System;

namespace Coderbyte_First_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(FirstFactorial(Console.ReadLine()));
        }

        static int FirstFactorial(int num)
        {
            // code goes here

            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
