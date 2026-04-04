/*
===========================================================
Lesson 34 - Constructors
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What a constructor is
2) Why constructors are useful
3) How a constructor runs when an object is created
4) How constructor parameters can assign values to fields
5) A simple real example with a Car class

-----------------------------------------------------------
PART 1 - CONSTRUCTORS
-----------------------------------------------------------

A constructor is a special method inside a class.

Important rule:
- A constructor has the same name as the class

A constructor is usually used to:
- give starting values to fields
- prepare an object when it is created

This means:
when we create an object, the constructor can immediately
assign the data we pass in.

Example idea:

Car car = new Car("Ford", "Mustang", 2022, "Red");

Here:
- "Ford" goes into make
- "Mustang" goes into model
- 2022 goes into year
- "Red" goes into color

So instead of assigning these values one by one later,
we can do everything at the moment the object is created.

-----------------------------------------------------------
PART 2 - THE KEYWORD "this"
-----------------------------------------------------------

Inside a constructor, parameter names are often the same
as field names.

Example:

public Car(string make, string model, int year, string color)
{
    this.make = make;
    this.model = model;
    this.year = year;
    this.color = color;
}

What does this mean?

- this.make  -> the field inside the object
- make       -> the parameter coming into the constructor

So:

this.make = make;

means:
"take the parameter value and store it inside the object's field"

-----------------------------------------------------------
PART 3 - WHY CONSTRUCTORS ARE USEFUL
-----------------------------------------------------------

Without a constructor, we might need to do this:

Car car = new Car();
car.make = "Ford";
car.model = "Mustang";
car.year = 2022;
car.color = "Red";

But with a constructor, we can do everything in one line:

Car car = new Car("Ford", "Mustang", 2022, "Red");

This makes object creation:
- cleaner
- faster
- easier to read
*/

namespace _34._Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("CONSTRUCTORS");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Creating an Object with a Constructor
            ---------------------------------------------------

            Goal:
            Create a Car object and automatically assign values
            to its fields at the moment of creation

            Constructor call:
            new Car("Ford", "Mustang", 2022, "Red")

            This sends 4 values into the constructor:
            - make  = Ford
            - model = Mustang
            - year  = 2022
            - color = Red
            */

            Console.WriteLine("Example 1: Create a car object using a constructor");
            Console.WriteLine();

            Car car = new Car("Ford", "Mustang", 2022, "Red");

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Using a Method After Construction
            ---------------------------------------------------

            Goal:
            Call the Drive() method after the object has already
            been created and prepared by the constructor

            Since the constructor already assigned all fields,
            the object is ready to use.
            */

            Console.WriteLine("Example 2: Call the Drive() method");
            car.Drive();

            Console.WriteLine();

            /*
            ---------------------------------------------------
            KEY IDEAS TO REMEMBER
            ---------------------------------------------------

            CONSTRUCTOR:
            - Special method in a class
            - Has the same name as the class
            - Runs automatically when an object is created

            PURPOSE:
            - Give starting values to fields
            - Prepare the object immediately

            THIS KEYWORD:
            - Refers to the current object
            - Helps us separate fields from parameters

            BENEFIT:
            - Makes object creation shorter and cleaner
            */

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    class Car
    {
        /*
        ---------------------------------------------------
        CLASS FIELDS
        ---------------------------------------------------

        These fields store the data for each Car object.
        Each object can have its own values.
        */

        string make;
        string model;
        int year;
        string color;

        /*
        ---------------------------------------------------
        CONSTRUCTOR
        ---------------------------------------------------

        This constructor runs automatically whenever
        a new Car object is created.

        It receives values from the object creation line
        and assigns them to the fields of the object.
        */

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        /*
        ---------------------------------------------------
        METHOD - DRIVE
        ---------------------------------------------------

        This method uses the object's stored field values
        and prints a message to the console.
        */

        public void Drive()
        {
            Console.WriteLine($"You drive the {color} {year} {make} {model}");
        }
    }
}