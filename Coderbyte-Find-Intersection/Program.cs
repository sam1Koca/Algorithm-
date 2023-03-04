using System;
using System.Collections.Generic;
using System.Linq;


namespace Coderbyte_Find_Intersection
{
    class Program
    {
        static void Main()
        {
            // keep this function call here
            Console.WriteLine(FindIntersection(Console.ReadLine()));
        }

        public static string FindIntersection(string[] strArr)
        {
            // code goes here
            List<int> results = new List<int>();

            int[] arrayOne = strArr[0].Split(",").Select(x => int.Parse(x)).ToArray();
            int[] arrayTwo = strArr[1].Split(",").Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayTwo.Contains(arrayOne[i]))
                {
                    results.Add(arrayOne[i]);
                }
            }
            return string.Join("," , results.ToArray());
        }
    }
}
