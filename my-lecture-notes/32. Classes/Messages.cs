using System;
using System.Collections.Generic;
using System.Text;

namespace _32._Classes
{
    internal class Messages
    {

        /*
        Messages class

        This class contains several methods
        that display messages to the console.

        Because this class is static:
        - we cannot create objects
        - we call methods directly using the class name
        */

        public static void Hello()
        {
            Console.WriteLine("Hey! Welcome to the program.");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something.");
        }

        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting.");
        }
    }
}
