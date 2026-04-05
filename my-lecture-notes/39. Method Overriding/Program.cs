/*
===========================================================
Lesson 39 - Method Overriding
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

In this lesson we will learn:

1) What method overriding is
2) What the 'virtual' keyword means
3) What the 'override' keyword means
4) How child classes can change behavior
5) What happens if we DO NOT override a method
6) A simple animal example

-----------------------------------------------------------
PART 1 - WHAT IS METHOD OVERRIDING?
-----------------------------------------------------------

Method overriding means:

A child class provides a new version of a method
that it inherits from a parent class.

So instead of using the parent's version,
it replaces it with its own version.

-----------------------------------------------------------
PART 2 - VIRTUAL KEYWORD
-----------------------------------------------------------

In the parent class, we use 'virtual':

public virtual void Speak()

This means:
"Child classes are allowed to override this method"

-----------------------------------------------------------
PART 3 - OVERRIDE KEYWORD
-----------------------------------------------------------

In the child class, we use 'override':

public override void Speak()

This means:
"We are replacing the parent's method"

-----------------------------------------------------------
PART 4 - IMPORTANT BEHAVIOR
-----------------------------------------------------------

If a child class DOES NOT override the method:

➡ It will use the parent's version

If it DOES override:

➡ It will use its own version

-----------------------------------------------------------
PART 5 - EXAMPLE OVERVIEW
-----------------------------------------------------------

Animal (parent):
- Speak() → default sound

Dog:
- overrides Speak()

Cat:
- does NOT override Speak()

So:
Dog → custom sound
Cat → default sound
*/

namespace _39._Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("METHOD OVERRIDING");
            Console.WriteLine("==================================");
            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 1 - Dog (OVERRIDDEN)
            ---------------------------------------------------
            */

            Console.WriteLine("Example 1: Dog");

            Dog dog = new Dog();
            dog.Speak();   // uses overridden version

            Console.WriteLine();

            /*
            ---------------------------------------------------
            EXAMPLE 2 - Cat (NOT OVERRIDDEN)
            ---------------------------------------------------
            */

            Console.WriteLine("Example 2: Cat");

            Cat cat = new Cat();
            cat.Speak();   // uses parent version

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

    class Animal
    {
        /*
        VIRTUAL METHOD

        Can be overridden by child classes.
        */

        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - DOG
    -------------------------------------------------------
    */

    class Dog : Animal
    {
        /*
        OVERRIDDEN METHOD

        Replaces the parent version.
        */

        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    /*
    -------------------------------------------------------
    CHILD CLASS - CAT
    -------------------------------------------------------

    This class does NOT override Speak().

    So it will use the parent's version.
    */

    class Cat : Animal
    {
        // No override here
    }
}