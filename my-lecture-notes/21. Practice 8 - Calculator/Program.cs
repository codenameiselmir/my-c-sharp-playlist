/*
===========================================================
Practice 8: Calculator Console App
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Tutorial:
In this practice, we build a Calculator Console App step by step.

The user:
- enters full name
- chooses an operation from the menu
- performs different mathematical operations
- can find a lucky number

Then the program:
- checks that important input is not empty
- validates menu choices
- uses switch-case to choose operations
- uses TryParse to safely convert text into numbers
- uses arithmetic operators to calculate results
- uses if / else to validate special cases
- uses Random class to create a lucky number
- uses while loops to keep the app running
- uses for loops to print decorations
- uses nested loops to print a border

Topics used in this project:
- Console.Write() and Console.WriteLine()
- Console.ReadLine()
- Variables
- Type Casting
- Arithmetic Operators
- Random Class
- String Methods
- If and Else
- Switch and Case
- Logical Operators
- While Loops
- For Loops
- Nested Loops
- TryParse and Parse
===========================================================
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
             We start by printing the title
             of the calculator program.
            */

            Console.WriteLine("========================================");
            Console.WriteLine("         C# CALCULATOR CONSOLE APP      ");
            Console.WriteLine("========================================");
            Console.WriteLine();

            // ==========================================================
            // 2. Asking for the User's Full Name
            // ==========================================================
            /*
             Console.Write() prints text
             without moving to the next line.

             Console.ReadLine() waits for the user
             to type something and press Enter.

             We store the entered value
             inside the variable fullName.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            /*
             We use a while loop to make sure
             the user does not leave the name empty.

             Trim() removes spaces from the beginning
             and end of the text.

             So if the user enters nothing,
             or only spaces,
             the program asks again.
            */

            while (fullName.Trim() == "")
            {
                Console.Write("Invalid input! Please enter your full name: ");
                fullName = Console.ReadLine();
            }

            // ==========================================================
            // 3. Preparing the Control Variable
            // ==========================================================
            /*
             isRunning controls the main menu loop.

             While it is true,
             the program keeps running.
            */

            bool isRunning = true;

            // ==========================================================
            // 4. Starting the Main Menu Loop
            // ==========================================================
            /*
             This while loop keeps the program alive
             until the user chooses Exit.
            */

            while (isRunning)
            {
                Console.Clear();

                // ======================================================
                // 5. Printing Welcome Information
                // ======================================================
                /*
                 We use for loops to print
                 a decorative line of stars.
                */

                for (int i = 1; i <= 20; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine($"Hey! {fullName}");
                Console.WriteLine($"Your name with uppercase: {fullName.ToUpper()}");
                Console.WriteLine($"Your name with lowercase: {fullName.ToLower()}");
                Console.WriteLine($"Your name with underscore: {fullName.Replace(" ", "_")}");
                Console.WriteLine($"Your name length: {fullName.Length}");

                for (int i = 1; i <= 20; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();

                // ======================================================
                // 6. Displaying the Main Menu
                // ======================================================
                /*
                 Now we show all menu options.
                */

                Console.WriteLine("1. Arithmetic Operations");
                Console.WriteLine("2. Find a Power of a Number");
                Console.WriteLine("3. Find an Absolute Value");
                Console.WriteLine("4. Find a Square Root");
                Console.WriteLine("5. Find Your Lucky Number");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                Console.Write("Choose your operation (1-6): ");
                string operationText = Console.ReadLine().Trim();

                /*
                 We validate the input by using a while loop
                 and logical operators.

                 The loop continues while
                 the entered value is not one of the valid choices.
                */

                while (operationText != "1" &&
                       operationText != "2" &&
                       operationText != "3" &&
                       operationText != "4" &&
                       operationText != "5" &&
                       operationText != "6")
                {
                    Console.Write("Invalid input! Choose your operation (1-6): ");
                    operationText = Console.ReadLine().Trim();
                }

                // ======================================================
                // 7. Using Switch-Case for Main Menu Selection
                // ======================================================
                /*
                 switch checks which menu option
                 the user selected.
                */

                switch (operationText)
                {
                    case "1":
                        // ==================================================
                        // 8. Arithmetic Operations Menu
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("You chose Arithmetic Operations!");
                        Console.WriteLine("1. Addition");
                        Console.WriteLine("2. Subtraction");
                        Console.WriteLine("3. Multiply");
                        Console.WriteLine("4. Divide");
                        Console.WriteLine();

                        Console.Write("Choose arithmetic operation (1-4): ");
                        string arithmeticChoice = Console.ReadLine().Trim();

                        while (arithmeticChoice != "1" &&
                               arithmeticChoice != "2" &&
                               arithmeticChoice != "3" &&
                               arithmeticChoice != "4")
                        {
                            Console.Write("Invalid input! Choose arithmetic operation (1-4): ");
                            arithmeticChoice = Console.ReadLine().Trim();
                        }

                        /*
                         We now ask for two numbers.

                         TryParse is safer than Convert
                         because it does not crash
                         when the user enters letters.
                        */

                        Console.Write("Enter your first number: ");
                        string firstNumberText = Console.ReadLine().Trim();
                        double firstNumber;

                        while (!double.TryParse(firstNumberText, out firstNumber))
                        {
                            Console.Write("Invalid input! Enter a valid first number: ");
                            firstNumberText = Console.ReadLine().Trim();
                        }

                        Console.Write("Enter your second number: ");
                        string secondNumberText = Console.ReadLine().Trim();
                        double secondNumber;

                        while (!double.TryParse(secondNumberText, out secondNumber))
                        {
                            Console.Write("Invalid input! Enter a valid second number: ");
                            secondNumberText = Console.ReadLine().Trim();
                        }

                        /*
                         These variables will store
                         the arithmetic operation name
                         and the result.
                        */

                        string arithmeticOperationName = "";
                        double arithmeticResult = 0;
                        bool isArithmeticValid = true;

                        /*
                         switch-case decides which arithmetic action
                         will be performed.
                        */

                        switch (arithmeticChoice)
                        {
                            case "1":
                                arithmeticOperationName = "Addition";
                                arithmeticResult = firstNumber + secondNumber;
                                Console.WriteLine($"Result: {arithmeticResult}");
                                break;

                            case "2":
                                arithmeticOperationName = "Subtraction";
                                arithmeticResult = firstNumber - secondNumber;
                                Console.WriteLine($"Result: {arithmeticResult}");
                                break;

                            case "3":
                                arithmeticOperationName = "Multiply";
                                arithmeticResult = firstNumber * secondNumber;
                                Console.WriteLine($"Result: {arithmeticResult}");
                                break;

                            case "4":
                                arithmeticOperationName = "Divide";

                                /*
                                 Division needs extra validation.

                                 A number cannot be divided by zero.
                                */

                                if (secondNumber == 0)
                                {
                                    Console.WriteLine("You cannot divide by zero.");
                                    isArithmeticValid = false;
                                }
                                else
                                {
                                    arithmeticResult = firstNumber / secondNumber;
                                    Console.WriteLine($"Result: {arithmeticResult}");
                                }
                                break;
                        }

                        break;

                    case "2":
                        // ==================================================
                        // 9. Finding the Power of a Number
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("You chose Power of a Number!");
                        Console.WriteLine();

                        /*
                         We ask for the base number.
                        */

                        Console.Write("Enter the base number: ");
                        string baseNumberText = Console.ReadLine().Trim();
                        double baseNumber;

                        while (!double.TryParse(baseNumberText, out baseNumber))
                        {
                            Console.Write("Invalid input! Enter a valid base number: ");
                            baseNumberText = Console.ReadLine().Trim();
                        }

                        /*
                         We ask for the exponent.

                         Since we use a for loop,
                         exponent is kept as int.
                        */

                        Console.Write("Enter the exponent (0 or greater): ");
                        string exponentText = Console.ReadLine().Trim();
                        int exponent;

                        while (!int.TryParse(exponentText, out exponent) || exponent < 0)
                        {
                            Console.Write("Invalid input! Enter a whole number (0 or greater): ");
                            exponentText = Console.ReadLine().Trim();
                        }

                        /*
                         Power is calculated manually.

                         Example:
                         2^3 = 2 * 2 * 2
                        */

                        double powerResult = 1;

                        for (int i = 1; i <= exponent; i++)
                        {
                            powerResult = powerResult * baseNumber;
                        }

                        Console.WriteLine($"Result: {baseNumber}^{exponent} = {powerResult}");
                        break;

                    case "3":
                        // ==================================================
                        // 10. Finding Absolute Value
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("You chose Absolute Value!");
                        Console.WriteLine();

                        Console.Write("Enter a number: ");
                        string absoluteText = Console.ReadLine().Trim();
                        double absoluteNumber;

                        while (!double.TryParse(absoluteText, out absoluteNumber))
                        {
                            Console.Write("Invalid input! Enter a valid number: ");
                            absoluteText = Console.ReadLine().Trim();
                        }

                        /*
                         If the number is negative,
                         multiply it by -1.
                        */

                        if (absoluteNumber < 0)
                        {
                            absoluteNumber = absoluteNumber * -1;
                        }

                        Console.WriteLine($"Absolute value: {absoluteNumber}");
                        break;

                    case "4":
                        // ==================================================
                        // 11. Finding Square Root
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("You chose Square Root!");
                        Console.WriteLine();

                        Console.Write("Enter a number: ");
                        string squareRootText = Console.ReadLine().Trim();
                        double squareRootNumber;

                        while (!double.TryParse(squareRootText, out squareRootNumber))
                        {
                            Console.Write("Invalid input! Enter a valid number: ");
                            squareRootText = Console.ReadLine().Trim();
                        }

                        /*
                         A negative number does not have
                         a real square root in this project.

                         If the number is valid,
                         we estimate the square root
                         by using a repeated formula.
                        */

                        if (squareRootNumber < 0)
                        {
                            Console.WriteLine("You cannot calculate the square root of a negative number.");
                        }
                        else if (squareRootNumber == 0)
                        {
                            Console.WriteLine("Square root: 0");
                        }
                        else
                        {
                            double guess = squareRootNumber / 2;

                            for (int i = 1; i <= 20; i++)
                            {
                                guess = (guess + (squareRootNumber / guess)) / 2;
                            }

                            Console.WriteLine($"Square root: {guess}");
                        }

                        break;

                    case "5":
                        // ==================================================
                        // 12. Generating a Lucky Number
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("You chose Lucky Number!");
                        Console.WriteLine();

                        /*
                         Random class is used
                         to create a random number.

                         Here we generate a lucky number
                         between 1 and 100.
                        */

                        Random random = new Random();
                        int luckyNumber = random.Next(1, 101);

                        Console.WriteLine($"{fullName}, your lucky number is: {luckyNumber}");
                        break;

                    case "6":
                        // ==================================================
                        // 13. Exiting the Program
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        isRunning = false;
                        break;
                }

                // ======================================================
                // 14. Printing a Decorative Border with Nested Loops
                // ======================================================
                /*
                 Nested loops mean
                 one loop inside another loop.

                 Outer loop controls rows.
                 Inner loop controls columns.
                */

                if (isRunning == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Receipt Border:");

                    for (int row = 1; row <= 3; row++)
                    {
                        for (int column = 1; column <= 5; column++)
                        {
                            Console.Write("* ");
                        }

                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.Write("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}