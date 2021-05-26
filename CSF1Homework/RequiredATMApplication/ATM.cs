using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework.RequiredATMApplication
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "Bank of C# ATM";

            int accountNumber = 159357;  //using in account # correct logic       
            string userAccountEntered; //using for user input
            string userPinEntered;  //using for user input
            bool accountNumberCorrect = false;  //using for continue to menu logic
            bool pinCorrect = false; //using for continue to menu logic
            bool repeatMenu = true; //using to repeat menu until user exts
            decimal balance = 0.00m; //using as starting bal per instructions & to keep running bal
            int accountAttemptCounter = 1; //using for incorrect account # attempts to lock out after 3
            int pinAttemptCounter = 1; //using for incorrect PIN attempts to lock out after 3


            Console.WriteLine("Welcome to the Bank of C#. Please enter your account number: "); //welcome and get user input
            userAccountEntered = Console.ReadLine();


            if (userAccountEntered == "159357") //if user account is correct, move to pin
            {
                accountNumberCorrect = true;
                Console.WriteLine("Correct account number entered.");
            }//end if


            else if (userAccountEntered != "159357") //if user account isn't correct, 3 attempts then locked out. If they get it right, move to pin
            {

                do
                {
                    Console.WriteLine("Incorrect Account Number. After 3 failed attempts, you will be locked out of your account.");
                    Console.ReadLine();
                    accountAttemptCounter++;
                } while (accountAttemptCounter < 3); //end do while
            }//end else if


            if (accountNumberCorrect) //moving onto pin if account # correct
            {
            Console.WriteLine("Please enter your PIN: "); 
            userPinEntered = Console.ReadLine();

            if (userPinEntered == "8224")  //if pin correct, moving on to menu
            {
                    pinCorrect = true;
                Console.WriteLine("Correct PIN entered.");
                Console.Clear();
            }//end inner if

            else if (userPinEntered != "8224") //if pin incorrect, 3 attempts then lock out. If correct, moving onto menu
            {
                do
                {
                    {
                            Console.WriteLine("Incorrect PIN. After 3 wrong attempts you will be locked out of your account.");
                            Console.ReadLine();
                        pinAttemptCounter++;
                    }//end for
                } while (pinAttemptCounter < 3);
            }//end else if
            }//end out if 

            if (accountNumberCorrect == true && pinCorrect == true) //menu section below, self explanatory
            {
                Console.WriteLine("Access Granted.");
                do
                {
                    Console.WriteLine("Please choose from the following menu options:\n" +
                        "1) Check Balance\n" +
                        "2) Make a Deposit\n" +
                        "3) Make a Withdrawal\n" +
                        "4) Log Out\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {

                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            Console.Write("How much would you like to deposit? $");
                            decimal userDeposit = decimal.Parse(Console.ReadLine());
                            balance += userDeposit;
                            Console.WriteLine($"You just deposited {userDeposit:c} into account number {accountNumber}.\n " +
                             $"Your balance is now {balance:c}.");
                            break;

                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            Console.Write("How much would you like to withdraw? $");
                            decimal userWithdrawal = decimal.Parse(Console.ReadLine());
                            balance -= userWithdrawal;
                            Console.WriteLine($"{userWithdrawal:c} has been withdrawn from account number {accountNumber}.\n" +
                                $"Your balance is now {balance:c}.");
                            break;

                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Console.WriteLine($"Your current balance is {balance}.");

                            break;

                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D4:
                            Console.WriteLine("Thank you for being a Bank of C# customer. Have a wonderful day!");
                            repeatMenu = false;
                            break;

                        default:
                            Console.WriteLine("not a valid option");
                            break;
                    }//end switch
                } while (repeatMenu); //end do 
            }//end if




            /* Failed/unused code:*/


            //int userAccount = 159357;
            //int userPin = 8442;
            //int userAccountEntered;
            //int userPinEntered;
            //int userBalance = 0; //need this so I can calculate running balance later?
            //bool menuRepeat = true;

            //Console.WriteLine("Welcome to the Bank of C#. Please enter your account number: ");
            //userAccountEntered = Convert.ToInt32(Console.ReadLine());


            ////Console.WriteLine("Please enter your PIN: ");
            ////userPinEntered = Convert.ToInt32(Console.ReadLine());

            //        while (userAccountEntered != 159357)
            //        {
            //            for (int accountAttempts = 0; accountAttempts < 3; accountAttempts++)
            //                {
            //                    Console.WriteLine("Incorrect entry. Please try again.");
            //                }//end for
            //        }//end while


            //if (userAccountEntered == 159357)
            //        {
            //        Console.WriteLine("Now please enter your pin.");
            //        }//end if


            //        else
            //        {
            //            //unsure what to put here
            //        }

            //do
            //{
            //    Console.WriteLine("Please choose from the following menu options:\n" +
            //            "1) Check Balance\n" +
            //            "2) Make a Deposit\n" +
            //            "3) Make a Withdrawal\n" +
            //            "4) Log Out");

            //    ConsoleKey userChoice = Console.ReadKey().Key;
            //    switch (userChoice)
            //    {
            //        case ConsoleKey.NumPad1:
            //        case ConsoleKey.D1:
            //            Console.WriteLine("Your current balance is: "); //come back to insert  bal
            //            break;

            //        case ConsoleKey.NumPad2:
            //        case ConsoleKey.D2:
            //            Console.WriteLine("How much would you like to deposit? $");
            //            decimal userDeposit = decimal.Parse(Console.ReadLine());
            //            Console.WriteLine($"You just deposited {userDeposit:c} into account number {userAccount}. Your balance is now  "); //need to come back and do calculation
            //            break;

            //        case ConsoleKey.NumPad3:
            //        case ConsoleKey.D3:
            //            Console.WriteLine("How much would you like to withdraw? $");
            //            decimal userWithdrawal = decimal.Parse(Console.ReadLine());
            //            Console.WriteLine($"{userWithdrawal:c} has been withdrawn from account number {userAccount}. Your balance is now  ");  //need to come back and do calculation
            //            break;

            //        case ConsoleKey.NumPad4:
            //        case ConsoleKey.D4:
            //            Console.WriteLine("Thank you for being a Bank of C# customer. Have a wonderful day!");
            //            break;


            //}//end switch


            //    } while (menuRepeat); // *****not sure what to enter here



            // bool correctAccount = false;
            //  bool correctPin = false;
            //    int userAttempts = 0; //do i need this for creating login attempt lockout?
            // string userPin;

            //if (userPin != "8224")
            //{
            //    correctPin = false;
            //    Console.WriteLine("Incorrect PIN. Please try again. Maximum 5 attempts accepted.");
            //}//end if


            //if (userAccount == "159357")
            //{
            //    correctAccount = true;
            //}//end if

            //if (userAccount != "159357")
            //{
            //    Console.WriteLine("Invalid Account Number. Please try again. Maximum 5 attempts accepted.");
            //}//end if

            //if (correctAccount == true)
            //{

            //}//end if


        }//end main
    }//end class
}//end namespace




