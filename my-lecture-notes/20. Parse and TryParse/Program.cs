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

using System;

namespace Parse_And_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Why Do We Need Them?
            // ==========================================================
            /*
             When the user enters a value from the keyboard,
             the value comes as text.

             For example:

             Console.ReadLine()

             always gives us a string.

             But sometimes we want to use that value
             as an int or double.

             That is why Parse and TryParse are important.
            */

            Console.WriteLine("In this lesson, we will learn Parse and TryParse.");
            Console.WriteLine();

            // ==========================================================
            // 3. What is Parse()?
            // ==========================================================
            /*
             Parse() converts a string into another type.

             Example:

             int number = int.Parse("25");

             This means the string "25"
             becomes the integer 25.

             Parse() is useful when we are sure
             the input format is correct.
            */

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);

            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine();

            /*
             Example input:
             25

             Output:
             Your age is: 25
            */

            // ==========================================================
            // 4. Parse() with double
            // ==========================================================
            /*
             Parse() can also be used with
             decimal numbers.

             For example, double.Parse()
             converts text into a double value.
            */

            Console.Write("Enter your exam result: ");
            string examText = Console.ReadLine();

            double examResult = double.Parse(examText);

            Console.WriteLine($"Your exam result is: {examResult}");
            Console.WriteLine();

            /*
             Example input:
             87.5

             Output:
             Your exam result is: 87.5
            */

            // ==========================================================
            // 5. Problem with Parse()
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

            Console.WriteLine("Parse() is useful, but it is not safe for invalid input.");
            Console.WriteLine();

            // ==========================================================
            // 6. What is TryParse()?
            // ==========================================================
            /*
             TryParse() is a safer way
             to convert string values.

             It does not throw an error
             when the conversion fails.

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

            /*
             Example input:
             50

             Output:
             Was conversion successful? True
             Parsed value: 50
            */

            /*
             Example input:
             hello

             Output:
             Was conversion successful? False
             Parsed value: 0
            */

            // ==========================================================
            // 7. Understanding the out Keyword
            // ==========================================================
            /*
             In TryParse(), we use the out keyword.

             Example:

             int.TryParse(text, out int number)

             If the conversion is successful,
             the converted value is stored in number.

             If the conversion fails,
             number gets the default value.
            */

            Console.Write("Enter your lucky number: ");
            string luckyNumberText = Console.ReadLine();

            int.TryParse(luckyNumberText, out int luckyNumber);

            Console.WriteLine($"Lucky number value: {luckyNumber}");
            Console.WriteLine();

            // ==========================================================
            // 8. Using TryParse() with if
            // ==========================================================
            /*
             We often use TryParse() with if.

             This helps us check whether
             the conversion worked before using the value.
            */

            Console.Write("Enter your favorite number: ");
            string favoriteNumberText = Console.ReadLine();

            if (int.TryParse(favoriteNumberText, out int favoriteNumber))
            {
                Console.WriteLine($"Your favorite number is: {favoriteNumber}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();

            // ==========================================================
            // 9. TryParse() with double
            // ==========================================================
            /*
             TryParse() can also be used with double.

             This is helpful when working
             with decimal values entered by the user.
            */

            Console.Write("Enter a product price: ");
            string priceText = Console.ReadLine();

            if (double.TryParse(priceText, out double price))
            {
                Console.WriteLine($"Product price: {price}");
            }
            else
            {
                Console.WriteLine("Invalid price format.");
            }

            Console.WriteLine();

            // ==========================================================
            // 10. Parse vs TryParse
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

            // ==========================================================
            // 11. When Should We Use Parse()?
            // ==========================================================
            /*
             We use Parse() when we are confident
             that the value is in the correct format.

             For example:
             - controlled data
             - predefined values
             - trusted input
            */

            // ==========================================================
            // 12. When Should We Use TryParse()?
            // ==========================================================
            /*
             We use TryParse() when the value
             comes from the user.

             Because users can enter invalid values,
             TryParse() is usually the better choice
             for Console.ReadLine() input.
            */

            // ==========================================================
            // 13. Important Note
            // ==========================================================
            /*
             Parse() is simpler,
             but TryParse() is safer.

             In real programs,
             TryParse() is often preferred
             for user input validation.
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}