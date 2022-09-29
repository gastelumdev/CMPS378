using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompoundInterestCalc
{
    // Class variables
    private double initialBalance = 0;
    private double interestRate = 0;
    private int intervals = 0;
    private double result = 0;

    public CompoundInterestCalc(double initialBalance, double interestRate, int intervals)
    {
        // Set instance variables to input values passed in to class
        this.initialBalance = initialBalance;
        this.interestRate = interestRate;
        this.intervals = intervals;
    }
    // Getter and Setters for class properties
    public double InitialBalance { get { return initialBalance; } set { initialBalance = value; } }
    public double InterestRate { get { return interestRate; } set { interestRate = value; } }
    public int Intervals { get { return intervals; } set { intervals = value; } }
    // Calculater the compound interest and return it
    public double calculate()
    {
        this.result = this.initialBalance;

        for (int i = 0; i < this.intervals; i++)
        {
            this.result += (this.result * this.interestRate);
        }

        return Math.Round(this.result, 2);
    }
}

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables that will be obtained by input
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

            // Create object with its parameters
            CompoundInterestCalc Calc = new CompoundInterestCalc(initialBalance, interestRate, intervals);
            // Call the calculate method and get the result and then display it
            result = Calc.calculate();
            Console.WriteLine($"The initial investment of {initialBalance} will compound to ${result} after {intervals} intervals.");

        }
    }
}
