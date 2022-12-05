using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> Evens = new List<int>();
            List<int> Odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < array.Length; i++)
            {
             if (array[i] % 2 == 0) 
                {
                    Evens.Add(array[i]);
                }
                else
                {
                    Odds.Add(array[i]);
                }
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("-------^------");
            Console.WriteLine("Evens List");
            Console.WriteLine();

            foreach (int item in Evens) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("------v------");
            Console.WriteLine("Odds List");
            Console.WriteLine();

            foreach (int item in Odds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
