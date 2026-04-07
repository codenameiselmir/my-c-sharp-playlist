/*
===========================================================
Lesson 45 - Enums
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

namespace _45._Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. What is an Enum?
            // ==========================================================

            /*
            In C#, an enum (short for enumeration) is a special type
            that allows us to group related constant values together.

            Instead of using random numbers in our code,
            we can give meaningful names to those numbers.

            This makes our code:
            - easier to read
            - easier to maintain
            - less error-prone

            Think of an enum like a list of fixed options.
            */

            // ==========================================================
            // 2. Why Do We Use Enums?
            // ==========================================================

            /*
            Enums are useful when:

            - we have values that will NOT change
            - we want to avoid using "magic numbers"
            - we want cleaner and more readable code

            Example:

            Instead of writing:
                int planet = 22;

            We can write:
                Planets planet = Planets.Venus;

            Now the meaning is much clearer.
            */

            // ==========================================================
            // 3. Creating an Enum
            // ==========================================================

            /*
            An enum is defined outside the Main method.

            Each item inside the enum has a name
            and can optionally have an integer value.

            If we do not assign values,
            they will start from 0 and increase automatically.

            But in this example, we assign custom values.
            */

            // ==========================================================
            // 4. Using an Enum
            // ==========================================================

            /*
            We can access enum values using:

                EnumName.ValueName

            Example:
                Planets.Venus

            By default, enums represent integers.

            If we want to get the numeric value,
            we must explicitly convert (cast) it to int.
            */

            Console.WriteLine($"{Planets.Venus} is planet #{(int)Planets.Venus}");

            // ==========================================================
            // 5. Important Note About Casting
            // ==========================================================

            /*
            Enums store integer values internally.

            So:

                Planets.Venus        → returns the name (Venus)
                (int)Planets.Venus   → returns the number (22)

            This is called "casting".

            Without casting, we only see the label,
            not the numeric value.
            */

            // ==========================================================
            // 6. Final Summary
            // ==========================================================

            /*
            enum:
            - groups related constant values
            - improves readability
            - replaces magic numbers

            Key points:
            - enum items have names and integer values
            - values can be assigned manually
            - casting is required to get the numeric value

            Enums are very useful when working with
            fixed sets of options (like days, states, categories).
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    enum Planets
    {
        Mercury = 11,
        Venus = 22,
        Earth = 33,
        Mars = 59,
        Jupiter = 27,
        Saturn = 89,
        Uranus = 74,
        Neptune = 55,
        Pluto = 14
    }
}