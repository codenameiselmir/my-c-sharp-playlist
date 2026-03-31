/*
===========================================================
Lesson 18 - For Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What a for loop is
2) How the structure of a for loop works
3) How a for loop runs step by step
4) What a nested loop is
5) How nested loops work together
6) A practical pattern example

-----------------------------------------------------------
PART 1 - FOR LOOPS
-----------------------------------------------------------

A for loop is used when we know how many times
we want to repeat a block of code.

General structure:

for (initialization; condition; increment/decrement)
{
    // code to repeat
}

Let's understand each part:

1) initialization
   - Runs only once at the beginning
   - Usually used to create a counter variable

2) condition
   - Checked before every iteration
   - If the condition is true, the loop continues
   - If the condition is false, the loop stops

3) increment/decrement
   - Runs after each iteration
   - Usually increases or decreases the counter

Example:
for (int i = 1; i <= 5; i++)

Meaning: 
- Starts with i = 1;
- Continue while i <= 5;
- After each loop, increase i by 1;

-----------------------------------------------------------
PART 2 - NESTED LOOPS
-----------------------------------------------------------

A nested loop means a loop inside another loop.

- The outer loop controls the big repetition
- The inner loop runs completely for every single
  iteration of the outer loop

Important idea:
If the outer loop runs 3 times
and the inner loop runs 2 times,
then the inner loop code runs 3 x 2 = 6 times total

Nested loops are commonly used for:
- patterns
- grids
- tables
- coordinates
- comparing groups of items
*/

namespace _18._For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("FOR LOOPS AND NESTED LOOPS");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Basic For Loop
            ---------------------------------------------------

            Goal:
            Print numbers from 1 to 5

            Step-by-step:
            - Start i at 1
            - Check if i is less than or equal to 5
            - Print the value
            - Increase i by 1
            - Repeat until the condition becomes false
            */

            Console.WriteLine("Example 1: Print numbers from 1 to 5");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
            }

            Console.WriteLine();

            /*
            What happened here?

            Iteration 1:
            i = 1 -> 1 <= 5 is true -> print 1

            Iteration 2:
            i = 2 -> 2 <= 5 is true -> print 2

            Iteration 3:
            i = 3 -> 3 <= 5 is true -> print 3

            Iteration 4:
            i = 4 -> 4 <= 5 is true -> print 4

            Iteration 5:
            i = 5 -> 5 <= 5 is true -> print 5

            Next:
            i becomes 6 -> 6 <= 5 is false -> stop
            */

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Countdown Using For Loop
            ---------------------------------------------------

            Goal:
            Print numbers from 5 down to 1

            Here we use:
            - initialization: int i = 5
            - condition: i >= 1
            - decrement: i--
            */

            Console.WriteLine("Example 2: Countdown from 5 to 1");

            for (int j = 5; j >= 1; j--)
            {
                Console.WriteLine($"Countdown: {j}");
            }

            Console.WriteLine();

            /*
            This time:
            - The loop starts at 5
            - Continues while i is 1 or greater
            - Decreases by 1 after each repetition

            This is useful when we want to move backwards.
            */

            /*
            ---------------------------------------------------
            EXAMPLE 3 - Simple Nested Loop
            ---------------------------------------------------

            Goal:
            Understand how one loop can run inside another loop

            Outer loop:
            - runs 3 times

            Inner loop:
            - runs 2 times for each outer loop round
            */

            Console.WriteLine("Example 3: Simple Nested Loop");

            for (int a = 1; a <= 3; a++)
            {
                Console.WriteLine();
                Console.Write("A");

                for (int b = 1; b <= 2; b++)
                {
                    Console.Write("B");
                }
            }

            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 4 - Rectangle Pattern
            ---------------------------------------------------

            Goal:
            Print a rectangle made of stars

            We will think like this:
            - Outer loop = rows
            - Inner loop = columns

            If rows = 3 and columns = 5,
            then we will print 3 lines,
            and each line will contain 5 stars.
            */

            Console.WriteLine("Example 4: Rectangle Pattern");

            for (int row = 1; row <= 3; row++)
            {
                Console.Write("*");

                for (int column = 1; column <= 5; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            /*
            Why does this create a rectangle?

            - The outer loop repeats each row
            - The inner loop prints 5 stars in that row
            - After the inner loop finishes, Console.WriteLine()
              moves the cursor to the next line
            - Then the next row begins
            */

            /*
            ---------------------------------------------------
            KEY IDEAS TO REMEMBER
            ---------------------------------------------------

            FOR LOOP:
            - Best when the number of repetitions is known
            - Has 3 main parts:
              initialization, condition, increment/decrement

            NESTED LOOP:
            - A loop inside another loop
            - Inner loop finishes completely each time
            - Often used for shapes, grids, and tables

            COMMON MISTAKE:
            - Writing a wrong condition can cause an infinite loop
            - Example: forgetting to increase or decrease the counter
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
