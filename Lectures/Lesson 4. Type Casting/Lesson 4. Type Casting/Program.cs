namespace Lesson_4._Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // TYPE CASTING WITH CONVERT CLASS
            // Converting a value to a different data type
            // ============================================================



            // ------------------------------------------------------------
            // DOUBLE -> INT
            // Convert decimal number to integer
            // ------------------------------------------------------------
            double piValue = 3.14;
            int convertedPi = Convert.ToInt32(piValue);

            Console.WriteLine(convertedPi);
            Console.WriteLine(convertedPi.GetType());



            // ------------------------------------------------------------
            // INT -> DOUBLE
            // Convert integer to decimal number
            // ------------------------------------------------------------
            int integerValue = 123;
            double convertedDouble = Convert.ToDouble(integerValue);

            Console.WriteLine(convertedDouble);
            Console.WriteLine(convertedDouble.GetType());



            // ------------------------------------------------------------
            // INT -> STRING
            // Convert numeric value to text
            // ------------------------------------------------------------
            int numberValue = 123;
            string convertedString = Convert.ToString(numberValue);

            Console.WriteLine(convertedString);
            Console.WriteLine(convertedString.GetType());



            // ------------------------------------------------------------
            // STRING -> CHAR
            // Convert single-character string to char
            // ------------------------------------------------------------
            string currencySymbol = "$";
            char convertedChar = Convert.ToChar(currencySymbol);

            Console.WriteLine(convertedChar);
            Console.WriteLine(convertedChar.GetType());



            // ------------------------------------------------------------
            // STRING -> BOOLEAN
            // Convert text to boolean value
            // Must be "True" or "False"
            // ------------------------------------------------------------
            string booleanText = "True";
            bool convertedBoolean = Convert.ToBoolean(booleanText);

            Console.WriteLine(convertedBoolean);
            Console.WriteLine(convertedBoolean.GetType());



            // ============================================================
            // IMPORTANT NOTE:
            // If the value cannot be converted,
            // Convert methods will throw a runtime exception.
            // ============================================================


            Console.ReadLine();
        }
    }
}
