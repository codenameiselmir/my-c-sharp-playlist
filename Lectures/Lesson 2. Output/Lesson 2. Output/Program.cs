/*
    ============================
            Lesson 02
              Output
    ============================

    In this lesson, we learn how to produce output in C#.

    Output means displaying information to the user.
    In console applications, we use the Console class
    to print text or values on the screen.

    The most commonly used method is:
    - Console.WriteLine()

    This method prints text to the console and
    moves the cursor to the next line.
*/

namespace Lesson_2._Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Console.WriteLine() vs Console.Write()

                Both methods are used to display output in a console application.

                Console.WriteLine():
                - Prints the given text or value to the console.
                - Moves the cursor to the next line after printing.
                - "Line" means it ends with a new line.

                Console.Write():
                - Prints the given text or value to the console.
                - Does NOT move to the next line after printing.
                - The next output continues on the same line.
            */

            // Prints text and moves to a new line
            Console.WriteLine("Hello");

            // Prints text and stays on the same line
            Console.Write("World");

            /*
            ============================
            Additional Information
            Comments in C#
            ============================

            Comments are used to explain the code.
            They are ignored by the compiler and
            do not affect how the program runs.

            There are two main types of comments in C#:

            1) Single-line Comment, Starts with // and Applies to only one line.

            2) Multi-line Comment
            - Starts with /* and ends with */
            /*
            - Used for longer explanations
            - Can span multiple lines
            */

            /*
            Escape Sequences in C#

            Escape sequences are special characters used inside strings.
            They begin with a backslash (\) and allow us to format text
            in different ways when printing to the console.

            Commonly Used Escape Sequences:

            \n  -> New line (moves the cursor to the next line)
            \t  -> Horizontal tab (adds spacing like a tab)
            \"  -> Inserts a double quotation mark inside a string
            \\  -> Inserts a backslash character

            Note:
            C# includes other escape sequences, but many of them
            are rarely used in basic applications. The ones above
            are the most common and important for beginners.
            */

            Console.WriteLine("\n-- Escape Sequences Examples :");

            // New line example
            Console.WriteLine("Hello\nWorld");

            // Tab example
            Console.WriteLine("Name:\tElmir");

            // Double quote example
            Console.WriteLine("He said \"Hello\"");

            // Backslash example
            Console.WriteLine("C:\\Users\\Elmir");

            /*
            Console.ReadKey()

            This method waits for the user to press a key on the keyboard.

            - It pauses the program execution.
            - The program will not close immediately.
            - It is commonly used at the end of console applications
              to allow the user to see the output before the window closes.
            */

            Console.ReadKey();
        }
    }
}
