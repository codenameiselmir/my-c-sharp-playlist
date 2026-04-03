/*
===========================================================
Lesson 28 - Method Overloading
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is Method Overloading?

Method Overloading means:
Multiple methods can have the SAME name
but DIFFERENT parameters.

This makes code cleaner and easier to use.
*/

/*
What is a Method Signature?

Method signature = Method Name + Parameters

To overload a method:
- The name must be the same.
- The parameters must be different
  (different number or different data types).

Return type alone is NOT enough.
*/

namespace _28._Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling first overloaded method
            double total = Multiply(2, 3);
            Console.WriteLine("Multiply 2 numbers: " + total);

            // Calling second overloaded method
            double total2 = Multiply(2, 3, 4);
            Console.WriteLine("Multiply 3 numbers: " + total2);

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
