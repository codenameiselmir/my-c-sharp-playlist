/*
===========================================================
Lesson 10 - String Methods
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) What is a string?
2) Common string methods
3) String properties
*/

/*
1) What is a String?

A string is a sequence of characters (text).

Example:
string name = "Elmir";

Strings are very powerful in C# and have many built-in methods.
*/

namespace Lesson_10._String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ToUpper() → Converts all characters to uppercase
            */

            string fullName = "Elmir Developer";
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);


            /*
            ToLower() → Converts all characters to lowercase
            */

            string fullName2 = "Elmir Developer";
            fullName2 = fullName2.ToLower();
            Console.WriteLine(fullName2);


            /*
            Replace(oldValue, newValue)
            Replaces characters or text
            */

            string phoneNum = "123-456-7890";
            phoneNum = phoneNum.Replace("-", "/");
            Console.WriteLine(phoneNum);


            /*
            Insert(index, value)
            Inserts text at specific position
            */

            string userName = "codenameiselmir";
            userName = userName.Insert(0, "@");
            Console.WriteLine(userName);


            /*
            Length → Returns number of characters
            */

            string lengthText = "Test";
            Console.WriteLine("Length: " + lengthText.Length);


            /*
            Substring(startIndex, length)
            Extracts part of a string
            */

            string nameExample = "Elmir Developer";

            string firstName = nameExample.Substring(0, 5);
            Console.WriteLine("First Name: " + firstName);

            string surname = nameExample.Substring(6, 9);
            Console.WriteLine("Surname: " + surname);


            /*
            Important Notes:

            - Strings are immutable.
              This means when we modify a string,
              a new string is created.

            - String methods do not change the original value
              unless we reassign it.
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}