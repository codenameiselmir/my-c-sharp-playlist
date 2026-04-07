/*
===========================================================
Lesson 44 - Getters and Setters
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

namespace _44._Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Why Do We Need Getters and Setters?
            // ==========================================================

            /*
            So far, we have been using public fields like this:

            public int speed;

            This works, but it has a big problem:
            anyone can change the value freely.

            For example:
            someone could set speed = 10000

            That might not make sense for a car.

            We need a way to control how data is accessed and modified.

            This is called "encapsulation".
            */

            // ==========================================================
            // 2. Creating an Object
            // ==========================================================

            /*
            We create a Car object and give it an initial speed.
            */

            Car car = new Car(400);

            /*
            Now we try to set the speed to a very high value.
            */

            car.Speed = 10000;

            /*
            Even though we assign 10000,
            the program will control this value internally.
            */

            Console.WriteLine(car.Speed);

            // ==========================================================
            // 3. What is a Property?
            // ==========================================================

            /*
            A property is a special feature in C#.

            It looks like a field,
            but works like a method.

            It allows us to control:
            - how a value is read (get)
            - how a value is changed (set)

            Properties help us protect our data.
            */
        }
    }

    // ==========================================================
    // 4. Car Class and Encapsulation
    // ==========================================================

    /*
    Instead of directly exposing the field,
    we use a property to control access.
    */

    class Car
    {
        public int speed;

        public Car(int speed)
        {
            this.speed = speed;
        }

        // ==========================================================
        // 5. Getter (Reading Data)
        // ==========================================================

        /*
        The get accessor is used
        when we read the value.

        Example:
        Console.WriteLine(car.Speed);

        It returns the current value of speed.
        */

        // ==========================================================
        // 6. Setter (Writing Data)
        // ==========================================================

        /*
        The set accessor is used
        when we assign a value.

        Example:
        car.Speed = 100;

        The keyword "value" represents
        the incoming value.

        We can add rules here.
        */

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                /*
                Here we add a rule:

                If the value is greater than 500,
                we limit it to 500.

                This prevents unrealistic values.
                */

                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }

        // ==========================================================
        // 7. Why This is Important
        // ==========================================================

        /*
        Without setters:
        speed could be anything (unsafe)

        With setters:
        we control the data

        This improves:
        - security
        - reliability
        - code quality
        */
    }

    // ==========================================================
    // 8. Final Summary
    // ==========================================================

    /*
    Getter:
    - used to read data
    - returns a value

    Setter:
    - used to assign data
    - can include validation rules

    Property:
    - combines both getter and setter
    - controls access to a field

    Encapsulation:
    - protects data from invalid changes
    - makes code safer and cleaner
    */
}