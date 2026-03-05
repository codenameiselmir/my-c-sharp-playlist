/*
===========================================================
Lesson 2 - Output
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a comment line?
2) Console.WriteLine() vs Console.Write()
*/

/*
1) What is a Comment Line?

Comments are lines that the compiler ignores.
They are used to explain the code.

There are two types of comments in C#:

Single-line comment:
    // This is a single-line comment

Multi-line comment:
    /*
        This is a
        multi-line comment
    */

// Comments help developers understand the code better.



/*
2) Output in C#

C# uses the Console class to display output to the screen.

Console belongs to the System namespace.
*/


namespace Lesson_2._Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine() prints text AND moves to a new line
            Console.WriteLine("Hello");
            Console.WriteLine("World");

            // Output:
            // Hello
            // World


            // Console.Write() prints text WITHOUT moving to a new line
            Console.Write("Hello ");
            Console.Write("World");

            // Output:
            // Hello World


            // Example to clearly see the difference
            Console.WriteLine();
            Console.WriteLine("---- Difference Example ----");

            Console.Write("C# ");
            Console.Write("is ");
            Console.Write("awesome!");

            Console.WriteLine(); // moves to next line

            Console.WriteLine("C#");
            Console.WriteLine("is");
            Console.WriteLine("awesome!");

            Console.ReadKey();
        }
    }
}