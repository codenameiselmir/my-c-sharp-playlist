/*
===========================================================
Lesson 3 - Variables
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a variable?
2) Why do we use variables?
3) How to declare a variable in C#
4) Basic data types
5) What is a constant?
*/

/*
1) What is a Variable?

A variable is a container used to store data.

Example:
int age = 25;

Here:
- int → data type
- age → variable name
- 25 → value
*/

/*
2) Variable Declaration Syntax

dataType variableName = value;

Example:
int number = 10;
string name = "John";
*/

/*
3) What is a Constant?

A constant is a variable whose value cannot be changed.

To declare a constant in C#, we use the keyword:

const

Example:
const double PI = 3.14;

Important:
- A constant must be assigned a value at the time of declaration.
- Its value cannot be modified later.
*/

namespace Lesson_3._Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer (whole number)
            int age = 25;

            // Double (decimal number)
            double price = 19.99;

            // String (text)
            string fullName = "Elmir Developer";

            // Boolean (true or false)
            bool isStudent = true;

            // Constant value (cannot be changed)
            const double PI = 3.14159;

            Console.WriteLine("Age: " + age);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("PI Value: " + PI);

            /*
            The following line would cause an error:

            PI = 3.15;  // ❌ Error! Cannot modify a constant

            Because constants cannot change after declaration.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}