using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialBalance = 0;
            double interestRate = 0;
            string compoundInterval = "";
            int intervals = 0;
            double result = 0;

            // App header
            Console.WriteLine("---------Compound Interest Calculator--------");
            // Get the initial investment amount
            Console.WriteLine("Enter the initial balance: $");
            initialBalance = Convert.ToDouble(Console.ReadLine());
            // Get the interest rate on the investment
            Console.WriteLine("Enter the interest rate on the investment: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            // Get the compound interval
            Console.WriteLine("Enter the interval at which the investment will compound (options are yearly, monthly, weekly, daily): ");
            compoundInterval = Console.ReadLine();
            // Enter the number of intervals
            switch (compoundInterval)
            {
                case "yearly":
                    Console.WriteLine("Enter the amount of years: ");
                    intervals = Convert.ToInt32(Console.ReadLine());
                    break;
                case "monthly":
                    Console.WriteLine("Enter the amount of months: ");
                    intervals = Convert.ToInt32(Console.ReadLine());
                    break;
                case "weekly":
                    Console.WriteLine("Enter the amount of weeks: ");
                    intervals = Convert.ToInt32(Console.ReadLine());
                    break;
                case "daily":
                    Console.WriteLine("Enter the amount of days: ");
                    intervals = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    break;
            }

            result = initialBalance;

            for (int i = 0; i < intervals; i++)
            {
                result += (result * interestRate);
            }

            result = Math.Round(result, 2);

            Console.WriteLine($"The initial investment of {initialBalance} will compound to ${result} after {intervals} intervals.");
        }
    }
}
