/*
===========================================================
Lesson 18 - Arrays
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is an array?
2) How to declare and initialize an array
3) Accessing array elements
4) Using Length property
*/

/*
1) What is an Array?

An array is a variable that can store multiple values
of the same data type.

Arrays have:
- Fixed size
- Index numbers (starting from 0)

Example index positions:

Index:   0      1       2
Value:  BMW  Mustang  Tesla
*/

namespace Lesson_18._Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Method 1: Initialize array with values directly
            */

            string[] cars = { "BMW", "Mustang", "Tesla" };

            // Accessing array elements using index
            Console.WriteLine("First car: " + cars[0]);
            Console.WriteLine("Second car: " + cars[1]);
            Console.WriteLine("Third car: " + cars[2]);

            Console.WriteLine();

            /*
            Looping through array using for loop
            */

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car: " + cars[i]);
            }

            Console.WriteLine();


            /*
            Method 2: Declare array first, then assign values
            */

            string[] fruits = new string[3];

            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Watermelon";

            for (int j = 0; j < fruits.Length; j++)
            {
                Console.WriteLine("Fruit: " + fruits[j]);
            }

            /*
            Important Notes:

            - Array index starts from 0.
            - Length property gives total number of elements.
            - Arrays have fixed size after creation.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}