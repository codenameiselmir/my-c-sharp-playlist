/*
===========================================================
Lesson 33 - Objects
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

/*
What is an Object?

An object is an instance of a class. A class acts like a blueprint,
and objects are created from that blueprint.

Example:

Class → Human
Objects → human1, human2, human3
*/

/*
Objects can contain:

Fields  → characteristics (name, age)
Methods → actions (Eat, Sleep)
*/

namespace _33._Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object from the Human class.
            // Syntax:
            // ClassName objectName = new ClassName();

            Human human1 = new Human();

            // Assigning values to fields

            human1.name = "Elmir";
            human1.age = 22;

            // Calling object methods

            human1.Eat();
            human1.Sleep();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    class Human // Human class (Blueprint)
    {

        // Fields (Characteristics)
        
        public string name;
        public int age;

        // Methods (Actions)

        public void Eat()
        {
            Console.WriteLine($"{name} is eating..");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping..");
        }
    }
}