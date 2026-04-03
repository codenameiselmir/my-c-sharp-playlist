/*
===========================================================
Lesson 26 - Methods
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is a Method?

A method is a block of code
that performs a specific task.

It helps us:
- Organize code
- Reuse code
- Avoid repetition
*/

/*
Method Structure

static returnType MethodName()
{
    // code
}

- static → belongs to the class
- returnType → what the method returns (void = nothing)
- MethodName → name of the method
*/

namespace _26._Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the method
            SingHappyBirthday();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        /*
        Creating a Method

        - void means the method does NOT return a value.
        - Method name should start with capital letter (PascalCase).
        */

        static void SingHappyBirthday()
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear friend!");
            Console.WriteLine("Happy birthday to you!");
        }
    }
}
