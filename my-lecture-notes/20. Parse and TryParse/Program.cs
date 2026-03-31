/*
===========================================================
Lesson 20 - Parse and TryParse
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// 1. What are Parse and TryParse?
// ==========================================================

/*
Parse and TryParse are used to convert
string values into other data types.

This is very common in C# because
Console.ReadLine() always returns a string.

If we want to work with numbers,
we usually need to convert the input first.
*/

namespace _20._Parse_and_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. What is Parse()?
            // ==========================================================

            /*
            Parse() converts a string into another type.

            Example:

            int number = int.Parse("25");
            This means the string "25" becomes the integer 25.

            Parse() is useful when we are sure
            the input format is correct.
            */

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);

            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine();

            // ==========================================================
            // 3. Problem with Parse()
            // ==========================================================

            /*
            Parse() expects the string to be valid.

            If the user enters something incorrect,
            the program throws an error.

            For example:

            int.Parse("hello")

            This causes a runtime error because
            "hello" is not a valid integer.
            */

            // ==========================================================
            // 4. What is TryParse()?
            // ==========================================================

            /*
            TryParse() is a safer way to convert string values.
            It does not throw an error when the conversion fails.

            Instead, it returns:

            - true  -> conversion successful
            - false -> conversion failed
            */

            Console.Write("Enter a number: ");
            string numberText = Console.ReadLine();
            bool success = int.TryParse(numberText, out int parsedNumber);

            Console.WriteLine($"Was conversion successful? {success}");
            Console.WriteLine($"Parsed value: {parsedNumber}");
            Console.WriteLine();

            // ==========================================================
            // 5. Parse vs TryParse
            // ==========================================================

            /*
             Parse():
             - directly converts the string
             - throws an error if format is wrong
             - useful when input is guaranteed to be correct

             TryParse():
             - tries to convert the string
             - does not throw an error if format is wrong
             - returns true or false
             - safer for user input
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}