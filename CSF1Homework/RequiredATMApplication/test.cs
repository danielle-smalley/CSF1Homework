using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.RequiredATMApplication
{
    class test
    {
        static void Main(string[] args)
        {
            int accountNumber = 159357;
            int userPin = 8224;
            //bool accountNumberEntered = false;
            //bool userPinEntered = false;

            Console.WriteLine("Please enter your account number");
            int accountNumberEntered = Convert.ToInt32(Console.ReadLine());

            if (accountNumberEntered == 159357)
            {
                Console.WriteLine("Please enter your PIN");
                int userPinEntered = Convert.ToInt32(Console.ReadLine());

                if (userPinEntered == 8224)
                {
                    Console.WriteLine("Access Granted"); //go to the menu after this
                }//end if

                else if (userPinEntered != 8224)
                {
                    do
                    {
                        Console.WriteLine("Invalid PIN. Please try again.");

                        for (int i = 1; i < 3; i++)
                        {
                            i++;
                        }//end for

                    } while (userPin != 8224); //end do
                }//end else if

            }//end if

            else if (accountNumberEntered != 159357)
            {
                Console.WriteLine("Incorrect account number. Please try again.");
                for (int a = 1; a < 3; a++)
                {
                    a++;
                }//end for
            }//end else if

            else //is this needed?
            {
                Console.WriteLine("Invalid Entry. Returning to login screen...");
            }//end else

            

        }//end main
    }//end class
}//end namespace
