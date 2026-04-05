/*
===========================================================
Lesson 38 - Abstract Classes
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What an abstract class is
2) Why we use abstract classes
3) What an abstract method is
4) Why abstract classes cannot be instantiated
5) How child classes must complete missing parts
6) A vehicle example

-----------------------------------------------------------
PART 1 - WHAT IS AN ABSTRACT CLASS?
-----------------------------------------------------------

An abstract class is a class that cannot be instantiated.

It is used as a base (parent) class.

It can contain:
- normal methods
- fields
- abstract methods (methods with no body)

Think of it as a "template" or "incomplete blueprint".

-----------------------------------------------------------
PART 2 - IMPORTANT RULE
-----------------------------------------------------------

We CANNOT create objects from an abstract class.

❌ WRONG:
Vehicle vehicle = new Vehicle();

✔ CORRECT:
We must create objects from child classes.

-----------------------------------------------------------
PART 3 - ABSTRACT METHODS
-----------------------------------------------------------

An abstract method:

- has no body
- must be implemented by child classes

Example:

public abstract void Go();

This forces all child classes to define their own version.

-----------------------------------------------------------
PART 4 - WHY USE ABSTRACT CLASSES?
-----------------------------------------------------------

- To enforce a rule (every child MUST implement something)
- To create a shared structure
- To avoid incomplete objects

-----------------------------------------------------------
PART 5 - EXAMPLE OVERVIEW
-----------------------------------------------------------

Vehicle (abstract):
- speed
- abstract Go()

Car, Bicycle, Boat:
- each defines its own Go() behavior
*/

namespace _38._Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ABSTRACT CLASSES");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            IMPORTANT NOTE
            ---------------------------------------------------

            We CANNOT do this:

            Vehicle vehicle = new Vehicle(); ❌

            Because Vehicle is abstract.
            */

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Car
            ---------------------------------------------------
            */

            Console.WriteLine("Example 1: Car");

            Car car = new Car();

            Console.WriteLine($"Speed: {car.speed}");
            Console.WriteLine($"Wheels: {car.wheels}");
            car.Go();

            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Bicycle
            ---------------------------------------------------
            */

            Console.WriteLine("Example 2: Bicycle");

            Bicycle bicycle = new Bicycle();

            Console.WriteLine($"Speed: {bicycle.speed}");
            Console.WriteLine($"Wheels: {bicycle.wheels}");
            bicycle.Go();

            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 3 - Boat
            ---------------------------------------------------
            */

            Console.WriteLine("Example 3: Boat");

            Boat boat = new Boat();

            Console.WriteLine($"Speed: {boat.speed}");
            Console.WriteLine($"Wheels: {boat.wheels}");
            boat.Go();

            Console.WriteLine();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    /*
    -------------------------------------------------------
    ABSTRACT PARENT CLASS
    -------------------------------------------------------

    This class is incomplete and cannot be instantiated.
    */

    abstract class Vehicle
    {
        public int speed = 0;

        /*
        ABSTRACT METHOD

        No body → child classes MUST implement this.
        */
        public abstract void Go();
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - CAR
    -------------------------------------------------------
    */

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;

        public override void Go()
        {
            Console.WriteLine("The car is driving!");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BICYCLE
    -------------------------------------------------------
    */

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;

        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BOAT
    -------------------------------------------------------
    */

    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;

        public override void Go()
        {
            Console.WriteLine("The boat is sailing!");
        }
    }
}