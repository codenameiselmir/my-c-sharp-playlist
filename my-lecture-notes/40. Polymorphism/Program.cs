/*
===========================================================
Lesson 40 - Polymorphism
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What polymorphism means
2) How one object can have many forms
3) How inheritance enables polymorphism
4) How virtual and override work together
5) How polymorphism works with arrays
6) A real-world vehicle example

-----------------------------------------------------------
PART 1 - WHAT IS POLYMORPHISM?
-----------------------------------------------------------

Polymorphism is a concept in Object-Oriented Programming.

The word comes from Greek:
"Poly" = many
"Morph" = forms

So polymorphism means:

➡ "Having many forms"

In programming:

An object can be treated as different types.

Example:
A Dog can be:
- Dog
- Animal
- Organism

-----------------------------------------------------------
PART 2 - HOW DOES IT WORK?
-----------------------------------------------------------

Polymorphism works using:

1) Inheritance
2) Virtual methods
3) Method overriding

A parent class defines a method using 'virtual'.

Child classes override that method using 'override'.

Even though objects are stored as the parent type,
each object uses its OWN version of the method.

-----------------------------------------------------------
PART 3 - WHY IS THIS IMPORTANT?
-----------------------------------------------------------

Polymorphism allows us to:

✔ Write flexible code
✔ Use one interface for many types
✔ Avoid repeating code
✔ Easily extend programs

Instead of writing separate logic for each object,
we can treat them all as the same type.

-----------------------------------------------------------
PART 4 - POLYMORPHISM WITH ARRAYS
-----------------------------------------------------------

We can store different objects in the SAME array
if they share the same parent class.

Example:

Vehicle[] vehicles = { car, bicycle, boat };

Even though they are different objects,
they all inherit from Vehicle.

So they can be grouped together.

-----------------------------------------------------------
PART 5 - RUNTIME BEHAVIOR (IMPORTANT)
-----------------------------------------------------------

When we call a method like:

vehicle.Go();

C# decides at runtime which version to use.

This is called:

➡ Runtime Polymorphism

So:

Car → calls Car.Go()
Bicycle → calls Bicycle.Go()
Boat → calls Boat.Go()

Even though the type is Vehicle!

-----------------------------------------------------------
PART 6 - EXAMPLE OVERVIEW
-----------------------------------------------------------

Vehicle (parent):
- Go() → virtual method

Car:
- overrides Go()

Bicycle:
- overrides Go()

Boat:
- overrides Go()

Loop:
Each object runs its OWN version of Go()

*/

namespace _40._Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("POLYMORPHISM");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            CREATING OBJECTS
            ---------------------------------------------------
            */

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            /*
            ---------------------------------------------------
            POLYMORPHIC ARRAY
            ---------------------------------------------------

            Different objects stored as the SAME type (Vehicle)
            */

            Vehicle[] vehicles = { car, bicycle, boat };

            /*
            ---------------------------------------------------
            LOOP THROUGH VEHICLES
            ---------------------------------------------------

            Each object uses its OWN Go() method
            */

            Console.WriteLine("Vehicles in motion:\n");

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();   // runtime polymorphism
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    /*
    -------------------------------------------------------
    PARENT CLASS
    -------------------------------------------------------
    */

    class Vehicle
    {
        /*
        VIRTUAL METHOD

        Can be overridden by all child classes.
        */

        public virtual void Go()
        {
            Console.WriteLine("The vehicle is moving...");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - CAR
    -------------------------------------------------------
    */

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving..");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BICYCLE
    -------------------------------------------------------
    */

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving..");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - BOAT
    -------------------------------------------------------
    */

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving..");
        }
    }
}