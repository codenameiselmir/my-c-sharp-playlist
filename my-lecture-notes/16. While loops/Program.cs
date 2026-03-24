/*
===========================================================
Lesson 16 - While Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _16._While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is a While Loop?
            // ==========================================================
            /*
             A while loop repeats some code
             while a condition remains true.

             Syntax:

             while (condition)
             {
                 // code runs
             }

             The loop stops when the condition becomes false.
            */

            // ==========================================================
            // 2. Asking the User for Input
            // ==========================================================
            /*
             In this example, we ask the user
             to enter their name.

             If the user enters an empty text,
             the loop will continue asking again.
            */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // ==========================================================
            // 3. Using the while Loop
            // ==========================================================
            /*
             The loop keeps running
             while the name is empty.
            */

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hi! " + name);

            // ==========================================================
            // 4. Important Notes
            // ==========================================================
            /*
             - The condition is checked before each loop.

             - If the condition is false at the beginning,
               the loop will never run.

             - Be careful to avoid infinite loops.
               Always make sure something inside the loop
               can eventually make the condition false.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}