/*
===========================================================
Lesson 16 - Nested Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a nested loop?
2) How nested loops work
3) Practical example
*/

/*
1) What is a Nested Loop?

A nested loop is a loop inside another loop.

Outer loop → runs first
Inner loop → runs completely for each outer loop iteration

This means:
If outer loop runs 3 times
and inner loop runs 4 times
Total executions = 3 × 4 = 12
*/

namespace Lesson_16._Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Example 1: Simple Nested Loop
            */

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer Loop: " + i);

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("   Inner Loop: " + j);
                }
            }

            /*
            How it works:

            i = 1
                j = 1
                j = 2

            i = 2
                j = 1
                j = 2

            i = 3
                j = 1
                j = 2
            */


            /*
            Example 2: Printing a Rectangle Pattern
            */

            Console.WriteLine();
            Console.WriteLine("Rectangle Pattern:");

            for (int row = 1; row <= 3; row++)
            {
                for (int column = 1; column <= 5; column++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine(); // move to next line after each row
            }


            /*
            Important Notes:

            - Inner loop finishes completely
              before outer loop continues.
            - Nested loops are often used
              for patterns, grids, and tables.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}