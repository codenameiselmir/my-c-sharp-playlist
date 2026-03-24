/*
===========================================================
Lesson 14 - Logical Operators
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _14._Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What are Logical Operators?
            // ==========================================================
            /*
             Logical operators are used to combine
             multiple conditions in decision making.

             They return true or false.
            */

            // ==========================================================
            // 2. && (AND)
            // ==========================================================
            /*
             The AND operator returns true
             only if both conditions are true.

             Example:
             condition1 && condition2
            */

            // ==========================================================
            // 3. || (OR)
            // ==========================================================
            /*
             The OR operator returns true
             if at least one condition is true.

             Example:
             condition1 || condition2
            */

            // ==========================================================
            // 4. ! (NOT)
            // ==========================================================
            /*
             The NOT operator reverses a condition.

             If something is true,
             ! makes it false.

             If something is false,
             ! makes it true.
            */

            // ==========================================================
            // 5. Asking the User for Input
            // ==========================================================
            /*
             In this example, we ask the user
             to enter the outside temperature.

             Then we use logical operators
             to check different situations.
            */

            Console.Write("What's the temperature outside? ");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // ==========================================================
            // 6. AND Example
            // ==========================================================
            /*
             Here we check if the temperature
             is between 10 and 25.

             Both conditions must be true.
            */

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It is warm actually!");
            }

            // ==========================================================
            // 7. OR Example
            // ==========================================================
            /*
             Here we check if the temperature
             is extremely high or extremely low.

             Only one condition needs to be true.
            */

            else if (temp >= 50 || temp <= -50)
            {
                Console.WriteLine("Something weird!");
            }

            // ==========================================================
            // 8. NOT Example
            // ==========================================================
            /*
             Here we use a boolean variable
             with the NOT operator.

             If isRaining is false,
             !isRaining becomes true.
            */

            bool isRaining = false;

            if (!isRaining)
            {
                Console.WriteLine("You don't need an umbrella.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}