//else if (accountNumberCorrect == true && pinCorrect == true)
//{
//    Console.WriteLine("Access Granted.");

//    do

//}//end if




/* Failed/unused code:*/


//int userAccount = 159357;
//int userPin = 8442;
//int userAccountEntered;
//int userPinEntered;
//int userBalance = 0; //need this so I can calculate running balance later?
//bool menuRepeat = true;

//Console.WriteLine("Welcome to the Bank of C#. Please enter your account number: ");
//userAccountEntered = Convert.ToInt32(Console.ReadLine());


////Console.WriteLine("Please enter your PIN: ");
////userPinEntered = Convert.ToInt32(Console.ReadLine());

//        while (userAccountEntered != 159357)
//        {
//            for (int accountAttempts = 0; accountAttempts < 3; accountAttempts++)
//                {
//                    Console.WriteLine("Incorrect entry. Please try again.");
//                }//end for
//        }//end while


//if (userAccountEntered == 159357)
//        {
//        Console.WriteLine("Now please enter your pin.");
//        }//end if


//        else
//        {
//            //unsure what to put here
//        }

//do
//{
//    Console.WriteLine("Please choose from the following menu options:\n" +
//            "1) Check Balance\n" +
//            "2) Make a Deposit\n" +
//            "3) Make a Withdrawal\n" +
//            "4) Log Out");

//    ConsoleKey userChoice = Console.ReadKey().Key;
//    switch (userChoice)
//    {
//        case ConsoleKey.NumPad1:
//        case ConsoleKey.D1:
//            Console.WriteLine("Your current balance is: "); //come back to insert  bal
//            break;

//        case ConsoleKey.NumPad2:
//        case ConsoleKey.D2:
//            Console.WriteLine("How much would you like to deposit? $");
//            decimal userDeposit = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"You just deposited {userDeposit:c} into account number {userAccount}. Your balance is now  "); //need to come back and do calculation
//            break;

//        case ConsoleKey.NumPad3:
//        case ConsoleKey.D3:
//            Console.WriteLine("How much would you like to withdraw? $");
//            decimal userWithdrawal = decimal.Parse(Console.ReadLine());
//            Console.WriteLine($"{userWithdrawal:c} has been withdrawn from account number {userAccount}. Your balance is now  ");  //need to come back and do calculation
//            break;

//        case ConsoleKey.NumPad4:
//        case ConsoleKey.D4:
//            Console.WriteLine("Thank you for being a Bank of C# customer. Have a wonderful day!");
//            break;


//}//end switch


//    } while (menuRepeat); // *****not sure what to enter here



// bool correctAccount = false;
//  bool correctPin = false;
//    int userAttempts = 0; //do i need this for creating login attempt lockout?
// string userPin;

//if (userPin != "8224")
//{
//    correctPin = false;
//    Console.WriteLine("Incorrect PIN. Please try again. Maximum 5 attempts accepted.");
//}//end if


//if (userAccount == "159357")
//{
//    correctAccount = true;
//}//end if

//if (userAccount != "159357")
//{
//    Console.WriteLine("Invalid Account Number. Please try again. Maximum 5 attempts accepted.");
//}//end if

//if (correctAccount == true)
//{

//}//end if




