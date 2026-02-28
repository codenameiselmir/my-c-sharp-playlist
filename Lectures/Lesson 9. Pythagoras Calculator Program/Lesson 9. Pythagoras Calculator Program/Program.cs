namespace Lesson_9._Pythagoras_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the first side (Side A)
            Console.WriteLine("Enter side A:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the second side (Side B)
            Console.WriteLine("Enter side B:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            // Step 1: Square both sides
            // a^2 and b^2
            double squareA = Math.Pow(sideA, 2);
            double squareB = Math.Pow(sideB, 2);

            // Step 2: Add the squares
            double sumOfSquares = squareA + squareB;

            // Step 3: Take the square root of the sum
            double hypotenuse = Math.Sqrt(sumOfSquares);

            // Display the result
            Console.WriteLine("The hypotenuse (c) is: " + hypotenuse);
        }
    }
}
