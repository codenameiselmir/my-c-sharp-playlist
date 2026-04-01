/*
===========================================================
Lesson 23 - Foreach Loops
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _23._Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is a Foreach Loop?
            // ==========================================================
            /*
             A foreach loop is used
             to go through each element
             inside a collection one by one.

             A collection can be:
             - an array
             - a list
             - or other group of values

             Instead of using an index number
             like in a for loop,
             foreach directly gives us
             each item one at a time.

             Syntax:

             foreach (dataType variableName in collection)
             {
                 // code
             }
            */

            // ==========================================================
            // 2. Why Do We Use Foreach?
            // ==========================================================
            /*
             We use foreach when:

             - we want to read each element
             - we do not need the index number
             - we want cleaner and simpler code

             A foreach loop is easier to read
             than a for loop in many cases.

             It is especially useful
             when we only want to display
             or process all elements one by one.
            */

            // ==========================================================
            // 3. Example Array
            // ==========================================================
            /*
             Here we create a string array
             called cars.

             It stores multiple car names.
            */

            string[] cars = { "BMW", "Mustang", "Corvette", "Tesla" };

            // ==========================================================
            // 4. Using a foreach Loop
            // ==========================================================
            /*
             In this example:

             string car
             means:
             each element will be stored
             one by one inside the variable car

             in cars
             means:
             take the elements from the cars array

             So the loop will run once
             for every item in the array.
            */

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // ==========================================================
            // 5. How Foreach Works Step by Step
            // ==========================================================
            /*
             Let's understand it clearly.

             Array:
             { "BMW", "Mustang", "Corvette", "Tesla" }

             First loop:
             car = "BMW"

             Second loop:
             car = "Mustang"

             Third loop:
             car = "Corvette"

             Fourth loop:
             car = "Tesla"

             After the last element,
             the loop stops automatically.

             We do not need to write:
             - starting value
             - condition
             - increment

             foreach handles all of that for us.
            */

            // ==========================================================
            // 6. Foreach vs For Loop
            // ==========================================================
            /*
             A for loop usually looks like this:

             for (int i = 0; i < cars.Length; i++)
             {
                 Console.WriteLine(cars[i]);
             }

             A foreach loop looks like this:

             foreach (string car in cars)
             {
                 Console.WriteLine(car);
             }

             Both loops can display all elements.

             But foreach is shorter
             and easier to understand
             when index numbers are not needed.
            */

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine();

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // ==========================================================
            // 7. Using Foreach with Numbers
            // ==========================================================
            /*
             foreach is not only for strings.

             We can also use it with int arrays
             or other data types.
            */

            int[] numbers = { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            // ==========================================================
            // 8. Calculating Total with Foreach
            // ==========================================================
            /*
             We can also use foreach
             to process values.

             In this example,
             we add all numbers together.

             total starts from 0.

             Then each number is added to total.
            */

            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            Console.WriteLine("Total: " + total);

            Console.WriteLine();

            // ==========================================================
            // 9. Using Foreach with Strings
            // ==========================================================
            /*
             We can also perform operations
             on each string.

             For example:
             - convert to uppercase
             - convert to lowercase
             - check length
            */

            string[] names = { "Ali", "Aysel", "Murad", "Leyla" };

            foreach (string name in names)
            {
                Console.WriteLine("Original: " + name);
                Console.WriteLine("Uppercase: " + name.ToUpper());
                Console.WriteLine("Length: " + name.Length);
                Console.WriteLine();
            }

            // ==========================================================
            // 10. Important Rule of Foreach
            // ==========================================================
            /*
             In a foreach loop,
             the loop variable is read-only in practice
             for the current iteration.

             That means:
             foreach is mainly used
             to read and use values,
             not to modify array elements directly.

             Example:

             foreach (string car in cars)
             {
                 car = "Test";   // not allowed
             }

             This causes an error.

             If you need to change elements
             by index,
             a for loop is usually better.
            */

            // ==========================================================
            // 11. When Should We Use Foreach?
            // ==========================================================
            /*
             Use foreach when:

             - you want to visit every element
             - you do not need the index
             - you want cleaner code
             - you are reading or displaying data

             Use for when:

             - you need the index number
             - you want to modify elements
             - you want more control over the loop
            */

            // ==========================================================
            // 12. Advantages of Foreach
            // ==========================================================
            /*
             Advantages:

             - easier to read
             - shorter syntax
             - less chance of index errors
             - very useful for arrays and collections

             Since we do not manually write indexes,
             we avoid mistakes like:

             i <= array.Length

             which can cause errors in for loops.
            */

            // ==========================================================
            // 13. Disadvantages of Foreach
            // ==========================================================
            /*
             Foreach is very useful,
             but it also has some limits.

             Disadvantages:

             - no direct index access
             - not ideal when modifying elements
             - less flexible than for in some situations

             So foreach is simple,
             but not always the best choice.
            */

            // ==========================================================
            // 14. Final Summary
            // ==========================================================
            /*
             In this lesson, we learned:

             - what a foreach loop is
             - how foreach works
             - how to use it with arrays
             - how to use it with strings and numbers
             - the difference between foreach and for

             foreach loop:
             - goes through each element one by one
             - is simple and clean
             - is best when index is not needed

             for loop:
             - uses index numbers
             - gives more control
             - is better when changing elements
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}