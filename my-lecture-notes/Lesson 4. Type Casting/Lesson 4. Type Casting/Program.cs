/*
===========================================================
Lesson 4 - Type Casting (Using Convert)
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is Type Casting?
2) Why do we need Convert?
3) Convert string to different data types
*/

/*
1) What is Type Casting?

Type Casting means converting one data type into another data type.

In this lesson, we will only use the Convert class.
*/

/*
2) Why Do We Need Convert?

When we get data from the user using Console.ReadLine(),
the value is always a string.

But sometimes we need:
- int
- double
- bool

So we must convert the string into another data type.
*/

namespace Lesson_4._Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Convert string to int

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            int age = Convert.ToInt32(ageText);

            Console.WriteLine("Your age is: " + age);


            // Example 2: Convert string to double

            Console.Write("Enter price: ");
            string priceText = Console.ReadLine();

            double price = Convert.ToDouble(priceText);

            Console.WriteLine("Price is: " + price);


            // Example 3: Convert string to bool

            Console.Write("Are you a student? (true/false): ");
            string studentText = Console.ReadLine();

            bool isStudent = Convert.ToBoolean(studentText);

            Console.WriteLine("Student status: " + isStudent);


            /*
            Common Convert Methods:

            Convert.ToInt32()
            Convert.ToDouble()
            Convert.ToBoolean()
            Convert.ToString()
            Convert.ToChar()

            Important:
            If the user enters wrong format (example: letters instead of number),
            the program will throw an error.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}