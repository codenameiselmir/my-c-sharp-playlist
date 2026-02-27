namespace Lesson_3._Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // VARIABLES IN C#
            // A variable is a container used to store data in memory.
            // Each variable must have a data type.
            // The data type determines what kind of data we can store.
            // ============================================================


            // -----------------------------
            // INTEGER (int)
            // Used to store whole numbers.
            // -----------------------------
            int age = 21;
            Console.WriteLine("Age: " + age);


            // -----------------------------
            // DOUBLE
            // Used to store decimal numbers.
            // Double has higher precision than float.
            // -----------------------------
            double height = 1.85;
            Console.WriteLine("Height: " + height);


            // -----------------------------
            // FLOAT
            // Used for decimal numbers.
            // Must end with 'f'.
            // -----------------------------
            float weight = 75.5f;
            Console.WriteLine("Weight: " + weight);


            // -----------------------------
            // STRING
            // Used to store text.
            // Must be written inside double quotes.
            // -----------------------------
            string name = "Ahmet";
            Console.WriteLine("Name: " + name);


            // -----------------------------
            // CHAR
            // Stores a single character.
            // Must be written inside single quotes.
            // -----------------------------
            char grade = 'A';
            Console.WriteLine("Grade: " + grade);


            // -----------------------------
            // BOOL (Boolean)
            // Stores true or false values.
            // Often used in decision making.
            // -----------------------------
            bool isStudent = true;
            Console.WriteLine("Is Student: " + isStudent);


            // ============================================================
            // IMPORTANT:
            // C# is a strongly typed language.
            // Once a variable type is defined,
            // it cannot store another type later.
            // ============================================================

            // Example of invalid assignment:
            // age = "twenty";  // ❌ This would cause a compile-time error

            // ============================================================
            // CONSTANTS IN C#
            // A constant is a variable whose value cannot be changed.
            // We use the 'const' keyword to define a constant.
            // ============================================================

            // Constant must be assigned a value at declaration time.
            const double PI = 3.14159;

            Console.WriteLine("Value of PI: " + PI);

            // Attempting to change a constant will cause a compile-time error.
            // PI = 3.14;   // ❌ This is not allowed

            // Example usage of constant in a calculation
            double radius = 5;
            double area = PI * radius * radius;

            Console.WriteLine("Circle Area: " + area);


            Console.ReadKey();
        }
    }
}
