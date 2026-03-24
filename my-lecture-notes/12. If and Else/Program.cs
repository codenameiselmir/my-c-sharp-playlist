/*
===========================================================
Lesson 12 - If and Else
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _12._If_and_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is an If Statement?
            // ==========================================================
            /*
             If statements are used for decision making.

             They allow the program to run different code
             depending on a condition.

             If something is true, the program does one thing.
             If something is false, the program can do something else.
            */

            // ==========================================================
            // 2. Asking the User for Input
            // ==========================================================
            /*
             In this example, we ask the user to enter their age.

             Since Console.ReadLine() always gives us text,
             we use Convert.ToInt32() to turn that text into an integer.
            */

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // ==========================================================
            // 3. Using if, else if, and else
            // ==========================================================
            /*
             if       -> runs when the condition is true
             else if  -> checks another condition if the first one is false
             else     -> runs if none of the conditions are true
            */

            if (age >= 18)
            {
                Console.WriteLine("You signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("Hold on... Are you sure?");
            }
            else
            {
                Console.WriteLine("Sorry! You cannot sign up.");
            }

            Console.WriteLine();

            // ==========================================================
            // 4. Important Notes
            // ==========================================================
            /*
             - Code inside curly brackets { } runs only when
               the condition is true.

             - You can use multiple else if blocks when you want
               to check more conditions.

             - else is optional, but it is very useful when you want
               to handle all remaining cases.
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}