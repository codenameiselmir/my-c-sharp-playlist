/*
===========================================================
Lesson 12 - Switch and Case
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
In this lesson we will learn:

1) switch
2) case
3) break
4) default
*/

/*
1) switch

switch is used to compare one variable
with multiple possible values.

It is cleaner than writing many else if statements.

switch checks the value once,
then jumps to the matching case.
*/

/*
2) case

case represents a possible value.

If the variable matches the case value,
the code inside that case will run.

Each case must match exactly.
*/

/*
3) break

break is very important.

It stops the switch block.

Without break, the program would continue
executing the next case.
*/

/*
4) default

default runs when no case matches.

It is optional,
but highly recommended.
*/

namespace Lesson_12._Switch_and_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-3): ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.WriteLine("You selected One.");
                    break;

                case "2":
                    Console.WriteLine("You selected Two.");
                    break;

                case "3":
                    Console.WriteLine("You selected Three.");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}