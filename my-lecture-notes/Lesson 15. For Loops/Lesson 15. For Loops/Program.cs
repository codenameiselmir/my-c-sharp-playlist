/*
===========================================================
Lesson 15 - For Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a for loop?
2) For loop structure
3) How for loop works
*/

/*
1) What is a For Loop?

A for loop is used when we know
how many times we want to repeat something.

It is commonly used with counters.
*/

/*
2) For Loop Structure

for (initialization; condition; increment/decrement)
{
    // code runs
}

- initialization → runs once at the beginning
- condition → checked before every loop
- increment/decrement → runs after each loop
*/

namespace Lesson_15._For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Example 1: Print numbers from 1 to 5
            */

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number: " + i);
            }

            /*
            Explanation:

            int i = 1     → start from 1
            i <= 5        → continue while i is 5 or less
            i++           → increase i by 1 each time
            */


            /*
            Example 2: Countdown from 5 to 1
            */

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Countdown: " + i);
            }


            /*
            Important Notes:

            - If the condition is false,
              the loop will stop.
            - Be careful with conditions
              to avoid infinite loops.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}