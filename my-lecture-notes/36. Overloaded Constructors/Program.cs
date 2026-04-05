/*
===========================================================
Lesson 36 - Overloaded Constructors
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What overloaded constructors are
2) What a constructor signature means
3) Why we use multiple constructors
4) How objects can be created in different ways
5) A simple pizza example

-----------------------------------------------------------
PART 1 - WHAT IS AN OVERLOADED CONSTRUCTOR?
-----------------------------------------------------------

Overloaded constructors mean:

We can create multiple constructors in the same class,
but each constructor must have a different parameter list.

This is called a different "signature".

Signature = constructor name + parameters

So:

Pizza(string bread, string sauce, string cheese)

is different from:

Pizza(string bread, string sauce, string cheese, string topping)

-----------------------------------------------------------
PART 2 - WHY USE OVERLOADING?
-----------------------------------------------------------

Overloading allows flexibility when creating objects.

For example:

- Sometimes we want a simple pizza (no topping)
- Sometimes we want a full pizza (with topping)

Instead of forcing one way, we allow multiple ways.

-----------------------------------------------------------
PART 3 - HOW IT WORKS
-----------------------------------------------------------

When we create an object:

Pizza pizza1 = new Pizza("A", "B", "C");

C# looks for a constructor that matches EXACTLY 3 parameters.

When we create:

Pizza pizza2 = new Pizza("A", "B", "C", "D");

C# uses the constructor with 4 parameters.

-----------------------------------------------------------
PART 4 - EXAMPLE OVERVIEW
-----------------------------------------------------------

We will create 2 pizzas:

pizza1 → basic pizza (no topping)
pizza2 → pizza with topping

Each constructor will handle a different case.
*/

namespace _36._Overloaded_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("OVERLOADED CONSTRUCTORS");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Basic Pizza
            ---------------------------------------------------

            This pizza has no topping.
            So we use the constructor with 3 parameters.
            */

            Console.WriteLine("Example 1: Create a basic pizza");

            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "Mozzarella");

            Console.WriteLine("Pizza 1 created (no topping)");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Pizza with Topping
            ---------------------------------------------------

            This pizza includes a topping.
            So we use the constructor with 4 parameters.
            */

            Console.WriteLine("Example 2: Create a pizza with topping");

            Pizza pizza2 = new Pizza("stuffed crust", "red sauce", "Mozzarella", "Pepperoni");

            Console.WriteLine("Pizza 2 created (with topping)");
            Console.WriteLine();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    class Pizza
    {
        /*
        ---------------------------------------------------
        INSTANCE FIELDS
        ---------------------------------------------------

        These fields belong to each Pizza object separately.
        */

        string bread;
        string sauce;
        string cheese;
        string topping;

        /*
        ---------------------------------------------------
        CONSTRUCTOR 1 (NO TOPPING)
        ---------------------------------------------------

        This constructor is used when no topping is provided.
        */

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        /*
        ---------------------------------------------------
        CONSTRUCTOR 2 (WITH TOPPING)
        ---------------------------------------------------

        This constructor is used when a topping is included.
        */

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}