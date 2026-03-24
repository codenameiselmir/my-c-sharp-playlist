/*
===========================================================
Lesson 13 - Switch and Case
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Homework / Task:
Build a console application that asks the user to enter
a number from 1 to 3 and displays the matching result.

The program should:
- ask the user to enter a number
- use switch and case statements
- display a different message for each number
- use default if the entered value does not match any case

Goal:
This practice helps us understand how switch works in C#.
We will learn how to compare one variable with multiple
possible values in a clean and readable way.
===========================================================
*/

using System;

namespace _13._Switch_and_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is switch?
            // ==========================================================
            /*
             switch is used to compare one variable
             with multiple possible values.

             It is cleaner than writing many else if statements.

             switch checks the value once,
             then jumps to the matching case.
            */

            // ==========================================================
            // 2. What is case?
            // ==========================================================
            /*
             case represents a possible value.

             If the variable matches the case value,
             the code inside that case will run.

             Each case must match exactly.
            */

            // ==========================================================
            // 3. What is break?
            // ==========================================================
            /*
             break is very important.

             It stops the switch block.

             Without break, the program would continue
             checking or executing more code.
            */

            // ==========================================================
            // 4. What is default?
            // ==========================================================
            /*
             default runs when no case matches.

             It is optional,
             but highly recommended.
            */

            // ==========================================================
            // 5. Asking the User for Input
            // ==========================================================
            /*
             In this example, we ask the user
             to enter a number from 1 to 3.

             Then we use switch to check the value.
            */

            Console.Write("Enter a number (1-3): ");
            string number = Console.ReadLine();

            Console.WriteLine();

            // ==========================================================
            // 6. Using switch and case
            // ==========================================================
            switch (number)
            {
                case "1":
                    Console.WriteLine("You selected One.");
                    break;

                case "2":
                    Console.WriteLine("You selected Two.");
                    break;

                case "3":
                    Console.WriteLine("You selected Three.");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}