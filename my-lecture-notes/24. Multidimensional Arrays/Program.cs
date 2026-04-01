/*
===========================================================
Lesson 24 - Multidimensional Arrays
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _24._Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is a Multidimensional Array?
            // ==========================================================
            /*
             A multidimensional array
             is an array that contains data
             in more than one dimension.

             In a normal array,
             values are stored in a single line.

             Example:
             { "BMW", "Mustang", "Corvette" }

             This is one-dimensional.

             But sometimes we want to store data
             like rows and columns.

             For that, we use
             a multidimensional array.

             The most common type is
             a 2-dimensional array.

             A 2D array is like a table.

             It has:
             - rows
             - columns
            */

            // ==========================================================
            // 2. Why Do We Use Multidimensional Arrays?
            // ==========================================================
            /*
             We use multidimensional arrays
             when data belongs in a table-like structure.

             Examples:
             - seats in a classroom
             - values in a matrix
             - game boards
             - weekly schedules
             - student scores for multiple exams

             Instead of creating many separate arrays,
             we can organize everything
             inside one structure.
            */

            // ==========================================================
            // 3. Creating a 2D Array - Method 1
            // ==========================================================
            /*
             Here we create a 2D array
             and assign values immediately.

             Syntax:

             dataType[,] arrayName =
             {
                 { value1, value2 },
                 { value3, value4 }
             };

             The comma inside [,]
             shows that this is
             a 2-dimensional array.
            */

            string[,] cars =
            {
                { "BMW", "Mustang", "Corvette" },
                { "Ferrari", "Lambo", "Audi" }
            };

            // ==========================================================
            // 4. Understanding Rows and Columns
            // ==========================================================
            /*
             In this array:

             Row 0:
             BMW, Mustang, Corvette

             Row 1:
             Ferrari, Lambo, Audi

             Column positions are:

             Column 0 -> first item
             Column 1 -> second item
             Column 2 -> third item

             So:

             cars[0, 0] -> BMW
             cars[0, 1] -> Mustang
             cars[0, 2] -> Corvette
             cars[1, 0] -> Ferrari
             cars[1, 1] -> Lambo
             cars[1, 2] -> Audi
            */

            Console.WriteLine(cars[0, 0]);
            Console.WriteLine(cars[0, 1]);
            Console.WriteLine(cars[1, 2]);

            Console.WriteLine();

            // ==========================================================
            // 5. Creating a 2D Array - Method 2
            // ==========================================================
            /*
             We can also create
             an empty 2D array first.

             Example:

             string[,] names = new string[2, 3];

             This means:
             - 2 rows
             - 3 columns

             Then we assign values manually.
            */

            string[,] names = new string[2, 3];

            names[0, 0] = "Ali";
            names[0, 1] = "Aysel";
            names[0, 2] = "Murad";
            names[1, 0] = "Leyla";
            names[1, 1] = "Kenan";
            names[1, 2] = "Nigar";

            Console.WriteLine(names[0, 0]);
            Console.WriteLine(names[1, 1]);

            Console.WriteLine();

            // ==========================================================
            // 6. Printing All Values with Nested for Loops
            // ==========================================================
            /*
             To print all values
             in a multidimensional array,
             we usually use nested for loops.

             Nested loop means:
             a loop inside another loop.

             Why?

             Because:
             - outer loop handles rows
             - inner loop handles columns
            */

            for (int i = 0; i < cars.GetLength(0); i++)
            {
                for (int j = 0; j < cars.GetLength(1); j++)
                {
                    Console.Write(cars[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // ==========================================================
            // 7. What Does GetLength() Mean?
            // ==========================================================
            /*
             In multidimensional arrays,
             we do not use only Length
             when we want row or column count.

             We use GetLength(dimension).

             GetLength(0) -> number of rows
             GetLength(1) -> number of columns

             For the cars array:

             cars.GetLength(0) -> 2
             cars.GetLength(1) -> 3
            */

            Console.WriteLine("Rows: " + cars.GetLength(0));
            Console.WriteLine("Columns: " + cars.GetLength(1));

            Console.WriteLine();

            // ==========================================================
            // 8. Total Number of Elements
            // ==========================================================
            /*
             Length gives the total number
             of elements in the whole array.

             For example:

             2 rows x 3 columns = 6 elements
            */

            Console.WriteLine("Total elements: " + cars.Length);

            Console.WriteLine();

            // ==========================================================
            // 9. Example with Integer Matrix
            // ==========================================================
            /*
             Multidimensional arrays
             are also very common with numbers.

             Here we create an integer matrix.
            */

            int[,] numbers =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // ==========================================================
            // 10. Changing a Value in a Multidimensional Array
            // ==========================================================
            /*
             Just like normal arrays,
             we can change a value
             by using its indexes.

             Example:
             numbers[1, 1] originally is 5

             We can replace it with another value.
            */

            numbers[1, 1] = 99;

            Console.WriteLine("After changing numbers[1, 1]:");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // ==========================================================
            // 11. Multidimensional Array vs Normal Array
            // ==========================================================
            /*
             One-dimensional array:
             stores values in one line

             Example:
             int[] nums = { 1, 2, 3, 4 };

             Multidimensional array:
             stores values in rows and columns

             Example:
             int[,] nums2 =
             {
                 { 1, 2 },
                 { 3, 4 }
             };

             So the main difference is
             the way the data is organized.
            */

            // ==========================================================
            // 12. Important Notes
            // ==========================================================
            /*
             - Multidimensional arrays store data
               in more than one dimension

             - 2D arrays are the most common type

             - Use [,] for a 2D array

             - Access values with:
               array[row, column]

             - Use GetLength(0) for rows

             - Use GetLength(1) for columns

             - Use nested loops
               to go through all elements

             - Length gives total element count
            */

            // ==========================================================
            // 13. Final Summary
            // ==========================================================
            /*
             In this lesson, we learned:

             - what a multidimensional array is
             - how to create a 2D array
             - how to access elements
             - how rows and columns work
             - how to use GetLength()
             - how to print values with nested loops
             - how to modify values

             Multidimensional arrays are useful
             when data should be stored
             like a table or matrix.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}