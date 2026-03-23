/*
===========================================================
Lesson 4 - Type Casting
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// 1. What is Type Casting?
// ==========================================================
/*
 Type casting means converting one data type
 into another data type.

 In this lesson, we will focus on converting
 values by using the Convert class.

 This is especially useful when we get data
 from the user with Console.ReadLine().
*/

using System;

namespace _04._Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. What is User Input?
            // ==========================================================
            /*
             User input means getting data from the user
             while the program is running.

             In C#, we use:

             Console.ReadLine()

             to receive input from the keyboard.
            */

            Console.WriteLine("In this lesson, we will learn user input and type casting.");
            Console.WriteLine();

            // ==========================================================
            // 3. Important Rule About Console.ReadLine()
            // ==========================================================
            /*
             Console.ReadLine() always returns a string.

             Even if the user enters a number,
             the value is still received as text.

             Because of that, we often need to convert
             the value into another data type.
            */

            Console.WriteLine("Console.ReadLine() always returns a string.");
            Console.WriteLine();

            // ==========================================================
            // 4. Why Do We Need Convert?
            // ==========================================================
            /*
             Sometimes we need to work with:

             - int
             - double
             - bool

             But user input comes as a string.

             So we use the Convert class
             to change the type of the value.
            */

            // ==========================================================
            // 5. Converting String to int
            // ==========================================================
            /*
             Here, the user enters their age.

             First, the value comes as a string.
             Then we convert it to int.
            */

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            int age = Convert.ToInt32(ageText);

            Console.WriteLine($"Your age is: {age}");
            Console.WriteLine();

            // ==========================================================
            // 6. Converting String to double
            // ==========================================================
            /*
             A double is used for decimal numbers.
            */

            Console.Write("Enter a price: ");
            string priceText = Console.ReadLine();

            double price = Convert.ToDouble(priceText);

            Console.WriteLine($"Price is: {price}");
            Console.WriteLine();

            // ==========================================================
            // 7. Converting String to bool
            // ==========================================================
            /*
             A bool value can only be true or false.
            */

            Console.Write("Are you a student? (true/false): ");
            string studentText = Console.ReadLine();

            bool isStudent = Convert.ToBoolean(studentText);

            Console.WriteLine($"Student status: {isStudent}");
            Console.WriteLine();

            // ==========================================================
            // 8. String Input with Console.ReadLine()
            // ==========================================================
            /*
             If we want text from the user,
             we do not need Convert.

             Because Console.ReadLine() already returns string.
            */

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine();

            // ==========================================================
            // 9. Simple Calculation with User Input
            // ==========================================================
            /*
             To do math operations, number values must be converted
             from string to int.
            */

            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine();

            // ==========================================================
            // 10. Common Convert Methods
            // ==========================================================
            /*
             Some common Convert methods are:

             Convert.ToInt32()
             Convert.ToDouble()
             Convert.ToBoolean()
             Convert.ToString()
            */

            // ==========================================================
            // 11. Important Note
            // ==========================================================
            /*
             If the user enters the wrong format,
             the program will throw an error.

             Example:
             - entering letters instead of a number
             - entering something other than true or false for bool
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}