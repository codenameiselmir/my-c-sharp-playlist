/*
===========================================================
Lesson 46 - Generics
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What are Generics?

Generics allow you to define **classes**, **methods**, and **interfaces** with **placeholders for types**.
This allows your code to work with any data type while maintaining **type safety**.
*/

namespace _46._Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Creating a generic class instance
            MyClass<int> intInstance = new MyClass<int>(5);  // Create an instance with int type
            Console.WriteLine("Data: " + intInstance.GetData());

            MyClass<string> stringInstance = new MyClass<string>("Hello, Generics!");  // Create an instance with string type
            Console.WriteLine("Data: " + stringInstance.GetData());

            // Example 2: Using a generic method
            Console.WriteLine("Sum: " + Add<int>(10, 20));  // Use the generic method to add two integers
            Console.WriteLine("Concatenation: " + Add<string>("Hello", " World!"));  // Use the generic method to concatenate strings

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        // Example of a generic method
        public static T Add<T>(T a, T b)
        {
            dynamic value1 = a;
            dynamic value2 = b;

            return value1 + value2;  // This works because of dynamic typing, but not type-safe for all types.
        }
    }

    // Generic class definition
    class MyClass<T>
    {
        private T data;

        public MyClass(T value)
        {
            this.data = value;
        }

        public T GetData()
        {
            return data;
        }
    }
}
