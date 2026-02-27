namespace Lesson_6._Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Topic: Arithmetic Operators in C#
            *
            * Arithmetic operators are used to perform mathematical operations
            * such as addition, subtraction, multiplication, division, and modulus.
            *
            * Common arithmetic operators:
            * +  (Addition)
            * -  (Subtraction)
            * *  (Multiplication)
            * /  (Division)
            * %  (Modulus - Remainder)
            * ++ (Increment)
            * -- (Decrement)
            */

            int number1 = 10;
            int number2 = 3;

            // Addition
            int sum = number1 + number2;
            Console.WriteLine("Addition: " + sum);

            // Subtraction
            int difference = number1 - number2;
            Console.WriteLine("Subtraction: " + difference);

            // Multiplication
            int product = number1 * number2;
            Console.WriteLine("Multiplication: " + product);

            // Division (integer division)
            int quotient = number1 / number2;
            Console.WriteLine("Division: " + quotient);

            // Modulus (remainder)
            int remainder = number1 % number2;
            Console.WriteLine("Modulus (Remainder): " + remainder);

            // Increment
            number1++;
            Console.WriteLine("After Increment: " + number1);

            // Decrement
            number2--;
            Console.WriteLine("After Decrement: " + number2);

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}
