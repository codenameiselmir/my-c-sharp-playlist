/*
===========================================================
Practice 6: Number Guessing Game
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Tutorial:
In this practice, we build a Number Guessing Game step by step.

The user enters:
- full name
- age
- difficulty level
- guesses

Then the program:
- checks that important input is not empty
- uses string methods to format the user's name
- uses switch-case to choose difficulty
- uses Random class to create a secret number
- uses while loop to keep the game running
- uses if / else to guide the player
- uses Math class to display extra results at the end

Topics used in this project:
- Console.Write() and Console.WriteLine()
- Console.ReadLine()
- Variables
- Type Casting using Convert
- Arithmetic Operators
- Math Class
- Random Class
- String Methods
- If and Else
- Switch and Case
- Logical Operators
- While Loops
===========================================================
*/

using System;

namespace _17._Practice_6___Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Displaying the Game Title
            // ==========================================================
            /*
             We first print the title of the program.

             Console.WriteLine() prints text and moves
             to the next line.

             This helps make the program look cleaner
             and easier for the user to understand.
            */

            Console.WriteLine("=====================================");
            Console.WriteLine("         NUMBER GUESSING GAME        ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // ==========================================================
            // 2. Asking for the User's Full Name
            // ==========================================================
            /*
             Console.Write() prints text on the screen
             but keeps the cursor on the same line.

             Console.ReadLine() waits for the user
             to type something and press Enter.

             We store the entered value inside
             the variable fullName.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            /*
             Here we use a while loop.

             The purpose of this loop is to make sure
             the user does not leave the name empty.

             Trim() removes spaces from the beginning
             and end of the text.

             So if the user enters nothing, or only spaces,
             the program will ask again.
            */

            while (fullName.Trim() == "")
            {
                Console.Write("Name cannot be empty. Enter your full name: ");
                fullName = Console.ReadLine();
            }

            // ==========================================================
            // 3. Asking for the User's Age
            // ==========================================================
            /*
             We ask the user for age as text first.

             Why?
             Because Console.ReadLine() always gives us
             a string.

             Then we convert that string into an integer
             by using Convert.ToInt32().
            */

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            while (ageText.Trim() == "")
            {
                Console.Write("Age cannot be empty. Enter your age: ");
                ageText = Console.ReadLine();
            }

            int age = Convert.ToInt32(ageText);

            Console.WriteLine();

            // ==========================================================
            // 4. Using String Methods
            // ==========================================================
            /*
             Now we display the user's name in different ways.

             ToUpper()     -> changes all letters to uppercase
             ToLower()     -> changes all letters to lowercase
             Replace()     -> replaces one part with another
             Length        -> gives the number of characters

             These are called string methods.
            */

            Console.WriteLine($"Hello! {fullName}");
            Console.WriteLine($"Your name in uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Your name in lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your name with underscore: {fullName.Replace(" ", "_")}");
            Console.WriteLine($"Your name length: {fullName.Length}");

            Console.WriteLine();

            // ==========================================================
            // 5. Letting the User Choose Difficulty
            // ==========================================================
            /*
             Here we show 3 difficulty options.

             The user enters:
             1 for Easy
             2 for Medium
             3 for Hard

             Again, the input comes as text first,
             then we convert it to int.
            */

            Console.WriteLine("Choose difficulty:");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.Write("Enter your choice: ");
            string optionText = Console.ReadLine();
            int option = Convert.ToInt32(optionText);

            /*
             We use a while loop with logical operators.

             option < 1 || option > 3

             || means OR

             So this condition becomes true if:
             - option is smaller than 1
             OR
             - option is bigger than 3

             This helps us accept only 1, 2, or 3.
            */

            while (option < 1 || option > 3)
            {
                Console.Write("Invalid input! Please choose between 1-3: ");
                optionText = Console.ReadLine();
                option = Convert.ToInt32(optionText);
            }

            Console.WriteLine();

            // ==========================================================
            // 6. Creating the Secret Number
            // ==========================================================
            /*
             Random class is used to generate random numbers.

             We create an object:
             Random random = new Random();

             secretNumber will store the hidden number
             that the player must guess.

             maxNumber will store the maximum value
             depending on the difficulty.
            */

            Random random = new Random();
            int secretNumber = 0;
            int maxNumber = 0;

            /*
             Now we use switch-case.

             switch checks the value of option.

             If option is:
             1 -> Easy
             2 -> Medium
             3 -> Hard

             Based on the difficulty, we change:
             - the guessing range
             - the secret random number
            */

            switch (option)
            {
                case 1:
                    Console.WriteLine("You selected Easy.");
                    Console.WriteLine("Guess a number between 1 and 10.");
                    maxNumber = 10;
                    secretNumber = random.Next(1, 11);
                    break;

                case 2:
                    Console.WriteLine("You selected Medium.");
                    Console.WriteLine("Guess a number between 1 and 50.");
                    maxNumber = 50;
                    secretNumber = random.Next(1, 51);
                    break;

                case 3:
                    Console.WriteLine("You selected Hard.");
                    Console.WriteLine("Guess a number between 1 and 100.");
                    maxNumber = 100;
                    secretNumber = random.Next(1, 101);
                    break;
            }

            Console.WriteLine();

            // ==========================================================
            // 7. Getting the First Guess
            // ==========================================================
            /*
             We ask the user to guess the secret number.

             The guess is entered as text first,
             then converted into int.
            */

            Console.Write("Enter your guess: ");
            string guessText = Console.ReadLine();
            int guess = Convert.ToInt32(guessText);

            /*
             We also check if the guess is inside
             the correct range.

             Example:
             - Easy: 1 to 10
             - Medium: 1 to 50
             - Hard: 1 to 100
            */

            while (guess < 1 || guess > maxNumber)
            {
                Console.Write($"Invalid guess! Enter a number between 1 and {maxNumber}: ");
                guessText = Console.ReadLine();
                guess = Convert.ToInt32(guessText);
            }

            /*
             attempts counts how many times
             the player guessed.
            */

            int attempts = 1;

            // ==========================================================
            // 8. Main Game Loop
            // ==========================================================
            /*
             This is the most important part of the game.

             while (guess != secretNumber)

             != means "not equal to"

             So the loop keeps running
             while the guessed number is not correct.
            */

            while (guess != secretNumber)
            {
                /*
                 We use if / else here.

                 If the guess is smaller than the secret number,
                 we say "Too low!"

                 Otherwise, the guess must be bigger,
                 so we say "Too high!"
                */

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }

                /*
                 Then the user gets another chance
                 to guess again.
                */

                Console.Write("Enter your guess again: ");
                guessText = Console.ReadLine();
                guess = Convert.ToInt32(guessText);

                /*
                 We validate the guess again so that
                 the user stays inside the allowed range.
                */

                while (guess < 1 || guess > maxNumber)
                {
                    Console.Write($"Invalid guess! Enter a number between 1 and {maxNumber}: ");
                    guessText = Console.ReadLine();
                    guess = Convert.ToInt32(guessText);
                }

                attempts++;
            }

            Console.WriteLine();

            // ==========================================================
            // 9. Showing Final Results
            // ==========================================================
            /*
             If the loop stops, it means the guess is correct.

             Now we congratulate the player
             and show final results.
            */

            Console.WriteLine($"Congratulations, {fullName}!");
            Console.WriteLine($"You guessed the number: {secretNumber}");
            Console.WriteLine($"Attempts: {attempts}");

            /*
             Here we use Math class.

             Math.Pow(secretNumber, 2)
             means secretNumber to the power of 2

             Math.Sqrt(secretNumber)
             means square root of secretNumber
            */

            Console.WriteLine($"Secret number squared: {Math.Pow(secretNumber, 2)}");
            Console.WriteLine($"Square root of secret number: {Math.Sqrt(secretNumber)}");

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
        }
    }
}