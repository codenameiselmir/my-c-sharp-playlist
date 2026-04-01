/*
===========================================================
Lesson 22 - Arrays
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _22._Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is an Array?
            // ==========================================================
            /*
             An array is a variable
             that can store multiple values.

             Instead of creating many separate variables,
             we can store related values together
             inside one array.

             Arrays have fixed size.

             That means:
             after creating an array,
             its length cannot change.

             Example:
             string[] cars = { "BMW", "Mustang", "Corvette" };
            */

            // ==========================================================
            // 2. Creating an Array - Method 1
            // ==========================================================
            /*
             Here we create an array
             and give the values immediately.

             string[] means:
             this is an array of strings.
            */

            string[] cars = { "BMW", "Mustang", "Corvette" };

            // ==========================================================
            // 3. Accessing Array Elements
            // ==========================================================
            /*
             Each item in an array has an index.

             Index numbers start from 0.

             So in this array:
             cars[0] -> BMW
             cars[1] -> Mustang
             cars[2] -> Corvette

             We use the index number
             to access a specific element.
            */

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            Console.WriteLine();

            // ==========================================================
            // 4. Writing Array Elements with a for Loop
            // ==========================================================
            /*
             Instead of writing each element one by one,
             we can use a for loop.

             cars.Length gives the number of elements
             inside the array.

             Important:
             We must use i < cars.Length

             Not:
             i <= cars.Length

             Why?

             Because if the length is 3,
             valid indexes are:
             0, 1, 2

             But index 3 does not exist.

             Using <= would cause an error.
            */

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 5. Creating an Array - Method 2
            // ==========================================================
            /*
             Here we create an empty array first.

             new string[3] means:
             create a string array
             with space for 3 elements.

             Then we assign values one by one.
            */

            string[] cars2 = new string[3];

            cars2[0] = "Ferrari";
            cars2[1] = "Lambo";
            cars2[2] = "Audi";

            for (int i = 0; i < cars2.Length; i++)
            {
                Console.WriteLine(cars2[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 6. What Are Array Methods?
            // ==========================================================
            /*
             Array methods are built-in tools
             that help us work with arrays more easily.

             With array methods, we can:
             - sort an array
             - reverse an array
             - clear elements
             - find the index of an element
             - resize an array

             In C#, these are commonly used
             through the Array class.
            */

            // ==========================================================
            // 7. Array.Sort()
            // ==========================================================

            /*
             Array.Sort() sorts the elements in ascending order.
             
             for strings -> alphabetical order
             for numbers -> smallest to largest
            */

            string[] fruits = { "Banana", "Apple", "Orange", "Mango" };

            Array.Sort(fruits);

            Console.WriteLine("After Array.Sort():");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

            // ==========================================================
            // 8. Array.Reverse()
            // ==========================================================

            /*
             Array.Reverse() reverses
             the order of elements.

             If we use it after sorting,
             we can get descending order.
            */

            Array.Reverse(fruits);

            Console.WriteLine("After Array.Reverse():");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 9. Array.IndexOf()
            // ==========================================================

            /*
             Array.IndexOf() returns
             the index position of an element.

             If the value exists,
             it returns its index.

             If the value does not exist,
             it returns -1.
            */

            string[] names = { "Ali", "Veli", "Ayse", "Fatma" };

            int index1 = Array.IndexOf(names, "Ayse");
            int index2 = Array.IndexOf(names, "Mehmet");

            Console.WriteLine("Index of Ayse: " + index1);
            Console.WriteLine("Index of Mehmet: " + index2);

            Console.WriteLine();

            // ==========================================================
            // 10. Array.Clear()
            // ==========================================================

            /*
             Array.Clear() removes values
             from specific positions.

             It does not delete the array itself.

             It resets elements to default values.

             For string arrays:
             default value is null

             For int arrays:
             default value is 0
            */

            string[] colors = { "Red", "Blue", "Green", "Black" };

            Array.Clear(colors, 1, 2);

            Console.WriteLine("After Array.Clear():");

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 11. Array.Resize()
            // ==========================================================

            /*
             Arrays normally have fixed size.

             But Array.Resize() lets us create
             a bigger or smaller array.

             It changes the size of the array variable.

             If we increase the size,
             new elements get default values.
            */

            string[] animals = { "Cat", "Dog", "Bird" };

            Array.Resize(ref animals, 5);

            animals[3] = "Lion";
            animals[4] = "Tiger";

            Console.WriteLine("After Array.Resize():");

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine();

            // ==========================================================
            // 12. Array.Exists()
            // ==========================================================

            /*
             Array.Exists() checks
             whether an element exists in the array.

             It returns:
             true  -> if found
             false -> if not found

             We usually use it with a condition.
            */

            int[] numbers = { 10, 20, 30, 40, 50 };

            bool hasThirty = Array.Exists(numbers, number => number == 30);
            bool hasNinety = Array.Exists(numbers, number => number == 90);

            Console.WriteLine("Does 30 exist? " + hasThirty);
            Console.WriteLine("Does 90 exist? " + hasNinety);

            Console.WriteLine();

            // ==========================================================
            // 13. Array.Find()
            // ==========================================================
            /*
             Array.Find() returns
             the first element that matches a condition.

             If nothing matches,
             it returns the default value.

             For int:
             default is 0
            */

            int[] scores = { 45, 67, 82, 91, 38 };

            int firstHighScore = Array.Find(scores, score => score > 80);

            Console.WriteLine("First score greater than 80: " + firstHighScore);

            Console.WriteLine();

            // ==========================================================
            // 14. Important Notes About Arrays
            // ==========================================================

            /*
             - Arrays store multiple values
               of the same type

             - Indexes start from 0

             - Arrays have fixed size

             - Length gives the total number of elements

             - The last index is always Length - 1

             - Accessing a wrong index
               causes an error

             - Array methods make working with arrays
               much easier
            */

            // ==========================================================
            // 15. Final Summary
            // ==========================================================
            /*
             In this lesson, we learned:

             - what an array is
             - how to create arrays
             - how to access elements by index
             - how to use a for loop with arrays
             - how to use common array methods

             Important array methods:
             - Array.Sort()
             - Array.Reverse()
             - Array.IndexOf()
             - Array.Clear()
             - Array.Resize()
             - Array.Exists()
             - Array.Find()

             Arrays are very useful
             when we want to store and manage
             multiple related values together.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}