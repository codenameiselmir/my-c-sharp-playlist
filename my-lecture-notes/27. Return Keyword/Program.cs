/*
===========================================================
Lesson 27 - Return Keyword
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What does return mean?

Return sends a value back
from a method where it was called.

If a method returns something,
it cannot use void.

Example:

static int Add(int a, int b)
{
    return a + b;
}
*/

/*
Method Structure with Return

static dataType MethodName()
{
    return value;
}

- dataType → type of value being returned
- return → sends value back
*/

namespace _27._Return_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 3);
            Console.WriteLine("Result: " + result);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        // This method returns an int value.

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
