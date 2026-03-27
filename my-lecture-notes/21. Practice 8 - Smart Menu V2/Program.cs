namespace _21._Practice_8___Smart_Menu_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine("Smart Menu V2");

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(fullName))
            {
                Console.Write("Invalid input! Enter your full name: ");
                fullName = Console.ReadLine();
            }

            Console.WriteLine($"Your name with uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Your name with lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Your name with underscore: {fullName.Replace(" ", "_")}");
        }
    }
}
