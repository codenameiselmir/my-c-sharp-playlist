/*
===========================================================
Lesson 2 - Variables
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// 1. What is a Variable?
// ==========================================================
/*
 A variable is a container used to store data.

 Example:
 int age = 25;

 Here:
 - int  -> data type
 - age  -> variable name
 - 25   -> value
*/

using System;

namespace _02._Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Why Do We Use Variables?
            // ==========================================================
            /*
             Variables help us store information in memory
             and use it later in the program.

             Instead of writing the same value again and again,
             we can store it in a variable and reuse it.

             This makes code easier to read, update, and manage.
            */

            Console.WriteLine("Variables store data that we can use later.");
            Console.WriteLine();

            // ==========================================================
            // 3. How to Declare a Variable
            // ==========================================================
            /*
             The general syntax is:

             dataType variableName = value;

             Example:
             int number = 10;
             string name = "John";
            */

            int age = 22;
            string fullName = "Elmir Abaszada";

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine();

            // ==========================================================
            // 4. Basic Data Types
            // ==========================================================
            /*
             C# has many data types. Some common ones are:

             int     -> whole numbers
             double  -> decimal numbers
             string  -> text
             bool    -> true or false
            */

            int score = 100;
            double price = 19.99;
            string courseName = "C# Fundamentals";
            bool isStudent = true;

            Console.WriteLine("Score: " + score);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine();

            // ==========================================================
            // 5. What is a Constant?
            // ==========================================================
            /*
             A constant is a value that cannot be changed
             after it is declared.

             To create a constant in C#, we use the keyword:

             const

             Example:
             const double PI = 3.14159;

             Important:
             - A constant must get its value immediately
             - Its value cannot be modified later
            */

            const double PI = 3.14159;

            Console.WriteLine("PI Value: " + PI);
            Console.WriteLine();

            /*
             The following line would cause an error:

             PI = 3.15;

             Because constants cannot be changed.
            */

            // ==========================================================
            // 6. String Interpolation
            // ==========================================================
            /*
             String interpolation lets us insert variables
             directly inside a string.

             We use the $ symbol before the string.

             Old way (string concatenation):
             "Hello " + name + ", you are " + age + " years old."

             New way (string interpolation):
             $"Hello {name}, you are {age} years old."
            */

            string name = "Elmir";
            int userAge = 22;
            double balance = 150.75;

            Console.WriteLine($"Hello {name}, you are {userAge} years old.");
            Console.WriteLine($"Next year you will be {userAge + 1} years old.");
            Console.WriteLine($"Your account balance is {balance} USD.");
            Console.WriteLine();

            // ==========================================================
            // 7. Why String Interpolation is Useful
            // ==========================================================
            /*
             String interpolation makes code easier to read.

             It is often better than using + signs again and again
             to join strings and variables.

             Important notes:
             - Use $ before the string
             - Put variables inside { }
             - You can also write expressions inside { }
            */

            Console.WriteLine("String interpolation makes output cleaner and easier to understand.");
            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}