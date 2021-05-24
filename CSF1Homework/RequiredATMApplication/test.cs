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
            bool incorrectAccount1 = true;
            bool incorrectPin1 = true;

            do
            {
                int userAccountNumber = 159357;
                Console.WriteLine("Welcome to the Bank of C#. Please enter your account number: ");
                int userEnteredAccountNumber = Convert.ToInt32(Console.ReadLine());

                if (userAccountNumber == userEnteredAccountNumber)
                {
                    incorrectAccount1 = false;
                    do
                    {
                        int userAccountPin = 8224;
                        Console.WriteLine("Please enter your PIN: ");
                        int userEnteredPin = Convert.ToInt32(Console.ReadLine());
                        if (userAccountPin == userEnteredPin)
                            {
                            Console.WriteLine("Account access granted.");
                            incorrectPin1 = false;
                            }//end if
                        else
                        {
                            Console.WriteLine("Account access denied. Please try again.");
                        }

                    } while (incorrectPin1); //end do
                }//end if
            } while (incorrectAccount1); //end do


//            //Another Attempt:
//            Console.Title = "Bank of C# ATM";

//            int accountNumber = 159357;
//            int userPin = 8224;
//            bool accountNumberCorrect = false;
//            bool pinCorrect = false;
//            bool repeatMenu = true;
//            decimal balance = 0.00m;
//            int accountAttemptCounter = 0;
//            int pinAttemptCounter = 0;


//            Console.WriteLine("Welcome to the Bank of C#. Please enter your account number: ");
//            int userAccountEntered = Convert.ToInt32(Console.ReadLine());


//            if (userAccountEntered == 159357) // if they entered their account correctly, 
//            {
//                do      //do - stuff for account # correct
//                {
//                    accountNumberCorrect = true; //switching the bool on
//                    Console.WriteLine("Correct account number entered.");
//                    Console.WriteLine("Please enter your account PIN: ");
//                    int userPinEntered = Convert.ToInt32(Console.ReadLine());

//                    if (userPinEntered == 8224) //if they also entered their pin correctly,
//                    {
//                        do  //stuff to do if PIN also correct
//                        {
//                            Console.WriteLine("Please choose from the following menu options:          \n" +
//                                "1) Check Balance\n" +
//                                "2) Make a Deposit\n" +
//                                "3) Make a Withdrawal\n" +
//                                "4) Log Out\n");

//                            ConsoleKey userChoice = Console.ReadKey(true).Key;
//                            switch (userChoice)
//                            {
//                                case ConsoleKey.NumPad1:
//                                case ConsoleKey.D1:
//                                    Console.WriteLine($"Your current balance is: {0:c}", balance);
//                                    break;

//                                case ConsoleKey.NumPad2:
//                                case ConsoleKey.D2:
//                                    Console.WriteLine("How much would you like to deposit? $");
//                                    decimal userDeposit = decimal.Parse(Console.ReadLine());
//                                    balance += userDeposit;
//                                    Console.WriteLine($"You just deposited {userDeposit:c} into                 account number {accountNumber}.\n " +
//                                     $"Your balance is now {balance:c}.");
//                                    break;

//                                case ConsoleKey.NumPad3:
//                                case ConsoleKey.D3:
//                                    Console.WriteLine("How much would you like to withdraw?                    $");
//                                    decimal userWithdrawal = decimal.Parse(Console.ReadLine());
//                                    balance -= userWithdrawal;
//                                    Console.WriteLine($"{userWithdrawal:c} has been withdrawn                   from account number {accountNumber}.\n" +
//                                        $"Your balance is now {balance:c}.");
//                                    break;

//                                case ConsoleKey.NumPad4:
//                                case ConsoleKey.D4:
//                                    Console.WriteLine("Thank you for being a Bank of C#                         customer. Have a wonderful day!");
//                                    repeatMenu = false;
//                                    break;

//                                default:
//                                    Console.WriteLine("not a valid option");
//                                    break;

//                            }//end switch
//                        } while (repeatMenu == true && accountNumberCorrect == true && pinCorrect == true);
//                    } //end do

//                    else if (userPinEntered != 8224) //if PIN is incorrect
//                    {
//                        do //do this stuff
//                        {
//                            Console.WriteLine("Incorrect. Please try again.");
//                            pinAttemptCounter++;
//                        } while (pinAttemptCounter <= 3 && pinCorrect == false); //end do 
//                    } //end else if

//                    else if (userAccountEntered != 159357) //if user account number is wrong
//                    {
//                        do  //do these things
//                        {
//                            Console.WriteLine("Incorrect Account Number. Please try again.");
//                            accountAttemptCounter++;
//                        } while (accountAttemptCounter < 3 && accountNumberCorrect == false); //end do while
//                    }//end else if
//                } while (true);
//            } while (true) ; //end do ****COME BACK AND EDIT***
//        }//end main
//    }//end class
//}//end namespace




            //int accountNumber = 159357;
            //int userPin = 8224;
            ////bool accountNumberEntered = false;
            ////bool userPinEntered = false;

            //Console.WriteLine("Please enter your account number");
            //int accountNumberEntered = Convert.ToInt32(Console.ReadLine());

            //if (accountNumberEntered == 159357)
            //{
            //    Console.WriteLine("Please enter your PIN");
            //    int userPinEntered = Convert.ToInt32(Console.ReadLine());

            //    if (userPinEntered == 8224)
            //    {
            //        Console.WriteLine("Access Granted"); //go to the menu after this
            //    }//end if

            //    else if (userPinEntered != 8224)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Invalid PIN. Please try again.");

            //            for (int i = 1; i < 3; i++)
            //            {
            //                i++;
            //            }//end for

            //        } while (userPin != 8224); //end do
            //    }//end else if

            //}//end if

            //else if (accountNumberEntered != 159357)
            //{
            //    Console.WriteLine("Incorrect account number. Please try again.");
            //    for (int a = 1; a < 3; a++)
            //    {
            //        a++;
            //    }//end for
            //}//end else if

            //else //is this needed?
            //{
            //    Console.WriteLine("Invalid Entry. Returning to login screen...");
            //}//end else

            

        }//end main
    }//end class
}//end namespace
