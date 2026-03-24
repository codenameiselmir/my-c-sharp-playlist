/*
===========================================================
Lesson 10 - String Methods in C#
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

using System;

namespace _10._String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Introduction to String Methods
            // ==========================================================
            /*
             In C#, a string is used to store text.

             Strings come with many built-in methods that help us
             modify, analyze, and work with text more easily.

             In this lesson, we will learn some common string methods:
             - ToUpper()
             - ToLower()
             - Replace()
             - Insert()
             - Length
             - Substring()
            */

            Console.WriteLine("C# String Methods Tutorial");
            Console.WriteLine();

            // ==========================================================
            // 2. ToUpper()
            // ==========================================================
            /*
             The ToUpper() method converts all letters in a string
             to uppercase.

             This is useful when you want text to appear in capital letters.
            */

            string upperName = "Elmir Abaszada";
            upperName = upperName.ToUpper();

            Console.WriteLine("Using ToUpper():");
            Console.WriteLine(upperName);
            Console.WriteLine();

            // ==========================================================
            // 3. ToLower()
            // ==========================================================
            /*
             The ToLower() method converts all letters in a string
             to lowercase.

             This is useful when you want text to appear in small letters
             or when comparing text in a case-insensitive way.
            */

            string lowerName = "Elmir Abaszada";
            lowerName = lowerName.ToLower();

            Console.WriteLine("Using ToLower():");
            Console.WriteLine(lowerName);
            Console.WriteLine();

            // ==========================================================
            // 4. Replace()
            // ==========================================================
            /*
             The Replace() method changes one part of a string
             into another value.

             Syntax:
                 stringName.Replace(oldValue, newValue)

             In the example below, we replace each dash (-)
             with an asterisk (*).
            */

            string phoneNum = "123-456-789";
            phoneNum = phoneNum.Replace("-", "*");

            Console.WriteLine("Using Replace():");
            Console.WriteLine(phoneNum);
            Console.WriteLine();

            // ==========================================================
            // 5. Insert()
            // ==========================================================
            /*
             The Insert() method adds text into a string
             at a specific position.

             Syntax:
                 stringName.Insert(index, value)

             In this example, we insert the @ symbol
             at the beginning of the username.
            */

            string userName = "codenameiselmir";
            userName = userName.Insert(0, "@");

            Console.WriteLine("Using Insert():");
            Console.WriteLine(userName);
            Console.WriteLine();

            // ==========================================================
            // 6. Length
            // ==========================================================
            /*
             Length is a property that tells us how many characters
             are inside a string.

             Spaces also count as characters.
            */

            string lengthText = "Test";

            Console.WriteLine("Using Length:");
            Console.WriteLine($"Length: {lengthText.Length}");
            Console.WriteLine();

            // ==========================================================
            // 7. Substring()
            // ==========================================================
            /*
             The Substring() method extracts part of a string.

             Syntax:
                 stringName.Substring(startIndex, length)

             startIndex tells C# where to begin.
             length tells C# how many characters to take.
            */

            string nameExample = "Elmir Abaszada";

            string firstName = nameExample.Substring(0, 5);
            string lastName = nameExample.Substring(6, 8);

            Console.WriteLine("Using Substring():");
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Surname: {lastName}");
            Console.WriteLine();

            // ==========================================================
            // 8. Final Note
            // ==========================================================
            /*
             String methods are very useful in real programs.

             They help us format text, search inside text,
             edit values, and extract important information.

             As you continue learning C#, you will use string methods often
             in forms, user input, validation, and data processing.
            */

            Console.WriteLine("End of Lesson 10 - String Methods in C#");
            Console.ReadKey();
        }
    }
}