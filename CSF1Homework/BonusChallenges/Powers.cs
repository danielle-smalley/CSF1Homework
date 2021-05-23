using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.BonusChallenges
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.Title = "Powers";

            /*
             * Using a FOR loop, display the powers of 2 from 1 to 50.
             * (2 to the 1st power through 2 to the 50th power).
             * Use a long variable to store your results
             * Ex: 2 to the 4th power is 2 x 2 x 2 x 2.
             */

            long startingNumber = 1; //starting at 1, using long instead of int here

            for (int i = 0; i < 50; i++) //power starts at power of 0, will go up to power of 50, incrementing by +1 power each time.
            {
                startingNumber *= 2; //to get our calculation, we are multiplying by 2 each time
                Console.WriteLine(startingNumber); //display results
            }//end for

            }//end main
    }//end class
}//end namespace
