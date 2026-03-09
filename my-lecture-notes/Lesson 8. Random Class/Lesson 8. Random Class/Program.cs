/*
===========================================================
Lesson 8 - Random Class
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is Random class?
2) How to generate random numbers
3) Random numbers with range
4) Random double numbers
*/

/*
1) What is Random Class?

Random is a built-in class in C#.

It is used to generate random numbers.

To use Random, we must create an object:

Random random = new Random();
*/

namespace Lesson_8._Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Random object
            Random random = new Random();


            /*
            2) Generate Random Integer

            random.Next() → returns non-negative random integer
            */

            int number1 = random.Next();
            Console.WriteLine("Random number: " + number1);


            /*
            3) Random Number with Range

            random.Next(min, max)

            Important:
            - min is included
            - max is NOT included
            */

            int number2 = random.Next(1, 10);
            Console.WriteLine("Random number between 1 and 9: " + number2);


            /*
            4) Random Double

            random.NextDouble()

            Returns a random number between:
            0.0 and 1.0
            */

            double number3 = random.NextDouble();
            Console.WriteLine("Random double (0.0 - 1.0): " + number3);


            /*
            Example: Simple Dice Game
            */

            int dice = random.Next(1, 7);
            Console.WriteLine("Dice rolled: " + dice);


            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}