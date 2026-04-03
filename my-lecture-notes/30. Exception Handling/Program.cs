/*
===========================================================
Lesson 30 - Exception Handling
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is an Exception?

An exception is an error that happens
while the program is running.

Without handling exceptions,
the program may crash.
*/

/*
try

Code that may cause an error
is placed inside the try block.
*/

/*
catch

If an error occurs inside try,
the catch block handles it.
*/

/*
finally

The finally block always runs,
whether an error occurs or not.
It is optional.
*/

namespace _30._Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            finally
            {
                Console.WriteLine("This block always runs.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
