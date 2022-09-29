using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            char decision1 = ' ', decision2 = ' ', decision3 = ' ';
            char item1 = ' ', item2 = ' ', item3 = ' ';
            int quantity1 = 0, quantity2 = 0, quantity3 = 0;
            // Restaurant Greeting
            Console.WriteLine("Welcome to Juan's Pizza Kitchen!");
            // Menu
            // Pizzas
            Console.WriteLine("Pizzas - Up to 2 toppings");
            Console.WriteLine("Small -   $8.50");
            Console.WriteLine("Medium -  $10.00");
            Console.WriteLine("Large -   $11.50");
            Console.WriteLine("X-Large - $14.00");
            // Fried Chicken
            Console.WriteLine("Chicken");
            Console.WriteLine("3 Pc -    $6.50");
            Console.WriteLine("6 Pc -    $11.00");
            Console.WriteLine("9 Pc -    $15.00");
            Console.WriteLine("12 Pc -   $20.00");
            // Drinks
            Console.WriteLine("Drinks");
            Console.WriteLine("Small -   $1.50");
            Console.WriteLine("Medium -  $1.80");
            Console.WriteLine("Large -   $2.00");
            Console.WriteLine("X-Large - $2.20");

            // Get input for pizza
            Console.WriteLine("Would you like to order pizza? (Y/N)");
            decision1 = Convert.ToChar(Console.ReadLine());
            // If answer is yes add the corresponding value to the total
            if (decision1 == 'Y')
            {
                Console.WriteLine("What size pizza would you like? (S/M/L/X)");
                item1 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("How many pizzas would you like?");
                quantity1 = Convert.ToInt32(Console.ReadLine());

                if (item1 == 'S')
                {
                    total += 8.5 * quantity1;
                }
                else if (item1 == 'M')
                {
                    total += 10 * quantity1;
                }
                else if (item1 == 'L')
                {
                    total += 11.5 * quantity1;
                }
                else if (item1 == 'X')
                {
                    total += 14 * quantity1;
                }
            }

            // Get input for chicken
            Console.WriteLine("Would you like to order chicken? (Y/N)");
            decision2 = Convert.ToChar(Console.ReadLine());
            // If answer is yes add the corresponding value to the total
            if (decision2 == 'Y')
            {
                Console.WriteLine("What size chicken basket would you like? (3/6/9/T for 10Pc)");
                item2 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("How many baskets of chicken would you like?");
                quantity2 = Convert.ToInt32(Console.ReadLine());

                if (item2 == '3')
                {
                    total += 6.5 * quantity2;
                }
                else if (item2 == '6')
                {
                    total += 11 * quantity2;
                }
                else if (item2 == '9')
                {
                    total += 15 * quantity2;
                }
                else if (item2 == 'T')
                {
                    total += 20 * quantity2;
                }
            }

            // Get input for drinks
            Console.WriteLine("Would you like to order a drink? (Y/N)");
            decision3 = Convert.ToChar(Console.ReadLine());
            // If answer is yes add the corresponding value to the total
            if (decision3 == 'Y')
            {
                Console.WriteLine("What size drink would you like? (S/M/L/X)");
                item3 = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("How many drinks would you like?");
                quantity3 = Convert.ToInt32(Console.ReadLine());

                if (item3 == 'S')
                {
                    total += 1.5 * quantity3;
                }
                else if (item3 == 'M')
                {
                    total += 1.8 * quantity3;
                }
                else if (item3 == 'L')
                {
                    total += 2 * quantity3;
                }
                else if (item3 == 'X')
                {
                    total += 2.2 * quantity3;
                }
            }

            // Total for the purchase
            Console.WriteLine($"Your total is {total}");
            Console.WriteLine("Thanks for dining at Juan's Pizza Kitchen! Have a good day!");
        }
    }
}
