/*
===========================================================
Practice 7: Coffee Shop Console App
Repository: my-c-sharp-playlist
File: my-lecture-notes
===========================================================

Tutorial:
In this practice, we build a Coffee Shop Console App step by step.

The user enters:
- name
- coffee choice
- size
- quantity
- coupon information

Then the program:
- checks that important input is not empty
- validates menu choices
- uses switch-case to choose coffee and size
- uses Convert to change text into numbers
- uses arithmetic operators to calculate prices
- uses if / else to apply discounts
- uses Random class to create an order number
- uses Math class to round the final total
- uses for loop to print decoration
- uses nested loops to print a receipt border

Topics used in this project:
- Console.Write() and Console.WriteLine()
- Console.ReadLine()
- Variables
- Type Casting using Convert
- Arithmetic Operators
- Math Class
- Random Class
- String Methods
- If and Else
- Switch and Case
- Logical Operators
- While Loops
- For Loops
- Nested Loops
===========================================================
*/

using System;

namespace _19._Practice_7___Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==========================================================
            // 1. Displaying the Program Title
            // ==========================================================
            /*
             We start by printing the title of the program.

             Console.WriteLine() prints text
             and then moves to the next line.
            */

            Console.WriteLine("=====================================");
            Console.WriteLine("         C# COFFEE SHOP APP          ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // ==========================================================
            // 2. Asking for the Customer's Name
            // ==========================================================
            /*
             Console.Write() prints text
             without moving to the next line.

             Console.ReadLine() waits for the user
             to type something and press Enter.

             The entered value is stored
             inside the variable name.
            */

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            /*
             Here we use a while loop.

             The goal is to make sure
             the user does not leave the name empty.

             Trim() removes spaces from the beginning
             and end of the text.

             So if the user enters nothing,
             or only spaces,
             the program asks again.
            */

            while (name.Trim() == "")
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Hi, {name}!");
            Console.WriteLine();

            // ==========================================================
            // 3. Displaying the Coffee Menu
            // ==========================================================
            /*
             Now we show the coffee menu.

             The user must choose one option
             between 1 and 4.
            */

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Espresso");
            Console.WriteLine("2. Latte");
            Console.WriteLine("3. Cappuccino");
            Console.WriteLine("4. Americano");
            Console.Write("Choose your coffee (1-4): ");
            string optionText = Console.ReadLine().Trim();

            /*
             We validate the choice using a while loop
             and logical operators.

             && means AND

             So the loop continues while the input is:
             not 1 AND not 2 AND not 3 AND not 4

             This allows only valid options.
            */

            while (optionText != "1" && optionText != "2" && optionText != "3" && optionText != "4")
            {
                Console.Write("Invalid input! Choose your coffee (1-4): ");
                optionText = Console.ReadLine().Trim();
            }

            /*
             Console.ReadLine() always gives text.

             Because of that, we use Convert.ToInt32()
             to change the text into an integer.
            */

            int option = Convert.ToInt32(optionText);

            /*
             We prepare two variables:
             drinkName -> stores the selected coffee name
             basePrice -> stores the base price of the drink
            */

            string drinkName = "";
            double basePrice = 0;

            // ==========================================================
            // 4. Using Switch-Case for Coffee Selection
            // ==========================================================
            /*
             switch checks the value of option.

             Depending on the value,
             we assign:
             - the coffee name
             - the base price
            */

            switch (option)
            {
                case 1:
                    Console.WriteLine("You chose Espresso!");
                    drinkName = "Espresso";
                    basePrice = 3;
                    break;

                case 2:
                    Console.WriteLine("You chose Latte!");
                    drinkName = "Latte";
                    basePrice = 5;
                    break;

                case 3:
                    Console.WriteLine("You chose Cappuccino!");
                    drinkName = "Cappuccino";
                    basePrice = 6;
                    break;

                case 4:
                    Console.WriteLine("You chose Americano!");
                    drinkName = "Americano";
                    basePrice = 4;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    drinkName = "Unknown";
                    break;
            }

            Console.WriteLine();

            // ==========================================================
            // 5. Asking for the Coffee Size
            // ==========================================================
            /*
             Now the user chooses the coffee size.

             Again, the choice must be valid.
             We accept only:
             1 -> Large
             2 -> Medium
             3 -> Small
            */

            Console.WriteLine("Which size do you want?");
            Console.WriteLine("1. Large");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Small");
            Console.Write("Choose your size (1-3): ");
            string sizeText = Console.ReadLine().Trim();

            while (sizeText != "1" && sizeText != "2" && sizeText != "3")
            {
                Console.Write("Invalid input! Choose your size (1-3): ");
                sizeText = Console.ReadLine().Trim();
            }

            int size = Convert.ToInt32(sizeText);

            /*
             sizeOption -> stores size name
             sizeExtra  -> stores extra cost for the size
            */

            string sizeOption = "";
            double sizeExtra = 0;

            // ==========================================================
            // 6. Using Switch-Case for Size Selection
            // ==========================================================
            /*
             Here we decide the selected size
             and the extra price.

             Large  -> +2
             Medium -> +1
             Small  -> +0
            */

            switch (size)
            {
                case 1:
                    Console.WriteLine("You chose Large size.");
                    sizeOption = "Large";
                    sizeExtra = 2;
                    break;

                case 2:
                    Console.WriteLine("You chose Medium size.");
                    sizeOption = "Medium";
                    sizeExtra = 1;
                    break;

                case 3:
                    Console.WriteLine("You chose Small size.");
                    sizeOption = "Small";
                    sizeExtra = 0;
                    break;
            }

            Console.WriteLine();

            // ==========================================================
            // 7. Asking for Quantity
            // ==========================================================
            /*
             Now we ask how many coffees
             the customer wants.

             In this project,
             the maximum quantity is 3.

             So we validate the input again.
            */

            Console.Write("Enter quantity (maximum 3): ");
            string quantityText = Console.ReadLine().Trim();

            while (quantityText != "1" && quantityText != "2" && quantityText != "3")
            {
                Console.Write("Invalid input! You can buy maximum 3 coffees (1-3): ");
                quantityText = Console.ReadLine().Trim();
            }

            int quantity = Convert.ToInt32(quantityText);

            Console.WriteLine();

            // ==========================================================
            // 8. Asking for Coupon Information
            // ==========================================================
            /*
             We ask the customer if they have a coupon.

             The user must type:
             True or False

             Then we convert that text into bool
             by using Convert.ToBoolean().
            */

            Console.Write("Do you have a coupon? (True/False): ");
            string couponText = Console.ReadLine().Trim();

            while (couponText != "True" && couponText != "False")
            {
                Console.Write("Invalid input! Please enter True or False: ");
                couponText = Console.ReadLine().Trim();
            }

            bool coupon = Convert.ToBoolean(couponText);

            Console.WriteLine();

            // ==========================================================
            // 9. Generating a Random Order Number
            // ==========================================================
            /*
             Random class is used to create random numbers.

             Here we generate an order number
             between 1001 and 9998.
            */

            Random random = new Random();
            int orderNumber = random.Next(1001, 9999);

            // ==========================================================
            // 10. Calculating Prices
            // ==========================================================
            /*
             Now we calculate the prices step by step.

             singlePrice = base coffee price + size extra
             subtotal    = singlePrice * quantity

             This uses arithmetic operators.
            */

            double singlePrice = basePrice + sizeExtra;
            double subtotal = singlePrice * quantity;
            double discount = 0;

            /*
             If subtotal is 20 or more,
             we apply a 10% discount.

             This is done with if statement.
            */

            if (subtotal >= 20)
            {
                discount = subtotal * 10 / 100;
            }

            /*
             finalTotal starts as:
             subtotal - discount
            */

            double finalTotal = subtotal - discount;

            /*
             If the customer has a coupon
             and the total is at least 2,
             we subtract 2 more.

             Here we use:
             ==  means equal to
             &&  means AND
            */

            if (coupon == true && finalTotal >= 2)
            {
                finalTotal = finalTotal - 2;
            }

            /*
             Math.Round() rounds the final result
             to 2 decimal places.
            */

            finalTotal = Math.Round(finalTotal, 2);

            // ==========================================================
            // 11. Showing the Order Number
            // ==========================================================
            /*
             We now show the generated order number.
            */

            Console.WriteLine($"Your order number is: {orderNumber}");
            Console.WriteLine();

            // ==========================================================
            // 12. Printing Decorative Lines with a For Loop
            // ==========================================================
            /*
             A for loop is useful when we know
             exactly how many times something should repeat.

             Here we use it to print 10 stars.
            */

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            // ==========================================================
            // 13. Printing the Order Summary
            // ==========================================================
            /*
             Now we display all final information
             about the order.
            */

            Console.WriteLine($"Customer: {name}");
            Console.WriteLine($"Drink: {drinkName}");
            Console.WriteLine($"Size: {sizeOption}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Single Price: {singlePrice}");
            Console.WriteLine($"Subtotal: {subtotal}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Coupon Used: {coupon}");
            Console.WriteLine($"Final Total: {finalTotal}");
            Console.WriteLine($"Order Number: {orderNumber}");

            Console.WriteLine();

            // ==========================================================
            // 14. Printing a Receipt Border with Nested Loops
            // ==========================================================
            /*
             Nested loops mean:
             one loop inside another loop.

             Outer loop controls the rows.
             Inner loop controls the columns.

             This is useful for printing patterns.
            */

            Console.WriteLine("Receipt Border:");

            for (int row = 1; row <= 3; row++)
            {
                for (int column = 1; column <= 5; column++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}