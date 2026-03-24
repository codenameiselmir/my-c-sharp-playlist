/*
===========================================================
Practice 5: Smart Menu
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Homework / Task:
Build a console application called Smart Menu.

The program should:
- ask the user for their full name
- ask the user for their age
- ask for their favorite subject
- ask for two exam scores
- use string methods to format text
- perform arithmetic operations
- use Math class methods
- generate a random lucky number and bonus point
- use if and else statements for result checking
- use logical operators in conditions
- use switch and case to display different menu results

Goal:
This practice helps us combine multiple beginner C# topics
in one mini project.
===========================================================
*/

using System;

namespace _15._Practice_5___Smart_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Getting User Information
            // ==========================================================
            /*
             In this project, we ask the user for:
             - full name
             - age
             - favorite subject
             - first exam score
             - second exam score
            */

            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();
            int age = Convert.ToInt32(ageText);

            Console.Write("What is your favorite subject? ");
            string subjectText = Console.ReadLine();

            Console.Write("Enter your first exam score: ");
            string examText1 = Console.ReadLine();
            double exam1 = Convert.ToDouble(examText1);

            Console.Write("Enter your second exam score: ");
            string examText2 = Console.ReadLine();
            double exam2 = Convert.ToDouble(examText2);

            // ==========================================================
            // 2. Random Values
            // ==========================================================
            /*
             Here we create:
             - a lucky number between 1 and 100
             - a bonus point between 1 and 10
            */

            Random random = new Random();
            int luckyNumber = random.Next(1, 101);
            int bonusPoint = random.Next(1, 11);

            // ==========================================================
            // 3. Calculations
            // ==========================================================
            /*
             We calculate:
             - total score
             - average score
            */

            double totalScore = exam1 + exam2;
            double averageScore = totalScore / 2;

            Console.WriteLine();

            // ==========================================================
            // 4. Smart Menu
            // ==========================================================
            /*
             The user chooses which section to display.
            */

            Console.WriteLine("-- Choose an option --");
            Console.WriteLine("1 - Show Profile");
            Console.WriteLine("2 - Show Score");
            Console.WriteLine("3 - Show Final Result");
            Console.WriteLine("4 - Show Lucky Number");

            string optionText = Console.ReadLine();
            int option = Convert.ToInt32(optionText);

            Console.WriteLine();

            // ==========================================================
            // 5. Input Validation
            // ==========================================================
            /*
             We check whether the selected option
             is between 1 and 4.
            */

            if (optionText == "" || option < 1 || option > 4)
            {
                Console.WriteLine("Invalid input. Choose one option from 1 to 4.");
            }
            else
            {
                // ==========================================================
                // 6. Using switch and case
                // ==========================================================
                /*
                 switch checks the selected option
                 and runs the matching case.
                */

                switch (optionText)
                {
                    case "1":
                        // ==========================================================
                        // Show Profile
                        // ==========================================================
                        /*
                         This section displays:
                         - full name
                         - uppercase version
                         - lowercase version
                         - name length
                         - name with underscores
                         - favorite subject
                        */

                        Console.WriteLine($"Full Name: {fullName}");
                        Console.WriteLine($"Uppercase Version: {fullName.ToUpper()}");
                        Console.WriteLine($"Lowercase Version: {fullName.ToLower()}");
                        Console.WriteLine($"Name Length: {fullName.Length}");
                        Console.WriteLine($"Name with underscores: {fullName.Replace(" ", "_")}");
                        Console.WriteLine($"Favorite Subject: {subjectText.ToUpper()}");
                        break;

                    case "2":
                        // ==========================================================
                        // Show Score
                        // ==========================================================
                        /*
                         This section displays:
                         - first score
                         - second score
                         - total
                         - average
                         - highest and lowest score
                         - square root
                         - power
                         - absolute difference
                         - rounded average
                         - bonus point
                        */

                        Console.WriteLine($"Your first score is: {exam1}");
                        Console.WriteLine($"Your second score is: {exam2}");
                        Console.WriteLine($"Total score is: {totalScore}");
                        Console.WriteLine($"Average score is: {averageScore}");
                        Console.WriteLine($"Highest score is: {Math.Max(exam1, exam2)}");
                        Console.WriteLine($"Lowest score is: {Math.Min(exam1, exam2)}");
                        Console.WriteLine($"Square root of first score is: {Math.Sqrt(exam1)}");
                        Console.WriteLine($"Power of second score is: {Math.Pow(exam2, 2)}");
                        Console.WriteLine($"Absolute difference is: {Math.Abs(exam1 - exam2)}");
                        Console.WriteLine($"Rounded average is: {Math.Round(averageScore)}");
                        Console.WriteLine($"Bonus point is: {bonusPoint}");
                        break;

                    case "3":
                        // ==========================================================
                        // Show Final Result
                        // ==========================================================
                        /*
                         This section checks the student's result
                         using if, else if, and else statements.

                         It also uses logical operators:
                         - &&  (AND)
                         - ||  (OR)
                         - !   (NOT)
                        */

                        Console.WriteLine($"Your average score is: {averageScore}");

                        if (averageScore >= 90)
                        {
                            Console.WriteLine("Excellent!");
                        }
                        else if (averageScore >= 70)
                        {
                            Console.WriteLine("Good job!");
                        }
                        else if (averageScore >= 50)
                        {
                            Console.WriteLine("You passed.");
                        }
                        else
                        {
                            Console.WriteLine("You failed.");
                        }

                        bool isAbsent = false;

                        if (age >= 18 && averageScore >= 70)
                        {
                            Console.WriteLine("You are an adult student with a good result.");
                        }

                        if (exam1 > 90 || exam2 > 90)
                        {
                            Console.WriteLine("At least one of your exam scores is excellent.");
                        }

                        if (!isAbsent)
                        {
                            Console.WriteLine("You were not absent.");
                        }
                        break;

                    case "4":
                        // ==========================================================
                        // Show Lucky Number
                        // ==========================================================
                        /*
                         This section displays:
                         - lucky number
                         - bonus point
                        */

                        Console.WriteLine($"Your lucky number is: {luckyNumber}");
                        Console.WriteLine($"Your bonus point is: {bonusPoint}");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}