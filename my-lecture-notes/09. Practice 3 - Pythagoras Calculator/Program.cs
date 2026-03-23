/*
===========================================================
Practice 3 - Pythagoras Calculator Program
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// Lesson Overview
// ==========================================================
/*
 In this lesson we will learn:

 1. What is the Pythagorean Theorem?
 2. How to use Math.Pow()
 3. How to use Math.Sqrt()
 4. Combining everything we learned so far
*/

// ==========================================================
// 1. What is the Pythagorean Theorem?
// ==========================================================
/*
 The Pythagorean Theorem formula is:

 a² + b² = c²

 If we want to find the hypotenuse (c), we use:

 c = √(a² + b²)

 This formula works only for right triangles.
*/

namespace _09._Practice_3___Pythagoras_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Step 1: Ask user to enter Side A
            // ==========================================================
            Console.Write("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            // ==========================================================
            // 3. Step 2: Ask user to enter Side B
            // ==========================================================
            Console.Write("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            // ==========================================================
            // 4. Step 3: Square both sides
            // ==========================================================
            /*
             a² and b²
            */
            double squareA = Math.Pow(sideA, 2);
            double squareB = Math.Pow(sideB, 2);

            // ==========================================================
            // 5. Step 4: Add the squares
            // ==========================================================
            double sumOfSquares = squareA + squareB;

            // ==========================================================
            // 6. Step 5: Take the square root
            // ==========================================================
            double hypotenuse = Math.Sqrt(sumOfSquares);

            // ==========================================================
            // 7. Step 6: Display the result
            // ==========================================================
            Console.WriteLine();
            Console.WriteLine("The hypotenuse (c) is: " + hypotenuse);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
