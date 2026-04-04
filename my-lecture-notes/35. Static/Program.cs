/*
===========================================================
Lesson 35 - Static
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What static means in C#
2) The difference between instance members and static members
3) Why static members belong to the class itself
4) How a static field can be shared by all objects
5) How to call a static method
6) A simple car example

-----------------------------------------------------------
PART 1 - WHAT IS STATIC?
-----------------------------------------------------------

The static keyword is used to create a member that belongs
to the class itself, not to an individual object.

That means:

- A normal field belongs to each object
- A static field belongs to the class
- A normal method is usually called by an object
- A static method is called by the class name

So instead of this:

car1.SomeMethod();

a static member is used like this:

Car.SomeStaticMethod();

Important idea:

A static member is shared.
There is only one copy of it for the whole class.

-----------------------------------------------------------
PART 2 - INSTANCE MEMBERS VS STATIC MEMBERS
-----------------------------------------------------------

INSTANCE MEMBER:
- Belongs to each object separately
- Each object can have a different value

STATIC MEMBER:
- Belongs to the class itself
- Shared by all objects
- Every object sees the same shared value

Example in this lesson:

string model;
public static int numberOfCars;

Here:
- model is different for each car object
- numberOfCars is shared by all car objects

So if we create 3 cars,
numberOfCars becomes 3

-----------------------------------------------------------
PART 3 - WHY STATIC IS USEFUL
-----------------------------------------------------------

Static members are useful when the data or behavior should
be shared by all objects.

Examples:
- counting how many objects were created
- general settings
- utility/helper methods
- shared information for the whole class

In this example:
numberOfCars keeps track of how many Car objects exist.

-----------------------------------------------------------
PART 4 - STATIC METHODS
-----------------------------------------------------------

A static method also belongs to the class itself.

This means we call it using the class name:

Car.startRace();

Why?

Because starting the race is treated as something related
to the whole Car class, not to one single car object.
*/

namespace _35._Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("STATIC MEMBERS");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Creating Objects
            ---------------------------------------------------

            Goal:
            Create multiple Car objects

            Each object will have its own model value.
            But all of them will share the same static field:
            numberOfCars
            */

            Console.WriteLine("Example 1: Create car objects");
            Console.WriteLine();

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            /*
            What happens step by step?

            1) car1 is created
               - model becomes "Mustang"
               - numberOfCars becomes 1

            2) car2 is created
               - model becomes "Corvette"
               - numberOfCars becomes 2

            3) car3 is created
               - model becomes "Lambo"
               - numberOfCars becomes 3
            */

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Accessing a Static Field
            ---------------------------------------------------

            Goal:
            Print the total number of cars created

            Since numberOfCars is static,
            we access it with the class name:

            Car.numberOfCars
            */

            Console.WriteLine("Example 2: Print the number of cars created");
            Console.WriteLine($"Total cars created: {Car.numberOfCars}");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 3 - Calling a Static Method
            ---------------------------------------------------

            Goal:
            Call a method that belongs to the class itself

            Since startRace() is static,
            we call it using the class name.
            */

            Console.WriteLine("Example 3: Call a static method");
            Car.startRace();

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    class Car
    {
        /*
        ---------------------------------------------------
        INSTANCE FIELD
        ---------------------------------------------------

        This field belongs to each object separately.
        Every car can have a different model.
        */

        string model;

        /*
        ---------------------------------------------------
        STATIC FIELD
        ---------------------------------------------------

        This field belongs to the class itself.
        It is shared by all Car objects.

        We use it to count how many Car objects were created.
        */

        public static int numberOfCars;

        /*
        ---------------------------------------------------
        CONSTRUCTOR
        ---------------------------------------------------

        Each time a Car object is created:
        - the model field gets its value
        - the static counter increases by 1
        */

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        /*
        ---------------------------------------------------
        STATIC METHOD
        ---------------------------------------------------

        This method belongs to the Car class itself.

        We do not need an object to call it.
        We call it like this:

        Car.startRace();
        */

        public static void startRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}