/*
===========================================================
Lesson 1 - Introduction to C#
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

// ==========================================================
// 1. What is C#?
// ==========================================================
/*
 C# (pronounced C-Sharp) is a modern programming language
 created by Microsoft.

 It is an object-oriented language, which means it is built
 around objects and classes.

 C# is commonly used to build:
 - Web applications
 - Desktop applications
 - Mobile applications
 - Games (especially with Unity)
 - Cloud applications
 - Enterprise software
*/

using System;

namespace _01._Introduction_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("This is your first introduction lesson.");
            Console.WriteLine();

            // ==========================================================
            // 2. Comments in C#
            // ==========================================================
            /*
             Comments are used to explain code.
             The compiler ignores comments, so they do not affect
             how the program runs.

             There are two common types of comments in C#:
            */

            // This is a single-line comment

            /*
             This is a multi-line comment.
             It can be used when you want to write
             longer explanations.
            */

            Console.WriteLine("Comments help developers understand the code.");
            Console.WriteLine();

            // ==========================================================
            // 3. Output in C#
            // ==========================================================
            /*
             In C#, we often use the Console class to display text
             in the terminal (console window).

             The Console class belongs to the System namespace.
             That is why we wrote:

                 using System;

             at the top of the file.
            */

            Console.WriteLine("Now let's learn output methods in C#.");
            Console.WriteLine();

            // ==========================================================
            // 4. Console.WriteLine()
            // ==========================================================
            /*
             Console.WriteLine() prints text and then moves the cursor
             to the next line.
            */

            Console.WriteLine("Example of Console.WriteLine():");
            Console.WriteLine("Hello");
            Console.WriteLine("World");

            /*
             Output:
             Hello
             World
            */

            Console.WriteLine();

            // ==========================================================
            // 5. Console.Write()
            // ==========================================================
            /*
             Console.Write() prints text without moving to the next line.
             The next output continues on the same line.
            */

            Console.WriteLine("Example of Console.Write():");
            Console.Write("Hello ");
            Console.Write("World");

            /*
             Output:
             Hello World
            */

            Console.WriteLine();
            Console.WriteLine();

            // ==========================================================
            // 6. Why Do We Use Console.ReadKey()?
            // ==========================================================
            /*
             In console applications, the program may run very quickly.
             Sometimes the console window closes immediately after execution.

             Console.ReadKey() pauses the program and waits until
             the user presses a key.

             This gives us time to see the output on the screen.
            */

            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}