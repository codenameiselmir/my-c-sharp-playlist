/*
===========================================================
Lesson 11 - If and Else
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is an if statement?
2) if
3) else if
4) else
*/

/*
1) What is an If Statement?

If statements are used for decision making.

They allow the program to run different code
depending on a condition.

If something is true → do this.
If something is false → do something else.
*/

namespace Lesson_11._If_and_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: Age Check Program

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            /*
            if → runs when condition is true
            else if → checks another condition
            else → runs if no conditions are true
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

            /*
            Important Notes:

            - Code inside { } runs only if the condition is true.
            - You can use multiple else if blocks.
            - else is optional but useful.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
