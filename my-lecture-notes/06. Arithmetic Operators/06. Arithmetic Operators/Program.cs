/*
===========================================================
Lesson 6 - Arithmetic Operators
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// Lesson Overview
// ==========================================================
/*
 In this lesson we will learn:

 1. What are Arithmetic Operators?
 2. Basic Math Operators in C#
 3. Increment and Decrement
*/

// ==========================================================
// 1. What Are Arithmetic Operators?
// ==========================================================
/*
 Arithmetic operators are used to perform mathematical operations.

 C# supports the following arithmetic operators:

 +   Addition
 -   Subtraction
 *   Multiplication
 /   Division
 %   Modulus (Remainder)
*/

// ==========================================================
// Important Note About Division
// ==========================================================
/*
 If both numbers are integers,
 division will return an integer value.

 This means the decimal part is removed.

 Example:
 10 / 3 = 3
*/

using System;

namespace Lesson_6._Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Basic Math Operators in C#
            // ==========================================================
            int number1 = 10;
            int number2 = 3;

            // Addition
            int sum = number1 + number2;
            Console.WriteLine("Addition: " + sum);

            // Subtraction
            int difference = number1 - number2;
            Console.WriteLine("Subtraction: " + difference);

            // Multiplication
            int product = number1 * number2;
            Console.WriteLine("Multiplication: " + product);

            // Division
            int division = number1 / number2;
            Console.WriteLine("Division: " + division);

            // Modulus (Remainder)
            int remainder = number1 % number2;
            Console.WriteLine("Modulus (Remainder): " + remainder);

            Console.WriteLine();

            // ==========================================================
            // 3. Division with double
            // ==========================================================
            /*
             If we want a decimal result,
             we must use double.
            */
            double result = 10.0 / 3;
            Console.WriteLine("Double Division: " + result);

            Console.WriteLine();

            // ==========================================================
            // 4. Increment and Decrement
            // ==========================================================
            /*
             ++ increases the value by 1
             -- decreases the value by 1
            */
            int value = 5;

            value++; // value = value + 1
            Console.WriteLine("After Increment: " + value);

            value--; // value = value - 1
            Console.WriteLine("After Decrement: " + value);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}