/*
===========================================================
Lesson 16 - While Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

namespace _16._While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is a While Loop?
            // ==========================================================

            /*
            a while loop repeats block of code
            as long as a condition remains true

            while (condition) {
                code runs;
            }

            The program checks the condition first. If the condition is true,
            the code inside the loop runs. After the code runs, the condition is checked again.
            This process continues until the condition becomes false.
            */

            // ==========================================================
            // 2. Why Do We Use a While Loop?
            // ==========================================================

            /*
            We use a while loop when:

            - we want repeat something multiple times.
            - We do not know exactly how many times it will repeat
            - The repetition depends on a condition
            */

            // ==========================================================
            // 3. Asking the User for Input
            // ==========================================================

            /*
            In this example, we ask the user
            to enter their name.

            If the user enters an empty text,
            we do not want to accept it.

            So we will keep asking again
            until the user types something valid.
            */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // ==========================================================
            // 4. Using the while Loop
            // ==========================================================

            /*
            The loop keeps running
            while the name is empty.

            This means:

            - if name == ""
              the condition is true
              so the loop runs

            - if the user enters a real name
              the condition becomes false
              so the loop stops
            */

            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Hi! " + name);

            // ==========================================================
            // 5. What is a Do..While Loop?
            // ==========================================================

            /*
            a do.. while loop is very similar to a while loop.
            It also repeats code as long as a condition is true.

            But there is one very important difference, In a do..while loop,
            the code runs first, and the condition is checked after that.

            do
            {
                code runs first
            }
            while (condition);

            Because the condition is checked at the end,
            a do..while loop always runs at least one time.
            */

            string city;

            do
            {
                Console.Write("Enter your city: ");
                city = Console.ReadLine();
            }
            while (city == "");

            Console.WriteLine();
            Console.WriteLine("Your city is: " + city);

            // ==========================================================
            // 6. Final Summary
            // ==========================================================

            /*
            while loop:
            - condition first
            - runs while condition is true
            - may not run at all

            do..while loop:
            - code first
            - condition checked later
            - always runs at least once

            Both loops are useful.
            The correct one depends on
            when you want the condition to be checked.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
