/*
===========================================================
Lesson 7 - Math Class
Repository: my-c-sharp-playlist
File: Program.cs
===========================================================
*/

// ==========================================================
// Lesson Overview
// ==========================================================
/*
 In this lesson we will learn:

 1. What is Math class?
 2. Common Math methods
 3. Math constants
*/

// ==========================================================
// 1. What is Math Class?
// ==========================================================
/*
 Math is a built-in class in C#.

 It provides mathematical functions like:
 - Square root
 - Power
 - Absolute value
 - Rounding
 - Maximum and Minimum

 Math methods are static.
 That means we do not create an object.

 We use them like this:

 Math.MethodName()
*/

using System;

namespace _07._Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Common Math Methods
            // ==========================================================

            // Math.Max() -> Returns the larger number
            int max = Math.Max(10, 20);
            Console.WriteLine("Max: " + max);

            // Math.Min() -> Returns the smaller number
            int min = Math.Min(10, 20);
            Console.WriteLine("Min: " + min);

            // Math.Sqrt() -> Returns the square root
            double sqrt = Math.Sqrt(64);
            Console.WriteLine("Square Root of 64: " + sqrt);

            // Math.Abs() -> Returns the absolute value
            int absValue = Math.Abs(-25);
            Console.WriteLine("Absolute Value: " + absValue);

            // Math.Round() -> Rounds a number
            double rounded = Math.Round(5.67);
            Console.WriteLine("Rounded Value: " + rounded);

            // Math.Pow() -> Raises a number to a power
            double power = Math.Pow(2, 3);
            Console.WriteLine("2 to the power of 3: " + power);

            Console.WriteLine();

            // ==========================================================
            // 3. Math Constants
            // ==========================================================
            /*
             Math.PI -> Represents the value of pi
             Math.E  -> Represents Euler's number
            */
            Console.WriteLine("PI Value: " + Math.PI);
            Console.WriteLine("E Value: " + Math.E);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}