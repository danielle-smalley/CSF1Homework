using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.BonusChallenges
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Title = "FizzBuzz";
            /*
             * Write a program that counts up from 1 to a number that the user enters.
             * Any time a number divisible by 3 would display, print the word "Fizz" instead.
             * Any time a number divisible by 5 would display, print the word "Buzz" instead.
             * If a number is divisible by both 3 & 5, write "FizzBuzz" instead.
             * Ex: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz
             */


            Console.WriteLine("Please enter a whole number greater than 1: ");
            int endingNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= endingNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }//end if

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }//end else if

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }//end else if
            }//end for


        }//end main
    }//end class
}//end namespace
