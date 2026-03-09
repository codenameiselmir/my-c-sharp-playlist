/*
===========================================================
Lesson 13 - Logical Operators
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What are logical operators?
2) && (AND)
3) || (OR)
4) !  (NOT)
*/

/*
1) What are Logical Operators?

Logical operators are used to combine
multiple conditions in decision making.

They return true or false.
*/

/*
2) && (AND)

The AND operator returns true
ONLY if BOTH conditions are true.

Example:
condition1 && condition2
*/

/*
3) || (OR)

The OR operator returns true
if AT LEAST ONE condition is true.

Example:
condition1 || condition2
*/

/*
4) ! (NOT)

The NOT operator reverses a condition.

If something is true,
! makes it false.

If something is false,
! makes it true.
*/

namespace Lesson_13._Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the temperature outside? ");
            double temp = Convert.ToDouble(Console.ReadLine());

            // AND example
            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It is warm actually!");
            }

            // OR example
            else if (temp >= 50 || temp <= -50)
            {
                Console.WriteLine("Something weird!");
            }

            // NOT example
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