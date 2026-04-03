/*
===========================================================
Lesson 29 - Params Keyword
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is Params?

The params keyword allows a method
to accept a variable number of arguments.

Instead of writing many overloaded methods,
we use params.
*/

/*
How Does It Work?

params turns arguments into an array.

Example:

static int Add(params int[] numbers)

Inside the method,
"numbers" is treated like an array.
*/

namespace _29._Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total1 = Add(1, 2);
            Console.WriteLine("Sum 1: " + total1);

            int total2 = Add(1, 2, 3, 4, 5);
            Console.WriteLine("Sum 2: " + total2);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        static int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
