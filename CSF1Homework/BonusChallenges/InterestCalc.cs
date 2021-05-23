using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.BonusChallenges
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.Title = "Interest Calculator";
            /*
             * Write a program to calculate interest for a given amount. 
             * The program should ask the user for a beginning balance, interest rate, and number of years.
             * Print the amount of money they would have (after the specified number of years) if the money is compounded annually with no additional deposits.
             * for example:
             * Enter the beginning balance: 1000.0
             * Enter the interest rate percentage: 5
             * Enter the number of years: 2
             * The amount you will have in 2 years is 1102.50
             */

            Console.WriteLine("Please enter your beginning balance: $ ");
            decimal beginningBalance = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your interest rate: ");
            decimal interestRate = Decimal.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Please enter the number of years: ");
            decimal years = Decimal.Parse(Console.ReadLine());

            // decimal totalAmount = beginningBalance * interestRate * years;

            //int annualCompound = 0;
            //decimal years = 0;



            //for (int i = 1; i < years + 1; i++)
            //{
            //    //   decimal totalAmount = beginningBalance * Math.Pow(Convert.ToDecimal(1 + interestRate / annualCompound),
            //    //      (annualCompound * i));

            //    result = amount * Math.Pow((1 + roi / annualCompound), (annualCompound * loop));
            //    Console.WriteLine("Your amount after {0} Year " + ": {1}", loop, result);
            //}

         //   Console.WriteLine($"The amount you will have in {years} years is {totalAmount}.");

        }//end main
    }//end class
}//end namespae
