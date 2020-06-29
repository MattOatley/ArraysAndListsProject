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
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Create two Lists of type int.

            //* Name one List "evens"
            //* Name the other List "odds"


            var evens = new List<int>();
            var odds = new List<int>();

            for (int i = 2; i < 100; i += 2)
            {
                evens.Add(i);
            }

            foreach (var eve in evens)
            {
                Console.WriteLine($"Here are all the even numbers! {eve}");
            }

            for (int i = 5; i < 100; i += 2)
            {
                odds.Add(i);
            }

            foreach (var odd in odds)
            {
                Console.WriteLine($"Here are all the odd numbers! {odd}");
            }


            ///* Using either a foreach or for loop,
            // * nest an if statement to check to see
            // *  if a number is even or odd.
            // * Then add those numbers to either the evens List
            // * or the odds List
             

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
