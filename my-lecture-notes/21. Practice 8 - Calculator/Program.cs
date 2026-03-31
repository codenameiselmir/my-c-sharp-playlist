/*
===========================================================
Practice 8: Calculator Console App
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
Tutorial:
In this practice, we build a Calculator Console App step by step.

The user enters:
- full name
- main operation choice
- arithmetic operation or math class choice
- numbers for calculation

Then the program:
- checks that important input is not empty
- validates menu choices
- uses switch-case to choose the main operation
- uses TryParse to safely convert text into numbers
- uses arithmetic operators to calculate results
- uses Math class methods
- uses Random class to create a lucky number
- uses string methods to transform the user's full name
- uses if / else to handle special cases such as division by zero
- uses while loops to repeat until valid input is entered
*/

using System;

namespace _21._Practice_8___Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Displaying the Program Title
            // ==========================================================
            /*
             We start by printing the title of the program.
            */

            Console.WriteLine("=====================================");
            Console.WriteLine("         C# CALCULATOR APP           ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // ==========================================================
            // 2. Asking for the User's Full Name
            // ==========================================================
            /*
             We ask the user to enter their full name.

             We use a while loop to make sure
             the user does not leave the input empty.
            */

            string fullName;

            do
            {
                Console.Write("Enter your full name: ");
                fullName = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(fullName));

            Console.WriteLine();

            /*
             Here we use string methods
             to show different versions of the full name.
            */

            Console.WriteLine($"Your full name is: {fullName}");
            Console.WriteLine($"Your full name with uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Your full name with lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your full name with underscore: {fullName.Replace(" ", "_")}");

            Console.WriteLine();

            // ==========================================================
            // 3. Displaying the Main Menu
            // ==========================================================
            /*
             Now we show the main menu.

             The user must choose one option
             between 1 and 3.
            */

            Console.WriteLine("Operations:");
            Console.WriteLine("1 - Arithmetic Operations");
            Console.WriteLine("2 - Math Classes");
            Console.WriteLine("3 - Find Lucky Number");
            Console.WriteLine();

            int operation;

            /*
             We use TryParse to safely convert text into integer.

             The loop continues while:
             - conversion fails
             OR
             - the number is outside the valid range
            */

            do
            {
                Console.Write("Which operation do you want? ");
            }
            while (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 3);

            Console.WriteLine();

            // ==========================================================
            // 4. Main Switch-Case
            // ==========================================================
            /*
             switch checks the selected main operation.
            */

            switch (operation)
            {
                case 1:
                    // ==================================================
                    // 5. Arithmetic Operations Menu
                    // ==================================================
                    /*
                     In this section,
                     the user chooses an arithmetic operation.
                    */

                    Console.WriteLine("Arithmetic Operations:");
                    Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtraction");
                    Console.WriteLine("3 - Multiply");
                    Console.WriteLine("4 - Divide");
                    Console.WriteLine();

                    int arithmeticChoice;

                    do
                    {
                        Console.Write("Which arithmetic operation do you want? ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out arithmeticChoice) || arithmeticChoice < 1 || arithmeticChoice > 4);

                    Console.WriteLine();

                    /*
                     We ask for two numbers.

                     Again, we use TryParse
                     so the program does not crash
                     if the user enters invalid text.
                    */

                    double firstNumber;
                    double secondNumber;

                    do
                    {
                        Console.Write("Enter your first number: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out firstNumber));

                    do
                    {
                        Console.Write("Enter your second number: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out secondNumber));

                    Console.WriteLine();

                    // ==================================================
                    // 6. Arithmetic Calculations
                    // ==================================================
                    /*
                     Here we calculate the result
                     using arithmetic operators.
                    */

                    switch (arithmeticChoice)
                    {
                        case 1:
                            Console.WriteLine($"Result is: {firstNumber + secondNumber}");
                            break;

                        case 2:
                            Console.WriteLine($"Result is: {firstNumber - secondNumber}");
                            break;

                        case 3:
                            Console.WriteLine($"Result is: {firstNumber * secondNumber}");
                            break;

                        case 4:
                            /*
                             We must check division by zero.

                             If the second number is 0,
                             division is not allowed.
                            */

                            if (secondNumber == 0)
                            {
                                Console.WriteLine("You cannot divide by zero.");
                            }
                            else
                            {
                                Console.WriteLine($"Result is: {firstNumber / secondNumber}");
                            }
                            break;
                    }

                    break;

                case 2:
                    // ==================================================
                    // 7. Math Classes Menu
                    // ==================================================
                    /*
                     In this section,
                     the user chooses a Math class method.
                    */

                    Console.WriteLine("Math Classes:");
                    Console.WriteLine("1 - Abs");
                    Console.WriteLine("2 - Pow");
                    Console.WriteLine("3 - Sqrt");
                    Console.WriteLine("4 - Round");
                    Console.WriteLine("5 - Floor");
                    Console.WriteLine("6 - Ceiling");
                    Console.WriteLine("7 - Max");
                    Console.WriteLine("8 - Min");
                    Console.WriteLine();

                    int mathChoice;

                    do
                    {
                        Console.Write("Which math operation do you want? ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out mathChoice) || mathChoice < 1 || mathChoice > 8);

                    Console.WriteLine();

                    // ==================================================
                    // 8. Math Class Operations
                    // ==================================================
                    /*
                     Different math methods
                     need different numbers of inputs.
                    */

                    switch (mathChoice)
                    {
                        case 1:
                            double absNumber;

                            do
                            {
                                Console.Write("Enter a number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out absNumber));

                            Console.WriteLine($"Result is: {Math.Abs(absNumber)}");
                            break;

                        case 2:
                            double baseNumber;
                            double exponentNumber;

                            do
                            {
                                Console.Write("Enter the base number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out baseNumber));

                            do
                            {
                                Console.Write("Enter the exponent: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out exponentNumber));

                            Console.WriteLine($"Result is: {Math.Pow(baseNumber, exponentNumber)}");
                            break;

                        case 3:
                            double sqrtNumber;

                            do
                            {
                                Console.Write("Enter a number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out sqrtNumber));

                            if (sqrtNumber < 0)
                            {
                                Console.WriteLine("You cannot calculate square root of a negative number.");
                            }
                            else
                            {
                                Console.WriteLine($"Result is: {Math.Sqrt(sqrtNumber)}");
                            }

                            break;

                        case 4:
                            double roundNumber;

                            do
                            {
                                Console.Write("Enter a number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out roundNumber));

                            Console.WriteLine($"Result is: {Math.Round(roundNumber)}");
                            break;

                        case 5:
                            double floorNumber;

                            do
                            {
                                Console.Write("Enter a number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out floorNumber));

                            Console.WriteLine($"Result is: {Math.Floor(floorNumber)}");
                            break;

                        case 6:
                            double ceilingNumber;

                            do
                            {
                                Console.Write("Enter a number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out ceilingNumber));

                            Console.WriteLine($"Result is: {Math.Ceiling(ceilingNumber)}");
                            break;

                        case 7:
                            double maxNumber1;
                            double maxNumber2;

                            do
                            {
                                Console.Write("Enter first number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out maxNumber1));

                            do
                            {
                                Console.Write("Enter second number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out maxNumber2));

                            Console.WriteLine($"Result is: {Math.Max(maxNumber1, maxNumber2)}");
                            break;

                        case 8:
                            double minNumber1;
                            double minNumber2;

                            do
                            {
                                Console.Write("Enter first number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out minNumber1));

                            do
                            {
                                Console.Write("Enter second number: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out minNumber2));

                            Console.WriteLine($"Result is: {Math.Min(minNumber1, minNumber2)}");
                            break;
                    }

                    break;

                case 3:
                    // ==================================================
                    // 9. Lucky Number
                    // ==================================================
                    /*
                     Random class is used
                     to generate a lucky number.
                    */

                    Random random = new Random();
                    int luckyNumber = random.Next(1, 101);

                    Console.WriteLine($"Your lucky number is: {luckyNumber}");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}