/*
===========================================================
Lesson 20 - Arrays
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// 1. What is an Array?
// ==========================================================
/*
 An array is a variable that can store multiple values
 of the same data type.

 Arrays have:
 - Fixed size
 - Index numbers (starting from 0)

 Example index positions:

 Index:   0      1       2
 Value:  BMW  Mustang  Tesla
*/

// ==========================================================
// 2. What is a Multidimensional Array?
// ==========================================================
/*
 A multidimensional array stores data in rows and columns,
 like a table.

 It is commonly used for:
 - Grids
 - Matrices
 - Game boards

 A 2D array uses two indexes:
 [row, column]
*/

using System;

namespace Lesson_18_And_26._Arrays_and_Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 3. Declaring and Initializing a One-Dimensional Array
            // ==========================================================
            /*
             Method 1:
             Initialize array with values directly.
            */

            string[] cars = { "BMW", "Mustang", "Tesla" };

            Console.WriteLine("One-Dimensional Array:");
            Console.WriteLine("First car: " + cars[0]);
            Console.WriteLine("Second car: " + cars[1]);
            Console.WriteLine("Third car: " + cars[2]);

            Console.WriteLine();

            // ==========================================================
            // 4. Looping Through a One-Dimensional Array
            // ==========================================================
            /*
             We can use a for loop to go through each element.

             cars.Length gives the total number of elements.
            */

            Console.WriteLine("Looping through cars array:");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car: " + cars[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 5. Declaring an Array First, Then Assigning Values
            // ==========================================================
            /*
             Method 2:
             Create an empty array with a fixed size,
             then assign values one by one.
            */

            string[] fruits = new string[3];

            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Watermelon";

            Console.WriteLine("Fruits array:");

            for (int j = 0; j < fruits.Length; j++)
            {
                Console.WriteLine("Fruit: " + fruits[j]);
            }

            Console.WriteLine();

            // ==========================================================
            // 6. Declaring and Initializing a Multidimensional Array
            // ==========================================================
            /*
             A multidimensional array can store data
             in rows and columns.

             Here we create 2 rows and 3 columns.
            */

            string[,] carTable =
            {
                { "BMW", "Mustang", "Tesla" },
                { "Toyota", "Honda", "Ford" }
            };

            Console.WriteLine("Multidimensional Array:");

            /*
             Accessing elements:

             carTable[row, column]
            */

            Console.WriteLine("Element at [0,1]: " + carTable[0, 1]);
            Console.WriteLine("Element at [1,2]: " + carTable[1, 2]);

            Console.WriteLine();

            // ==========================================================
            // 7. Looping Through a Multidimensional Array
            // ==========================================================
            /*
             We use nested loops for a 2D array.

             GetLength(0) gives the number of rows.
             GetLength(1) gives the number of columns.
            */

            Console.WriteLine("Looping through multidimensional array:");

            for (int row = 0; row < carTable.GetLength(0); row++)
            {
                for (int column = 0; column < carTable.GetLength(1); column++)
                {
                    Console.Write(carTable[row, column] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // ==========================================================
            // 8. Important Notes
            // ==========================================================
            /*
             One-Dimensional Array:
             - Index starts from 0
             - Length gives total number of elements
             - Size is fixed after creation

             Multidimensional Array:
             - Uses row and column indexes
             - GetLength(0) gives row count
             - GetLength(1) gives column count
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}