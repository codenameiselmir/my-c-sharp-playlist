/*
===========================================================
Lesson 37 - Inheritance
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What inheritance means in C#
2) What a parent (base) class is
3) What a child (derived) class is
4) How child classes inherit fields and methods
5) Why inheritance is useful
6) A simple vehicle example

-----------------------------------------------------------
PART 1 - WHAT IS INHERITANCE?
-----------------------------------------------------------

Inheritance means:

One or more child classes can receive fields and methods
from a common parent class.

So instead of rewriting the same code,
we reuse it.

-----------------------------------------------------------
PART 2 - PARENT VS CHILD CLASS
-----------------------------------------------------------

PARENT CLASS (BASE CLASS):
- The class that provides common features
- Example: Vehicle

CHILD CLASS (DERIVED CLASS):
- The class that inherits from the parent
- Example: Car, Bicycle, Boat

Syntax:

class ChildClass : ParentClass

-----------------------------------------------------------
PART 3 - WHY USE INHERITANCE?
-----------------------------------------------------------

Benefits:

- Code reuse (write once, use many times)
- Cleaner and more organized code
- Easier to maintain
- Reduces duplication

In this example:

Vehicle class contains:
- speed
- Go() method

All child classes automatically get these.

-----------------------------------------------------------
PART 4 - EXAMPLE OVERVIEW
-----------------------------------------------------------

We will create:

Car → 4 wheels
Bicycle → 2 wheels
Boat → 0 wheels

All of them:
- share speed
- share Go() method

But each has its own wheels value.
*/

namespace _37._Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("INHERITANCE");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Car
            ---------------------------------------------------

            Car inherits from Vehicle.
            It gets:
            - speed
            - Go()

            And adds:
            - wheels = 4
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
    PARENT CLASS (BASE CLASS)
    -------------------------------------------------------

    This class contains shared properties and behavior.
    */

    class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving...");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - CAR
    -------------------------------------------------------

    Inherits everything from Vehicle.
    */

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BICYCLE
    -------------------------------------------------------
    */

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BOAT
    -------------------------------------------------------
    */

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}