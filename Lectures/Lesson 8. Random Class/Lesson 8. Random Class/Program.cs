namespace Lesson_8._Random_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Lesson 8: Random Class in C#
            *
            * The Random class is used to generate pseudo-random numbers.
            * These numbers are commonly used in games, simulations,
            * and applications that require unpredictable results.
            *
            * Important Notes:
            * - The Random class is NOT static.
            * - We must create an instance before using it.
            * - The upper bound in Next(min, max) is exclusive.
            */

            // Create a Random object
            Random random = new Random();

            // Generate a random integer between 0 and int.MaxValue
            int randomNumber1 = random.Next();
            Console.WriteLine("Random number (default range): " + randomNumber1);

            // Generate a random integer between 0 and 9
            int randomNumber2 = random.Next(10);
            Console.WriteLine("Random number between 0 and 9: " + randomNumber2);

            // Generate a random integer between 1 and 6 (dice simulation)
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice roll (1-6): " + diceRoll);

            // Generate a random double between 0.0 and 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double (0.0 - 1.0): " + randomDouble);

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}
