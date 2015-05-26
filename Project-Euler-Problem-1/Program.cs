/*
 *   Project Euler: Problem 1
 *   Alex Curran 
 *   
 *   Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (checkMultiple(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all the multiple of 3 or 5 below 1000 is {0}", sum);
        }

        /// <summary>
        /// Determines if a number is a multiple of 3 or 5
        /// </summary>
        /// <param name="number"> The number to be tested </param>
        /// <returns> True: if the number is a multiple of 3 or 5
        ///           Fales: If the number is not a multiple of 3 or 5
        /// </returns>
        private static bool checkMultiple(int number)
        {
            if (((number % 3) == 0) || ((number % 5) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
