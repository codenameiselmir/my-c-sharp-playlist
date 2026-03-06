/*
===========================================================
Lesson 5 - User Input
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is User Input?
2) Console.ReadLine()
3) Combining User Input with Convert
*/

/*
1) What is User Input?

User Input means getting data from the user while
the program is running.

In C#, we use:

Console.ReadLine()

to receive input from the keyboard.
*/

/*
Important:

Console.ReadLine() always returns a STRING.

Even if the user enters a number,
it will still be stored as a string.

So if we need numbers,
we must convert them.
*/

namespace Lesson_5._User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Getting string input

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);


            // Example 2: Getting numeric input

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You are " + age + " years old.");


            // Example 3: Simple calculation with user input

            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine("Sum is: " + sum);


            /*
            Key Points:

            - Console.ReadLine() reads input from user.
            - It always returns string.
            - Use Convert to change type if needed.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}