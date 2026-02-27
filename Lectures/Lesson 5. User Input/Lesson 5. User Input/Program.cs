namespace Lesson_5._User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Topic: Accept User Input in C#
            * 
            * In this example, we learn how to receive input from the user in a C# console application.
            * 
            * Key Concepts:
            * - Console.WriteLine() is used to display messages to the user.
            * - Console.ReadLine() is used to receive input from the user.
            * - Console.ReadLine() always returns data as a string.
            * - Convert.ToInt32() is used to convert string input into an integer.
            * 
            * This program:
            * 1. Asks the user for their name.
            * 2. Asks the user for their age.
            * 3. Converts the age input into an integer.
            * 4. Displays the entered information back to the user.
            */

            // Ask the user to enter their name
            Console.WriteLine("What is your name?");

            // Store the user's name (string type)
            string name = Console.ReadLine();

            // Ask the user to enter their age
            Console.WriteLine("What is your age?");

            // Convert the user's input from string to integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Display a greeting message using the user's name
            Console.WriteLine("Hello, " + name);

            // Display the user's age
            Console.WriteLine("You are " + age + " years old.");

            // Wait for a key press before closing the application
            Console.ReadKey();
        }
    }
}
