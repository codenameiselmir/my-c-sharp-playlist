/*
===========================================================
Lesson 9 - Pythagoras Calculator Program
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is the Pythagorean Theorem?
2) How to use Math.Pow()
3) How to use Math.Sqrt()
4) Combining everything we learned so far
*/

/*
1) What is the Pythagorean Theorem?

The Pythagorean Theorem formula:

a² + b² = c²

If we want to find the hypotenuse (c):

c = √(a² + b²)

This works only for right triangles.
*/

namespace Lesson_9._Pythagoras_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Step 1: Ask user to enter Side A
            */

            Console.Write("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            /*
            Step 2: Ask user to enter Side B
            */

            Console.Write("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            /*
            Step 3: Square both sides
            a² and b²
            */

            double squareA = Math.Pow(sideA, 2);
            double squareB = Math.Pow(sideB, 2);

            /*
            Step 4: Add the squares
            */

            double sumOfSquares = squareA + squareB;

            /*
            Step 5: Take the square root
            */

            double hypotenuse = Math.Sqrt(sumOfSquares);

            /*
            Step 6: Display the result
            */

            Console.WriteLine();
            Console.WriteLine("The hypotenuse (c) is: " + hypotenuse);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}