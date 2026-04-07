/*
===========================================================
Lesson 43 - Lists
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================
*/

namespace _43._Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Introduction to Lists
            // ==========================================================

            /*
            So far, we have worked with variables and maybe arrays.

            But arrays have a limitation:
            their size is fixed.

            What if we want something more flexible?
            Something that can grow or shrink during runtime?

            That’s where Lists come in.

            A List is a collection that can store multiple values,
            and its size can change dynamically.
            */

            // ==========================================================
            // 2. Creating a List
            // ==========================================================

            /*
            To create a list, we use this syntax:

            List<Type> name = new List<Type>();

            In this example, we will create a list
            that stores food names (strings).
            */

            List<string> foods = new List<string>();

            // ==========================================================
            // 3. Adding Data to the List
            // ==========================================================

            /*
            Right now, our list is empty.

            To add elements into the list,
            we use the Add() method.

            Each time we call Add(),
            a new item is placed at the end of the list.
            */

            foods.Add("Pizza");
            foods.Add("Sushi");
            foods.Add("Hotdog");

            /*
            Now our list looks like this:

            [Pizza, Sushi, Hotdog]
            */

            // ==========================================================
            // 4. Working with List Methods
            // ==========================================================

            /*
            Lists come with many built-in methods
            that make them very powerful.

            For example:

            Remove("Hotdog")   -> removes an item
            Insert(0, "Fries") -> adds item at a specific index
            Count             -> tells how many items are in the list
            IndexOf("Pizza")  -> finds the position of an item
            Contains("Pizza") -> checks if item exists

            There are also methods like:
            Sort() and Reverse()

            These help us organize our data easily.
            */

            // Example (optional usage):
            // foods.Remove("Hotdog");
            // foods.Insert(0, "Fries");

            // ==========================================================
            // 5. Looping Through the List
            // ==========================================================

            /*
            Now that we have data in our list,
            we usually want to access or display it.

            The most common way to do this
            is using a foreach loop.

            The loop goes through each element
            one by one.
            */

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

            // ==========================================================
            // 6. Lists with Objects (Important Concept)
            // ==========================================================

            /*
            Lists are not limited to simple types like strings or integers.

            One of the most powerful features of Lists is that
            they can store objects.

            This is extremely important in real-world applications.

            For example, instead of storing just names,
            we can store full "Player" objects.
            */

            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            /*
            Now our list contains objects, not just text.

            Each object has its own data inside.
            */

            // ==========================================================
            // 7. Accessing Object Data
            // ==========================================================

            /*
            When we loop through a list of objects,
            we can access their properties.

            In this case, each Player has a "username".
            */

            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }

            // ==========================================================
            // 8. Final Thoughts
            // ==========================================================

            /*
            Lists are one of the most commonly used data structures.

            You will use them everywhere:
            - storing users
            - managing data
            - handling collections

            If you understand Lists well,
            you have taken a big step forward in programming.

            The key idea is:

            Lists = flexible, dynamic collections
            that can store anything (even objects).
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }

    // ==========================================================
    // 9. Player Class
    // ==========================================================

    /*
    This class represents a Player.

    Each player has a username.

    When we create a new Player,
    we pass the username into the constructor.
    */

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
    }
}