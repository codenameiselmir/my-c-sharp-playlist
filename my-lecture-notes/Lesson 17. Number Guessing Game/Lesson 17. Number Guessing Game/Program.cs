/*
===========================================================
Lesson 17 - Number Guessing Game
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) Combining Random + While Loop
2) Building a simple game
3) Loop until correct answer
*/

/*
Game Logic:

- Computer generates a random number.
- User keeps guessing.
- Loop continues until user guesses correctly.
*/

namespace Lesson_17._Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create random number between 1 and 10
            Random random = new Random();
            int number = random.Next(1, 11);

            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Number Guessing Game!");
            Console.WriteLine("Guess a number between 1 and 10.");

            while (guess != number)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess > number)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low! Try again.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Congratulations! You guessed correctly.");
            Console.WriteLine("Total attempts: " + attempts);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}