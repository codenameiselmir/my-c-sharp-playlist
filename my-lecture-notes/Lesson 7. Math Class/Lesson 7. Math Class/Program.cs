/*
===========================================================
Lesson 7 - Math Class
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is Math class?
2) Common Math methods
3) Math constants
*/

/*
1) What is Math Class?

Math is a built-in class in C#.

It provides mathematical functions like:
- Square root
- Power
- Absolute value
- Rounding
- Maximum and Minimum

Math methods are static.
That means we do not create an object.
We use them like this:

Math.MethodName()
*/

namespace Lesson_7._Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math.Max() → Returns the larger number
            int max = Math.Max(10, 20);
            Console.WriteLine("Max: " + max);

            // Math.Min() → Returns the smaller number
            int min = Math.Min(10, 20);
            Console.WriteLine("Min: " + min);

            // Math.Sqrt() → Square root
            double sqrt = Math.Sqrt(64);
            Console.WriteLine("Square Root of 64: " + sqrt);

            // Math.Abs() → Absolute value (removes negative sign)
            int absValue = Math.Abs(-25);
            Console.WriteLine("Absolute value: " + absValue);

            // Math.Round() → Rounds a number
            double rounded = Math.Round(5.67);
            Console.WriteLine("Rounded value: " + rounded);

            // Math.Pow() → Power (base, exponent)
            double power = Math.Pow(2, 3);
            Console.WriteLine("2 to the power of 3: " + power);

            /*
            2) Math Constants

            Math.PI → 3.14159265358979
            Math.E  → 2.71828182845905
            */

            Console.WriteLine("PI value: " + Math.PI);
            Console.WriteLine("E value: " + Math.E);


            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}