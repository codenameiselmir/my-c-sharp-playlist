/*
===========================================================
Lesson 32 - Classes
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

namespace _32._Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            What is a Class?

            A class is a bundle of related code. Classes help organize programs
            by grouping related methods together.

            In this example we will use a class called "Messages".
            */

            /*
            Calling methods from another class.

            Because Messages is a static class,
            we do not need to create an object.
            */

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
