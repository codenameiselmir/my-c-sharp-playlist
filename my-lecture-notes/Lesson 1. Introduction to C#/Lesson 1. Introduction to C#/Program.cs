/*
===========================================================
Lesson 1 - Introduction to C#
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is C#?

C# (C-Sharp) is a modern, object-oriented programming language
developed by Microsoft and released in 2000. 

C# is used to build:
- Web Applications
- Desktop Applications
- Mobile Applications
- Games (Unity)
- Cloud Applications
- Enterprise Systems
*/

namespace Lesson_1._Introduction_to_C_
{
    internal class Program
    {
        // - static void Main() → Entry point of the application.
        static void Main(string[] args)
        {
            // - Console.WriteLine() → Prints output to the console.
            Console.WriteLine("Hello world!");

            /*
            Console.ReadKey() waits for the user to press a key.

            Why do we use it?

            When we run a console application (especially in Visual Studio),
            the terminal opens, runs the code, and immediately closes.

            If we want to see the output before the terminal closes,
            we use Console.ReadKey().

            It pauses the program until the user presses a key.
            */

            Console.ReadKey();
        }
    }
}
