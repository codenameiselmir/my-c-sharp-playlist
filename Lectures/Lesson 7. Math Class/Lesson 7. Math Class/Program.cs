namespace Lesson_7._Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Lesson 7: Math Class in C#
            *
            * The Math class provides built-in methods for performing
            * mathematical operations such as power, square root,
            * rounding, and absolute value.
            *
            * The Math class is static, so we do not need to create
            * an object to use it. We access its methods using:
            * Math.MethodName()
            */

            double number = 9.5;

            // Power (number raised to a specific exponent)
            double power = Math.Pow(2, 3);
            Console.WriteLine("Power (2^3): " + power);

            // Square root
            double squareRoot = Math.Sqrt(25);
            Console.WriteLine("Square Root of 25: " + squareRoot);

            // Absolute value
            double absoluteValue = Math.Abs(-10);
            Console.WriteLine("Absolute Value of -10: " + absoluteValue);

            // Rounding to nearest whole number
            double rounded = Math.Round(number);
            Console.WriteLine("Rounded value of 9.5: " + rounded);

            // Rounding up
            double ceilingValue = Math.Ceiling(number);
            Console.WriteLine("Ceiling value of 9.5: " + ceilingValue);

            // Rounding down
            double floorValue = Math.Floor(number);
            Console.WriteLine("Floor value of 9.5: " + floorValue);

            // Maximum value
            int maxValue = Math.Max(5, 8);
            Console.WriteLine("Maximum of 5 and 8: " + maxValue);

            // Minimum value
            int minValue = Math.Min(5, 8);
            Console.WriteLine("Minimum of 5 and 8: " + minValue);

            // Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
