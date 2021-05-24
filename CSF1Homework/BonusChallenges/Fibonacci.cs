using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.BonusChallenges
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci";
            /*
             * Write a program that outputs a Fibonnaci sequence, starting at 1 until a number that the user inputs is reached.
             * 
             * Not sure if prompt meant the number the user enters is the sequence number in the Fibonacci sequence? But that is how I interpreted it. It kind of reads at first like the number the user enters is the number (actual number in the sequence) that will print out (i.e. user inputs 30, sequence somehow stops at 30 even though it's not in the sequence).
             */

            int n1 = 0; //first fibo number
            int n2 = 1; //second fibo number
            int n3;
            Console.WriteLine("Please enter how many numbers from the Fibonacci Sequence you would like to see:  ");
            int userNumber = Convert.ToInt32(Console.ReadLine());  //this is the length of the sequence that will print
            Console.Write(n1 + " " + n2);

            for (int i = 2; i < userNumber; i++) //loop starts at 2 since 0 and 1 were defined above
            {
                n3 = n1 + n2;  //the way fibonacci works is the current number is the sum of the 2 preceding numbers (so 3rd number = 1st number + 2nd number)
                Console.Write(" " + n3); //new fibo number, space is to have empty space between numbers
                n1 = n2; //what was the 2nd number is now the first
                n2 = n3; //what was the 3rd number before is now the 2nd - this is how you move forward through the sequence
            }
            Console.WriteLine();


        }//end main
    }//end class
}//end namespace
