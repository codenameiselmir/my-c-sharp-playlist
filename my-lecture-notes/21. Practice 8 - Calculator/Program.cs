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
- can view operation history
- can view arithmetic data in table format
- can explore Array methods

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
- uses arrays to store operation history
- uses multidimensional arrays to store arithmetic table data
- uses Array methods like Copy, Sort, Reverse, IndexOf and Clear

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
- Arrays
- Multidimensional Arrays
- Array Methods
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
            // 3. Preparing Arrays and Control Variables
            // ==========================================================
            /*
             Here we prepare arrays
             to store operation history.

             operationHistory stores operation names.
             resultHistory stores operation results.

             historyCount keeps track of
             how many operations were stored.
            */

            string[] operationHistory = new string[20];
            double[] resultHistory = new double[20];
            int historyCount = 0;

            /*
             arithmeticNames stores arithmetic operation names.

             arithmeticTable is a multidimensional array.

             It stores:
             [row, 0] -> first number
             [row, 1] -> second number
             [row, 2] -> result

             arithmeticCount keeps track of
             how many arithmetic operations were saved.
            */

            string[] arithmeticNames = new string[20];
            double[,] arithmeticTable = new double[20, 3];
            int arithmeticCount = 0;

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
                Console.WriteLine("6. Show Operation History");
                Console.WriteLine("7. Show Arithmetic Table");
                Console.WriteLine("8. Show Array Methods Demo");
                Console.WriteLine("9. Exit");
                Console.WriteLine();

                Console.Write("Choose your operation (1-9): ");
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
                       operationText != "6" &&
                       operationText != "7" &&
                       operationText != "8" &&
                       operationText != "9")
                {
                    Console.Write("Invalid input! Choose your operation (1-9): ");
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

                        /*
                         If the arithmetic operation is valid,
                         we save it into normal arrays
                         and also into the multidimensional array.
                        */

                        if (isArithmeticValid == true)
                        {
                            if (historyCount < operationHistory.Length)
                            {
                                operationHistory[historyCount] = arithmeticOperationName;
                                resultHistory[historyCount] = arithmeticResult;
                                historyCount++;
                            }

                            if (arithmeticCount < arithmeticNames.Length)
                            {
                                arithmeticNames[arithmeticCount] = arithmeticOperationName;
                                arithmeticTable[arithmeticCount, 0] = firstNumber;
                                arithmeticTable[arithmeticCount, 1] = secondNumber;
                                arithmeticTable[arithmeticCount, 2] = arithmeticResult;
                                arithmeticCount++;
                            }
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

                        if (historyCount < operationHistory.Length)
                        {
                            operationHistory[historyCount] = "Power";
                            resultHistory[historyCount] = powerResult;
                            historyCount++;
                        }

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

                        if (historyCount < operationHistory.Length)
                        {
                            operationHistory[historyCount] = "Absolute Value";
                            resultHistory[historyCount] = absoluteNumber;
                            historyCount++;
                        }

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

                            if (historyCount < operationHistory.Length)
                            {
                                operationHistory[historyCount] = "Square Root";
                                resultHistory[historyCount] = 0;
                                historyCount++;
                            }
                        }
                        else
                        {
                            double guess = squareRootNumber / 2;

                            for (int i = 1; i <= 20; i++)
                            {
                                guess = (guess + (squareRootNumber / guess)) / 2;
                            }

                            Console.WriteLine($"Square root: {guess}");

                            if (historyCount < operationHistory.Length)
                            {
                                operationHistory[historyCount] = "Square Root";
                                resultHistory[historyCount] = guess;
                                historyCount++;
                            }
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

                        if (historyCount < operationHistory.Length)
                        {
                            operationHistory[historyCount] = "Lucky Number";
                            resultHistory[historyCount] = luckyNumber;
                            historyCount++;
                        }

                        break;

                    case "6":
                        // ==================================================
                        // 13. Showing Operation History with Arrays
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("Operation History");
                        Console.WriteLine();

                        /*
                         If no operation was performed yet,
                         we show a message.

                         Otherwise,
                         we print all saved history items.
                        */

                        if (historyCount == 0)
                        {
                            Console.WriteLine("There is no operation history yet.");
                        }
                        else
                        {
                            for (int i = 0; i < historyCount; i++)
                            {
                                Console.WriteLine($"{i + 1}. {operationHistory[i]} = {resultHistory[i]}");
                            }
                        }

                        break;

                    case "7":
                        // ==================================================
                        // 14. Showing Arithmetic Table
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("Arithmetic Table");
                        Console.WriteLine();

                        /*
                         This section shows the content
                         of the multidimensional array.

                         Each row is one arithmetic operation.
                        */

                        if (arithmeticCount == 0)
                        {
                            Console.WriteLine("There is no arithmetic operation yet.");
                        }
                        else
                        {
                            Console.WriteLine("Operation\tFirst\tSecond\tResult");

                            for (int i = 0; i < arithmeticCount; i++)
                            {
                                Console.WriteLine($"{arithmeticNames[i]}\t{arithmeticTable[i, 0]}\t{arithmeticTable[i, 1]}\t{arithmeticTable[i, 2]}");
                            }
                        }

                        break;

                    case "8":
                        // ==================================================
                        // 15. Demonstrating Array Methods
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("Array Methods Demo");
                        Console.WriteLine();

                        /*
                         In this section,
                         we demonstrate useful Array methods.

                         We only do this
                         if there is at least one saved operation.
                        */

                        if (historyCount == 0)
                        {
                            Console.WriteLine("You need at least one operation for the array demo.");
                        }
                        else
                        {
                            // --------------------------------------------------
                            // Array.Copy()
                            // --------------------------------------------------
                            /*
                             Array.Copy() copies data
                             from one array to another.
                            */

                            string[] copiedOperations = new string[historyCount];
                            Array.Copy(operationHistory, copiedOperations, historyCount);

                            Console.WriteLine("Copied operations:");
                            for (int i = 0; i < copiedOperations.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {copiedOperations[i]}");
                            }

                            Console.WriteLine();

                            // --------------------------------------------------
                            // Array.Sort()
                            // --------------------------------------------------
                            /*
                             Array.Sort() sorts an array
                             from smallest to biggest.
                            */

                            double[] copiedResults = new double[historyCount];
                            Array.Copy(resultHistory, copiedResults, historyCount);

                            Array.Sort(copiedResults);

                            Console.WriteLine("Sorted results (smallest to biggest):");
                            for (int i = 0; i < copiedResults.Length; i++)
                            {
                                Console.WriteLine(copiedResults[i]);
                            }

                            Console.WriteLine();

                            // --------------------------------------------------
                            // Array.Reverse()
                            // --------------------------------------------------
                            /*
                             Array.Reverse() reverses
                             the order of the array.
                            */

                            Array.Reverse(copiedResults);

                            Console.WriteLine("Reversed results (biggest to smallest):");
                            for (int i = 0; i < copiedResults.Length; i++)
                            {
                                Console.WriteLine(copiedResults[i]);
                            }

                            Console.WriteLine();

                            // --------------------------------------------------
                            // Array.IndexOf()
                            // --------------------------------------------------
                            /*
                             Array.IndexOf() finds
                             the first matching item
                             and returns its index.

                             If not found,
                             it returns -1.
                            */

                            int foundIndex = Array.IndexOf(operationHistory, "Addition");

                            if (foundIndex != -1 && foundIndex < historyCount)
                            {
                                Console.WriteLine($"First 'Addition' was found at index: {foundIndex}");
                            }
                            else
                            {
                                Console.WriteLine("Addition was not found in history.");
                            }

                            Console.WriteLine();

                            // --------------------------------------------------
                            // Array.Clear()
                            // --------------------------------------------------
                            /*
                             Array.Clear() clears items
                             inside the selected range.

                             For string arrays,
                             values become null.
                            */

                            string[] clearedOperations = new string[historyCount];
                            Array.Copy(operationHistory, clearedOperations, historyCount);
                            Array.Clear(clearedOperations, 0, clearedOperations.Length);

                            Console.WriteLine("After Array.Clear() on copied array:");
                            for (int i = 0; i < clearedOperations.Length; i++)
                            {
                                Console.WriteLine(clearedOperations[i]);
                            }
                        }

                        break;

                    case "9":
                        // ==================================================
                        // 16. Exiting the Program
                        // ==================================================
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        isRunning = false;
                        break;
                }

                // ======================================================
                // 17. Printing a Decorative Border with Nested Loops
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