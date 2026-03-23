/*
===========================================================
Practice 2: Student Registration Form
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// Homework
// ==========================================================
/*
 Homework:
 Create a console application called "Student Registration Form".

 The program should:
 - Display a welcome message
 - Ask the user to enter:
   - Full name
   - Age
   - Height in cm
   - Student status (true or false)
 - Accept input using Console.ReadLine()
 - Convert values using Convert
 - Store values in variables
 - Print all entered information at the end
*/

using System;

namespace _05._Practice_2___Student_Registration_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Welcome Message
            // ==========================================================
            Console.WriteLine("Welcome to the Student Registration Form!");

            // ==========================================================
            // 2. Accept User Input
            // ==========================================================
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string ageText = Console.ReadLine();
            int age = Convert.ToInt32(ageText);

            Console.Write("Please enter your height in cm: ");
            string heightText = Console.ReadLine();
            double height = Convert.ToDouble(heightText);

            Console.Write("Please tell us, are you a student? (true or false): ");
            string studentText = Console.ReadLine();
            bool studentStatus = Convert.ToBoolean(studentText);

            Console.WriteLine();

            // ==========================================================
            // 3. Print Student Information
            // ==========================================================
            Console.WriteLine("----- Student Information -----");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Student Status: {studentStatus}");
        }
    }
}