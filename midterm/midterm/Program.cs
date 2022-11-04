using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char foodSelection;
            char drinkSelection;
            char desertSelection;
            var selections = new List<string>();
            var prices = new List<int>();
            char desert;
            char anotherOrder;
            int fortuneRand = 0;
            int total = 0;

            // Display Greeting and Menu
            Console.WriteLine("Welcome to Rigby Restaurant");

            // while another order
            do
            {
                Console.WriteLine("-----------------Food--------------------");
                Console.WriteLine("Pizza         Chicken           Spaghetti");
                Console.WriteLine("$20           $15               $25      ");
                Console.WriteLine("-----------------Drinks------------------");
                Console.WriteLine("Sprite         Coke          Mountain Dew");
                Console.WriteLine("$5             $4            $3          ");
                Console.WriteLine("-----------------Desert------------------");
                Console.WriteLine("Ice Cream     Pie           Cinnamon Roll");
                Console.WriteLine("$10           $12           $8           ");

                // Ask user to input their food choice as a character
                Console.WriteLine("Choose your food: ");
                foodSelection = Convert.ToChar(Console.ReadLine());

                if (foodSelection == 'P')
                {
                    selections.Add("Pizza");
                    prices.Add(10);
                }
                else if (foodSelection == 'C')
                {
                    selections.Add("Chicken");
                    prices.Add(15);
                }
                else if (foodSelection == 'S')
                {
                    selections.Add("Spaghetti");
                    prices.Add(25);
                }

                // Ask user to input their drink choice as a character
                Console.WriteLine("Choose your drink: ");
                drinkSelection = Convert.ToChar(Console.ReadLine());

                if (drinkSelection == 'S')
                {
                    selections.Add("Sprite");
                    prices.Add(5);
                }
                else if (drinkSelection == 'C')
                {
                    selections.Add("Coke");
                    prices.Add(4);
                }
                else if (drinkSelection == 'M')
                {
                    selections.Add("Mountain Dew");
                    prices.Add(3);
                }

                // Ask user if they would like desert
                Console.WriteLine("Would you like desert? ");
                desert = Convert.ToChar(Console.ReadLine());

                // If they do:
                if (desert == 'Y')
                {
                    // Ask user to input their desert choice as a character
                    Console.WriteLine("Choose your Desert: ");
                    desertSelection = Convert.ToChar(Console.ReadLine());

                    if (desertSelection == 'I')
                    {
                        selections.Add("Ice Cream");
                        prices.Add(10);
                    }
                    else if (desertSelection == 'P')
                    {
                        selections.Add("Pie");
                        prices.Add(12);
                    }
                    else if (desertSelection == 'C')
                    {
                        selections.Add("Cinnamon Roll");
                        prices.Add(8);
                    }
                }

                // Ask user if they would like to add another order
                Console.Write("Would you like to add another order? ");
                anotherOrder = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");

                // If they do:
                // Go back to output menu
            } while (anotherOrder == 'Y');
            
            // Else:
            // Display their order and their total
            for (int i = 0; i < selections.Count; i++)
            {
                Console.WriteLine(selections[i] + " for $" + prices[i].ToString());
                total += prices[i];
            }
            Console.WriteLine("Your total is " + total.ToString());
            // display a random fortune cookie quote

            // Display goodbye
            Random rnd = new Random();
            fortuneRand = rnd.Next(1, 10);

            Console.Write("Now your fortune cookie says: ");

            switch (fortuneRand)
            {
                case 1:
                    Console.WriteLine("Everyone agrees. You are the best.");
                    break;
                case 2:
                    Console.WriteLine("Be on the lookout for coming events; They cast their shadows beforehand.");
                    break;
                case 3:
                    Console.WriteLine("Meeting adversity well is the source of your strength.");
                    break;
                case 4:
                    Console.WriteLine("A stranger, is a friend you have not spoken to yet.");
                    break;
                case 5:
                    Console.WriteLine("A short stranger will soon enter your life with blessings to share.");
                    break;
                case 6:
                    Console.WriteLine("When fear hurts you, conquer it and defeat it!");
                    break;
                case 7:
                    Console.WriteLine("You are very talented in many ways.");
                    break;
                case 8:
                    Console.WriteLine("Your ability for accomplishment will follow with success.");
                    break;
                case 9:
                    Console.WriteLine("The love of your life is stepping into your planet this summer.");
                    break;
                case 10:
                    Console.WriteLine("Never give up. You're not a failure if you don't give up.");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Thank you for dining with us.");
        }
    }
}
