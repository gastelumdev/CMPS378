using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool cont = true;
            string month = "";
            int day = 0;
            int year = 0;

            // Welcome message
            System.Console.WriteLine("Welcome to Birthday Date Meaning Generator!");

            // Check if the user wants to continue
            while (cont)
            {
                // Get the month
                System.Console.WriteLine("Please enter the month of your birthday: ");
                month = System.Console.ReadLine();

                // Get the day
                System.Console.WriteLine("Please enter the day of your birthday: ");
                day = Convert.ToInt32(System.Console.ReadLine());

                // Get the year
                System.Console.WriteLine("Please enter the year of your birthday: ");
                year = Convert.ToInt32(System.Console.ReadLine());

                // Output based on the month
                switch (month)
                {
                    case "January":
                        Console.WriteLine("The month of January means Janus");
                        break;
                    case "February":
                        Console.WriteLine("The month of February means Februalia");
                        break;
                    case "March":
                        Console.WriteLine("The month of March means Mars");
                        break;
                    case "April":
                        Console.WriteLine("The month of April means aperire");
                        break;
                    case "May":
                        Console.WriteLine("The month of May means Maia");
                        break;
                    case "June":
                        Console.WriteLine("The month of June means Youth");
                        break;
                    case "July":
                        Console.WriteLine("The month of July means Julius Caesar");
                        break;
                    case "August":
                        Console.WriteLine("The month of August means Augustus Caesar");
                        break;
                    case "September":
                        Console.WriteLine("The month of September means Seven");
                        break;
                    case "October":
                        Console.WriteLine("The month of October means Eight");
                        break;
                    case "November":
                        Console.WriteLine("The month of November means Nine");
                        break;
                    case "December":
                        Console.WriteLine("The month of December means Ten");
                        break;
                    default:
                        break;
                }

                // Output based on the day
                switch (day)
                {
                    case 1:
                        Console.WriteLine("The 1st of " + month + " means self-starter.");
                        break;
                    case 2:
                        Console.WriteLine("The 2nd of " + month + " means great talent for finding solutions.");
                        break;
                    case 3:
                        Console.WriteLine("The 3rd of " + month + " means expression comes naturally.");
                        break;
                    case 4:
                        Console.WriteLine("The 4th of " + month + " means you bring stability.");
                        break;
                    case 5:
                        Console.WriteLine("The 5th of " + month + " means flexible is your forte.");
                        break;
                    case 6:
                        Console.WriteLine("The 6th of " + month + " means your heart is your gift.");
                        break;
                    case 7:
                        Console.WriteLine("The 7th of " + month + " means you possess a refined mind.");
                        break;
                    case 8:
                        Console.WriteLine("The 8th of " + month + " means yours is a story of success.");
                        break;
                    case 9:
                        Console.WriteLine("The 9th of " + month + " means compassion makes you shine.");
                        break;
                    case 10:
                        Console.WriteLine("The 10th of " + month + " means great great leadership skills.");
                        break;
                    case 11:
                        Console.WriteLine("The 11th of " + month + " means keen awareness.");
                        break;
                    case 12:
                        Console.WriteLine("The 12th of " + month + " means creativity is the driving force.");
                        break;
                    case 13:
                        Console.WriteLine("The 13th of " + month + " means conscientious worker.");
                        break;
                    case 14:
                        Console.WriteLine("The 14th of " + month + " means open-minded.");
                        break;
                    case 15:
                        Console.WriteLine("The 15th of " + month + " means your love for other is powerful.");
                        break;
                    case 16:
                        Console.WriteLine("The 16th of " + month + " means inquisitive mind.");
                        break;
                    case 17:
                        Console.WriteLine("The 17th of " + month + " means the quality of work you can produce when you're going it alone is almost unbelievable.");
                        break;
                    case 18:
                        Console.WriteLine("The 18th of " + month + " means open-minded and open-hearted.");
                        break;
                    case 19:
                        Console.WriteLine("The 19th of " + month + " means independence and self-sufficient.");
                        break;
                    case 20:
                        Console.WriteLine("The 20th of " + month + " means you relate to other on an almost cosmic level.");
                        break;
                    case 21:
                        Console.WriteLine("The 21st of " + month + " means you thrive in active social settings.");
                        break;
                    case 22:
                        Console.WriteLine("The 22nd of " + month + " means power to create great things.");
                        break;
                    case 23:
                        Console.WriteLine("The 23rd of " + month + " means eager to experience anything and everything possible.");
                        break;
                    case 24:
                        Console.WriteLine("The 24th of " + month + " means you have a heart of gold and are very skilled at maintaining balanced, stable relationships.");
                        break;
                    case 25:
                        Console.WriteLine("The 25th of " + month + " means You have a great ability to take in and process information on both conscious and subconscious levels.");
                        break;
                    case 26:
                        Console.WriteLine("The 26th of " + month + " means you have a desire to succeed and will feel most accomplished when your work benefits others.");
                        break;
                    case 27:
                        Console.WriteLine("The 27th of " + month + " means your mind is wide open and you are tolerant and compassionate toward all ways of life.");
                        break;
                    case 28:
                        Console.WriteLine("The 28th of " + month + " means in an effort to accomplish great things, you recognize the value of working with others..");
                        break;
                    case 29:
                        Console.WriteLine("The 29th of " + month + " means you have an amazing ability to bring things together.");
                        break;
                    case 30:
                        Console.WriteLine("The 30th of " + month + " means you are an original, innovative thinker and an excellent communicator.");
                        break;
                    case 31:
                        Console.WriteLine("The 31st of " + month + " means your approach to life is an effective mix of both practicality and imagination..");
                        break;
                    default:
                        break;
                }

                // Output generation
                if (year > 1900 && year <= 1924)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Greatest Generation.");
                } 
                else if (year > 1924 && year <= 1945)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Silent Generation.");
                }
                else if (year > 1945 && year <= 1964)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Baby Boom Generation.");
                }
                else if (year > 1964 && year <= 1980)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Generation X.");
                }
                else if (year > 1980 && year <= 1996)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Millennial Generation.");
                }
                else if (year > 1996 && year <= 2010)
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Generation Z.");
                } else
                {
                    Console.WriteLine("The year of " + year + " means you are part of the Generation Alpha.");
                }

                // Check if the user wants to try again
                System.Console.WriteLine("Would you like to try another one? (N to stop)");
                choice = System.Console.ReadLine();

                if (choice == "N")
                {
                    cont = false;
                }
            }

            System.Console.WriteLine("Thanks for playing!");

        }
    }
}
