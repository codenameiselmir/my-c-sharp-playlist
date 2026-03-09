/*
===========================================================
Lesson 14 - While Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a while loop?
2) How while loop works
3) Avoiding infinite loops
*/

/*
1) What is a While Loop?

A while loop repeats some code
while a condition remains true.

Syntax:

while (condition)
{
    // code runs
}

The loop stops when the condition becomes false.
*/

namespace Lesson_14._While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to enter name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            /*
            If user enters empty text (""),
            the loop will continue asking.
            */

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hi! " + name);

            /*
            Important Notes:

            - The condition is checked BEFORE each loop.
            - If condition is false at the beginning,
              the loop will never run.
            - Be careful to avoid infinite loops.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}