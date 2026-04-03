/*
===========================================================
Practice 10: Calculator V2
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
Tutorial:
In this practice, we build a more advanced Calculator Console App.

The user can:
- enter full name
- see transformed versions of the full name
- perform arithmetic operations
- use Math class methods
- generate a lucky number
- view operation history
- exit the program from the menu
*/

/*
1. Program Flow Overview

This program works with a main menu system.

The program will continue running
until the user selects the Exit option.

Inside the program, we use:
- Menu()       -> to display the main menu
- GetData()    -> to return formatted user information
- Add()        -> to add multiple numbers
- Subtract()   -> to subtract multiple numbers
- Multiply()   -> to multiply multiple numbers
- Divide()     -> to divide multiple numbers
*/

using System;

namespace _31._Practice_10___Calculator_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 2. Asking the User's Full Name
            // ==========================================================
            /*
             At the beginning of the program,
             we ask the user to enter their full name.

             This value will later be used
             inside the GetData() method.
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            /*
             choice stores the selected menu option.

             history array stores previous operations.

             historyCount keeps track of
             how many history items are currently stored.
            */

            string choice = "";

            string[] history = new string[100];
            int historyCount = 0;

            // ==========================================================
            // 3. Starting the Main Menu Loop
            // ==========================================================
            /*
             The loop continues
             until the user selects option 5.

             choice != "5" means:
             keep showing the menu
             until Exit is selected.
            */

            while (choice != "5")
            {
                Console.Clear();

                // Displaying the menu
                Menu();

                Console.WriteLine();

                // Displaying formatted user information
                Console.WriteLine(GetData(fullName));

                Console.WriteLine();
                Console.Write("Choose an option: ");
                choice = Console.ReadLine();

                Console.Clear();

                // ======================================================
                // 4. Main Switch-Case for Menu Selection
                // ======================================================
                /*
                 switch checks which menu option
                 the user selected.
                */

                switch (choice)
                {
                    case "1":
                        // ==================================================
                        // 5. Arithmetic Operations
                        // ==================================================
                        /*
                         In this section,
                         the user selects an arithmetic operator.

                         Then the user decides
                         how many numbers will be entered.

                         These numbers are stored in an array.
                        */

                        Console.WriteLine("Arithmetic Operations selected.");
                        Console.WriteLine();

                        Console.Write("Choose operator (+, -, *, /): ");
                        string op = Console.ReadLine();

                        Console.Write("How many numbers do you want to enter?: ");
                        int count = Convert.ToInt32(Console.ReadLine());

                        double[] numbers = new double[count];

                        /*
                         Here we use a for loop
                         to fill the array with numbers.
                        */

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"Enter number {i + 1}: ");
                            numbers[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        /*
                         Another switch is used
                         to decide which arithmetic method
                         should be called.
                        */

                        switch (op)
                        {
                            case "+":
                                double addResult = Add(numbers);
                                Console.WriteLine($"Result: {addResult}");

                                /*
                                 We store the operation
                                 inside the history array.
                                */

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"{string.Join(" + ", numbers)} = {addResult}";
                                    historyCount++;
                                }
                                break;

                            case "-":
                                double subResult = Subtract(numbers);
                                Console.WriteLine($"Result: {subResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"{string.Join(" - ", numbers)} = {subResult}";
                                    historyCount++;
                                }
                                break;

                            case "*":
                                double mulResult = Multiply(numbers);
                                Console.WriteLine($"Result: {mulResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"{string.Join(" * ", numbers)} = {mulResult}";
                                    historyCount++;
                                }
                                break;

                            case "/":
                                double divResult = Divide(numbers);
                                Console.WriteLine($"Result: {divResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"{string.Join(" / ", numbers)} = {divResult}";
                                    historyCount++;
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid operator.");
                                break;
                        }
                        break;

                    case "2":
                        // ==================================================
                        // 6. Math Class Operations
                        // ==================================================
                        /*
                         In this section,
                         the user selects one of the Math methods.

                         We show a submenu for:
                         - Abs
                         - Pow
                         - Sqrt
                         - Round
                         - Max
                         - Min
                        */

                        Console.WriteLine("Math Class");
                        Console.WriteLine();
                        Console.WriteLine("1. Absolute Value");
                        Console.WriteLine("2. Power");
                        Console.WriteLine("3. Square Root");
                        Console.WriteLine("4. Round");
                        Console.WriteLine("5. Max");
                        Console.WriteLine("6. Min");
                        Console.WriteLine();

                        Console.Write("Choose a math operation: ");
                        string mathChoice = Console.ReadLine();

                        switch (mathChoice)
                        {
                            case "1":
                                /*
                                 Math.Abs()
                                 returns the absolute value of a number.
                                */

                                Console.Write("Enter a number: ");
                                double absNumber = Convert.ToDouble(Console.ReadLine());
                                double absResult = Math.Abs(absNumber);

                                Console.WriteLine($"Result: {absResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Abs({absNumber}) = {absResult}";
                                    historyCount++;
                                }
                                break;

                            case "2":
                                /*
                                 Math.Pow(base, exponent)
                                 returns base raised to the given exponent.
                                */

                                Console.Write("Enter base number: ");
                                double baseNumber = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter exponent: ");
                                double exponent = Convert.ToDouble(Console.ReadLine());

                                double powResult = Math.Pow(baseNumber, exponent);
                                Console.WriteLine($"Result: {powResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Pow({baseNumber}, {exponent}) = {powResult}";
                                    historyCount++;
                                }
                                break;

                            case "3":
                                /*
                                 Math.Sqrt()
                                 calculates the square root of a number.
                                */

                                Console.Write("Enter a number: ");
                                double sqrtNumber = Convert.ToDouble(Console.ReadLine());

                                double sqrtResult = Math.Sqrt(sqrtNumber);
                                Console.WriteLine($"Result: {sqrtResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Sqrt({sqrtNumber}) = {sqrtResult}";
                                    historyCount++;
                                }
                                break;

                            case "4":
                                /*
                                 Math.Round()
                                 rounds a number to the nearest whole number.
                                */

                                Console.Write("Enter a number: ");
                                double roundNumber = Convert.ToDouble(Console.ReadLine());

                                double roundResult = Math.Round(roundNumber);
                                Console.WriteLine($"Result: {roundResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Round({roundNumber}) = {roundResult}";
                                    historyCount++;
                                }
                                break;

                            case "5":
                                /*
                                 Math.Max()
                                 returns the larger of two numbers.
                                */

                                Console.Write("Enter first number: ");
                                double max1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter second number: ");
                                double max2 = Convert.ToDouble(Console.ReadLine());

                                double maxResult = Math.Max(max1, max2);
                                Console.WriteLine($"Result: {maxResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Max({max1}, {max2}) = {maxResult}";
                                    historyCount++;
                                }
                                break;

                            case "6":
                                /*
                                 Math.Min()
                                 returns the smaller of two numbers.
                                */

                                Console.Write("Enter first number: ");
                                double min1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter second number: ");
                                double min2 = Convert.ToDouble(Console.ReadLine());

                                double minResult = Math.Min(min1, min2);
                                Console.WriteLine($"Result: {minResult}");

                                if (historyCount < history.Length)
                                {
                                    history[historyCount] = $"Math.Min({min1}, {min2}) = {minResult}";
                                    historyCount++;
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid math operation.");
                                break;
                        }
                        break;

                    case "3":
                        // ==================================================
                        // 7. Lucky Number
                        // ==================================================
                        /*
                         In this section,
                         we use the Random class
                         to generate a lucky number
                         between 1 and 100.
                        */

                        Console.WriteLine("Find Lucky Number selected.");
                        Console.WriteLine();

                        Random luckyNum = new Random();
                        int luckyResult = luckyNum.Next(1, 101);

                        Console.WriteLine($"Your lucky number is {luckyResult}");

                        if (historyCount < history.Length)
                        {
                            history[historyCount] = $"Lucky Number = {luckyResult}";
                            historyCount++;
                        }
                        break;

                    case "4":
                        // ==================================================
                        // 8. History Section
                        // ==================================================
                        /*
                         Here we display all stored operations.

                         If no operations were performed yet,
                         we show a message.
                        */

                        Console.WriteLine("History selected.");
                        Console.WriteLine();

                        if (historyCount == 0)
                        {
                            Console.WriteLine("No history yet.");
                        }
                        else
                        {
                            for (int i = 0; i < historyCount; i++)
                            {
                                Console.WriteLine($"{i + 1}. {history[i]}");
                            }
                        }
                        break;

                    case "5":
                        // ==================================================
                        // 9. Exiting the Program
                        // ==================================================
                        /*
                         If the user selects 5,
                         the loop ends
                         and the program exits.
                        */

                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        // ==================================================
                        // 10. Invalid Menu Option
                        // ==================================================
                        /*
                         If the user enters something
                         outside the valid options,
                         we show an error message.
                        */

                        Console.WriteLine("Invalid choice. Please select between 1 and 5.");
                        break;
                }

                /*
                 If the user did not choose Exit,
                 the program waits for a key press
                 before returning to the menu.
                */

                if (choice != "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                }
            }
        }

        // ==============================================================
        // 11. Menu Method
        // ==============================================================
        /*
         This method only displays the menu.

         It does not return any value,
         so its return type is void.
        */

        static void Menu()
        {
            Console.WriteLine("Welcome to the Menu!");
            Console.WriteLine();
            Console.WriteLine("1. Arithmetic Operations");
            Console.WriteLine("2. Math Class");
            Console.WriteLine("3. Find Lucky Number");
            Console.WriteLine("4. History");
            Console.WriteLine("5. Exit");
        }

        // ==============================================================
        // 12. GetData Method
        // ==============================================================
        /*
         This method takes fullName as a parameter
         and returns a formatted string.

         Since it sends a value back,
         its return type is string.
        */

        static string GetData(string fullName)
        {
            return $"Hi, {fullName}\n" +
                   $"Your name with uppercase: {fullName.ToUpper()}\n" +
                   $"Your name with lowercase: {fullName.ToLower()}\n" +
                   $"Your name with underscore: {fullName.Replace(" ", "_")}\n" +
                   $"Your name length: {fullName.Length}";
        }

        // ==============================================================
        // 13. Add Method
        // ==============================================================
        /*
         This method uses params.

         params allows the method
         to accept multiple numbers.

         Example:
         Add(10, 20)
         Add(10, 20, 30, 40)

         All numbers are stored
         inside the numbers array.
        */

        static double Add(params double[] numbers)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        // ==============================================================
        // 14. Subtract Method
        // ==============================================================
        /*
         This method subtracts all numbers
         from the first number.

         Example:
         Subtract(20, 5, 3)

         Step 1: 20 - 5 = 15
         Step 2: 15 - 3 = 12
        */

        static double Subtract(params double[] numbers)
        {
            /*
             If no numbers are sent,
             we return 0.
            */

            if (numbers.Length == 0)
            {
                return 0;
            }

            double result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            return result;
        }

        // ==============================================================
        // 15. Multiply Method
        // ==============================================================
        /*
         This method multiplies all numbers together.

         We start with 1
         because multiplying by 1
         does not change the result.
        */

        static double Multiply(params double[] numbers)
        {
            double result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }

            return result;
        }

        // ==============================================================
        // 16. Divide Method
        // ==============================================================
        /*
         This method divides the first number
         by the remaining numbers.

         Example:
         Divide(100, 2, 5)

         Step 1: 100 / 2 = 50
         Step 2: 50 / 5 = 10

         We must also check division by zero.
        */

        static double Divide(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return 0;
                }

                result /= numbers[i];
            }

            return result;
        }
    }
}