/*
===========================================================
Practice 4: Lucky Number App
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Homework / Task:
Build a console application called Lucky Number App.

The program should:
- ask the user for their full name
- ask the user for their age
- ask the user for two numbers
- display the name using different string methods
- perform arithmetic operations with the numbers
- use Math class methods
- generate a random lucky number between 1 and 100

Goal:
This practice helps us combine the following topics in one project:
- Console.WriteLine() and Console.ReadLine()
- Variables
- Type Casting using Convert
- Arithmetic Operators
- Math Class
- Random Class
- String Methods
===========================================================
*/

using System;

namespace _11._Practice_4___Lucky_Number_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Getting User Information
            // ==========================================================
            /*
             In this practice project, we ask the user for:
             - full name
             - age
             - first number
             - second number

             Then we use different C# topics to process
             and display the information.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();
            int age = Convert.ToInt32(ageText);

            Console.Write("Enter first number: ");
            string firstNumText = Console.ReadLine();
            int firstNum = Convert.ToInt32(firstNumText);

            Console.Write("Enter second number: ");
            string secNumText = Console.ReadLine();
            int secNum = Convert.ToInt32(secNumText);

            Console.WriteLine();

            // ==========================================================
            // 2. String Methods
            // ==========================================================
            /*
             Here we use string methods to format and analyze
             the user's full name.
            */

            Console.WriteLine($"Hello, {fullName.ToUpper()}");
            Console.WriteLine($"Your name in lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your name length: {fullName.Length}");
            Console.WriteLine($"Name with underscores: {fullName.Replace(" ", "_")}");
            Console.WriteLine($"First 3 letters: {fullName.Substring(0, 3)}");

            Console.WriteLine();

            // ==========================================================
            // 3. Variables and Output
            // ==========================================================
            Console.WriteLine($"You are {age} years old.");

            Console.WriteLine();

            // ==========================================================
            // 4. Arithmetic Operators
            // ==========================================================
            Console.WriteLine($"Addition: {firstNum + secNum}");
            Console.WriteLine($"Subtraction: {firstNum - secNum}");
            Console.WriteLine($"Multiplication: {firstNum * secNum}");

            double divisionNum1 = Convert.ToDouble(firstNum);
            double divisionNum2 = Convert.ToDouble(secNum);
            Console.WriteLine($"Division: {divisionNum1 / divisionNum2}");

            Console.WriteLine($"Remainder: {firstNum % secNum}");

            Console.WriteLine();

            // ==========================================================
            // 5. Math Class
            // ==========================================================
            Console.WriteLine($"Maximum number: {Math.Max(firstNum, secNum)}");
            Console.WriteLine($"Minimum number: {Math.Min(firstNum, secNum)}");
            Console.WriteLine($"Power of first number: {Math.Pow(firstNum, secNum)}");
            Console.WriteLine($"Square root of second number: {Math.Sqrt(secNum)}");
            Console.WriteLine($"Absolute subtraction: {Math.Abs(firstNum - secNum)}");

            Console.WriteLine();

            // ==========================================================
            // 6. Random Class
            // ==========================================================
            Random luckyNum = new Random();
            Console.WriteLine($"Your lucky number is: {luckyNum.Next(1, 101)}");

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}