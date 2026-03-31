/*
===========================================================
Practice 6: Number Guessing Game
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
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
===========================================================
*/

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

            This makes the screen look cleaner
            and easier to read.
            */

            Console.WriteLine("=====================================");
            Console.WriteLine("         NUMBER GUESSING GAME        ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // ==========================================================
            // 2. Asking for the User's Full Name and Age
            // ==========================================================

            /*
            Console.Write() prints text
            and keeps the cursor on the same line.

            Console.ReadLine() waits for the user
            to type something and press Enter.

            The entered value is stored
            inside the fullName variable.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            /*
            We use a while loop here. A while loop checks the condition first.

            If the condition is true, the loop runs.
            If the condition is false, the loop stops.

            Trim() removes spaces from the beginning
            and end of the text.

            That means if the user enters:
            - nothing
            - or only spaces
            the program will ask again.
            */

            while (fullName.Trim() == "")
            {
                Console.Write("Name cannot be empty. Enter your full name: ");
                fullName = Console.ReadLine();
            }

            /*
            Console.ReadLine() always returns text. So even when the user enters a number,
            we still receive it as a string. That is why we first store the input inside ageText.
            Then we convert it to int by using Convert.ToInt32().
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
            // 3. Using String Methods
            // ==========================================================

            /*
            Now we display the user's name
            in different formats.

            ToUpper()     -> converts all letters to uppercase
            ToLower()     -> converts all letters to lowercase
            Replace()     -> replaces one part with another
            Length        -> returns the number of characters

            These are examples of string methods.
            */

            Console.WriteLine($"Hello! {fullName}");
            Console.WriteLine($"Your age: {age}");
            Console.WriteLine($"Your name in uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Your name in lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your name with underscore: {fullName.Replace(" ", "_")}");
            Console.WriteLine($"Your name length: {fullName.Length}");

            Console.WriteLine();

            // ==========================================================
            // 4. Letting the User Choose Difficulty
            // ==========================================================

            /*
            Here we show 3 difficulty options.

            The user enters:
            1 for Easy
            2 for Medium
            3 for Hard

            The input comes as text first,
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
            We use a while loop with logical operators. This helps us accept only 1, 2, or 3.

            option < 1 || option > 3

            So the condition becomes true if:
            - option is smaller than 1
            OR
            - option is bigger than 3
            */

            while (option < 1 || option > 3)
            {
                Console.Write("Invalid input! Please choose between 1-3: ");
                optionText = Console.ReadLine();
                option = Convert.ToInt32(optionText);
            }

            Console.WriteLine();

            // ==========================================================
            // 5. Creating the Secret Number
            // ==========================================================
            
            /*
            Random class is used to generate random numbers.

            We create an object:
            Random random = new Random();

            secretNumber stores the hidden number
            that the player must guess.

            maxNumber stores the maximum value
            depending on the chosen difficulty.
            */

            Random random = new Random();
            int secretNumber = 0;
            int maxNumber = 0;

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
            // 6. Variables for the Guessing Phase
            // ==========================================================
            
            /*
            guess stores the player's guess.

            attempts counts how many guesses
            the player has made.

            We start attempts from 0,
            because the counting will happen
            inside the do..while loop.
            */

            int guess = 0;
            int attempts = 0;

            // ==========================================================
            // 7. Main Game Loop with do..while
            // ==========================================================
            
            /*
            Here we use do..while instead of taking
            the first guess outside the loop.

            Why?

            Because in this game,
            the user must enter at least one guess.

            So do..while is a very good choice.

            The code inside do runs first.

            Then the condition is checked at the end:

            while (guess != secretNumber)

            != means "not equal to"

            So the loop continues
            while the guessed number is not correct.
            */

            do
            {
                /*
                 First, we ask the user for a guess.
                */

                Console.Write("Enter your guess: ");
                string guessText = Console.ReadLine();
                guess = Convert.ToInt32(guessText);

                /*
                 We still use a while loop inside this section.

                 This while loop validates the range.

                 Example:
                 - Easy: 1 to 10
                 - Medium: 1 to 50
                 - Hard: 1 to 100

                 If the guess is outside the allowed range,
                 the program keeps asking again.
                */

                while (guess < 1 || guess > maxNumber)
                {
                    Console.Write($"Invalid guess! Enter a number between 1 and {maxNumber}: ");
                    guessText = Console.ReadLine();
                    guess = Convert.ToInt32(guessText);
                }

                attempts++;

                /*
                 If the guess is not correct,
                 we guide the player.

                 if the guess is smaller than the secret number,
                 we print "Too low!"

                 otherwise, if it is not equal and not smaller,
                 it must be bigger,
                 so we print "Too high!"
                */

                if (guess != secretNumber)
                {
                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too high!");
                    }

                    Console.WriteLine();
                }

            } while (guess != secretNumber);

            Console.WriteLine();

            // ==========================================================
            // 8. Why do..while Fits Better Here
            // ==========================================================
            
            /*
            Let's understand why do..while is useful here.

            If we used only while for the main guessing logic,
            we would first need to get a guess
            before the loop starts.

            But with do..while,
            we can place the guessing code directly inside the loop.

            That makes the flow more natural:

            - ask for guess
            - validate guess
            - count the attempt
            - give hint
            - repeat if needed

            Since every player must guess at least once,
            do..while is a better match
            for the main game loop.
            */

            // ==========================================================
            // 9. Showing Final Results
            // ==========================================================
            
            /*
            If the do..while loop stops,
            it means the guess is correct.

            Now we congratulate the player
            and show the final results.
            */

            Console.WriteLine($"Congratulations, {fullName}!");
            Console.WriteLine($"You guessed the number: {secretNumber}");
            Console.WriteLine($"Attempts: {attempts}");

            /*
            Here we use Math class.

            Math.Pow(secretNumber, 2)
            means secretNumber to the power of 2.

            Math.Sqrt(secretNumber)
            means square root of secretNumber.
            */

            Console.WriteLine($"Secret number squared: {Math.Pow(secretNumber, 2)}");
            Console.WriteLine($"Square root of secret number: {Math.Sqrt(secretNumber)}");

            // ==========================================================
            // 10. Important Notes
            // ==========================================================
            
            /*
            - while checks the condition first

            - do..while checks the condition after

            - while may run zero times

            - do..while always runs at least one time

            - In this project:
              * while is used for validation
              * do..while is used for the main guessing loop

            - This combination is common in real programs

            - Always be careful with loop conditions

            - Infinite loops happen if the condition
              never becomes false
            */

            // ==========================================================
            // 11. Final Summary
            // ==========================================================
            
            /*
            In this practice, we learned how to combine
            many C# topics inside one project.

            We used:
            - variables
            - input and output
            - type conversion
            - string methods
            - switch-case
            - Random class
            - Math class
            - if / else
            - while loop
            - do..while loop

            The most important loop difference is:

            while:
            - condition first
            - may not run at all

            do..while:
            - code first
            - always runs at least once

            In a guessing game,
            do..while is a very practical choice
            for the main game logic.
            */

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
