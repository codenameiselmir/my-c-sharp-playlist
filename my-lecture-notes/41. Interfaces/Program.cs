/*
===========================================================
Lesson 41 - Interfaces
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What an interface is
2) How interfaces act like a contract
3) The difference between inheritance and interfaces
4) How classes implement interfaces
5) Multiple inheritance using interfaces
6) A predator & prey example

-----------------------------------------------------------
PART 1 - WHAT IS AN INTERFACE?
-----------------------------------------------------------

An interface is like a contract.

It defines WHAT a class must do,
but NOT HOW to do it.

Example:

interface IPrey
{
    void Flee();
}

This means:
"Any class that uses IPrey MUST have a Flee() method"

-----------------------------------------------------------
PART 2 - INTERFACE VS INHERITANCE
-----------------------------------------------------------

Inheritance:
- Defines both behavior AND structure

Interface:
- Only defines required methods
- No implementation

So:

Class → "How it works"
Interface → "What it must have"

-----------------------------------------------------------
PART 3 - IMPLEMENTING AN INTERFACE
-----------------------------------------------------------

When a class uses an interface:

class Rabbit : IPrey

It MUST implement ALL methods inside that interface.

Otherwise → ERROR

-----------------------------------------------------------
PART 4 - MULTIPLE INTERFACES
-----------------------------------------------------------

C# does NOT support multiple inheritance (for classes)

BUT it DOES support multiple interfaces:

class Fish : IPrey, IPredator

This means Fish can:

✔ Escape (Flee)
✔ Hunt (Hunt)

-----------------------------------------------------------
PART 5 - WHY USE INTERFACES?
-----------------------------------------------------------

Interfaces provide:

✔ Security (rules must be followed)
✔ Flexibility (plug-and-play design)
✔ Scalability (easy to expand)
✔ Clean architecture

-----------------------------------------------------------
PART 6 - EXAMPLE OVERVIEW
-----------------------------------------------------------

IPrey:
- Flee()

IPredator:
- Hunt()

Rabbit:
- only prey → Flee()

Hawk:
- only predator → Hunt()

Fish:
- both → Flee() + Hunt()

*/

namespace _41._Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("INTERFACES");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            CREATING OBJECTS
            ---------------------------------------------------
            */

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            /*
            ---------------------------------------------------
            USING INTERFACE METHODS
            ---------------------------------------------------
            */

            Console.WriteLine("Rabbit behavior:");
            rabbit.Flee();

            Console.WriteLine();

            Console.WriteLine("Hawk behavior:");
            hawk.Hunt();

            Console.WriteLine();

            Console.WriteLine("Fish behavior:");
            fish.Flee();
            fish.Hunt();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    /*
    -------------------------------------------------------
    INTERFACE - PREY
    -------------------------------------------------------
    */

    interface IPrey
    {
        void Flee();
    }

    /*
    -------------------------------------------------------
    INTERFACE - PREDATOR
    -------------------------------------------------------
    */

    interface IPredator
    {
        void Hunt();
    }

    /*
    -------------------------------------------------------
    CLASS - RABBIT (ONLY PREY)
    -------------------------------------------------------
    */

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    /*
    -------------------------------------------------------
    CLASS - HAWK (ONLY PREDATOR)
    -------------------------------------------------------
    */

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food!");
        }
    }

    /*
    -------------------------------------------------------
    CLASS - FISH (PREY + PREDATOR)
    -------------------------------------------------------
    */

    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}