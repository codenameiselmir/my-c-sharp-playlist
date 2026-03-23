/*
===========================================================
Practice 1 - Introduce Yourself
Repository: my-c-sharp-playlist
File: Program.cs
===========================================================
*/

// ==========================================================
// Homework
// ==========================================================
/*
 In this homework, you will create a simple C# console
 application that introduces yourself.

 You will practice:
 - creating variables
 - printing output to the console
 - using string interpolation
 - displaying different types of data

 At the end of the program, the user should see
 your personal introduction on the screen.
*/

// ==========================================================
// 1. Introduction
// ==========================================================
/*
 In this practice project, we will use:

 - variables
 - string interpolation
 - Console.WriteLine()
 - Console.ReadKey()

 The goal is to create a simple console application
 that introduces a person.
*/

using System;

namespace _03._Practice_1___Introduce_Yourself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Welcome Message
            // ==========================================================
            Console.WriteLine("Welcome to my C# notes!");
            Console.WriteLine("This is my first practice project where I will introduce myself.");
            Console.WriteLine();

            // ==========================================================
            // 3. Variables
            // ==========================================================
            /*
             Variables are used to store data that we can use later.
            */
            string name = "Elmir";
            int age = 22;
            string learningLanguage = "C#";
            bool studentStatus = true;
            double setupPrice = 3.5;

            // ==========================================================
            // 4. Output
            // ==========================================================
            /*
             Here we print the values by using string interpolation.
            */
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"I am {age} years old.");
            Console.WriteLine($"I am learning {learningLanguage}.");
            Console.WriteLine($"Student status: {studentStatus}");
            Console.WriteLine($"My setup price is {setupPrice}K.");
            Console.WriteLine();

            // ==========================================================
            // 5. Final Sentence
            // ==========================================================
            Console.WriteLine($"As you can see, I am {name} and I am learning {learningLanguage}.");
            Console.WriteLine();

            // ==========================================================
            // 6. Close the Program
            // ==========================================================
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}