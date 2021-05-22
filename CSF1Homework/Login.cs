using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework: Login Exercise");

            /*
             * 1. Ask the user for their username.
             * 2. If it matches your one hard-coded correct username, tell the user that they have access. 
             * If not, tell the user that they have been denied access.
             * 3. Make sure the usernames (hard-coded and user input) are case insensitive (uppercase or lowercase).
             * Additional Functionality - After the above default functionality is completed:
             * 4. Encase the username functionality in a loop that allows the user to make another attempt if the previous attempt was unsuccessful.
             * 5. Extend the loop functionality to deny access to the user if they enter the wrong username 3 times.
             * 6. Extend updated username functionality to ask for a password if the user entered the correct username. Deny access if the password is entered incorrectly 3 times (Note: 3 attempts at username, if correct username is entered, give 3 attempts for the correct password).
             */


            //user attempts counter
            int userAttempts = 0; //setting to 0 to start

            string username;
            string userPassword;

            //using for loop so I can account for user attempts
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter username: ");
                username = Console.ReadLine().ToUpper();      //user can enter in any case, it will convert to upper
                Console.WriteLine("Please enter your password: ");
                userPassword = Console.ReadLine();           //didn't convert, want password to be case sensitive for security

                if (username != "JAMESBOND" || userPassword != "DOUBLEOHSEVEN") //if either username or userpassword is wrong, will add to count and start over
                    userAttempts++; //counting against userattempts counter 
                else
                    break; //have to end loop or will keep running (error?)
            }

            //need to show denied message, or success message
            if (userAttempts > 2)
                Console.WriteLine("Access denied. The system shows 3 unsuccessful attempts. You are now locked out of the system.");
            else
                Console.WriteLine("Access granted. Welcome, Mr. Bond.");

            /*
             * FAILED CODE/thinking it out code below
             */


            //bool correctUserName = false;
            //string userName;

            //int userNameAttempts = 0;
            //int userNameLimit = 3;

            //Console.WriteLine("Please enter your username: ");
            //userName = Console.ReadLine().ToUpper();

            //while (userNameAttempts <= userNameLimit)
            //{
            //    Console.WriteLine("Access denied.");
            //    userNameAttempts++;
            //}//end while

            //Console.Clear();

            //bool moreAttempts = true;
            //int userAttempts = 0;
            //string userPassword;
            //bool correctUserPassword = false;

            //while (moreAttempts)
            //{
            //    if (userName == "JAMESBOND")
            //    {
            //        correctUserName = true;
            //    }//end if


            //    if (correctUserName)
            //    {
            //        Console.WriteLine("Username correct. Hello, Mr. Bond.");

            //    }//end if
            //    Console.WriteLine("Please enter your password: ");
            //    userPassword = Console.ReadLine();

            //    if (userPassword == "DOUBLEOHSEVEN")
            //    {
            //        correctUserPassword = true;
            //        Console.Clear();
            //        Console.WriteLine("Full access now granted");
            //    }



            //    else
            //    {
            //        Console.WriteLine("Access Denied.");
            //        Console.WriteLine("Would you like to try again?\n" +
            //            "Y)es or\n" +
            //            "N)o?");
            //        ConsoleKey userChoice = Console.ReadKey().Key;
            //        Console.Clear();

            //        switch (userChoice)
            //        {
            //            case ConsoleKey.N:
            //                Console.WriteLine("Console shutting down. Goodbye.");
            //                break;

            //            case ConsoleKey.Y:

            //                break;

            //        }//end switch
            //    }//end else

            //bool correctUserName = false;
            //bool correctPassword = false;
            //string userName;
            //string userPassword;

            //Console.WriteLine("Please enter your username: ");
            //userName = Console.ReadLine().ToUpper();

            //if (userName == "JAMESBOND")
            //{
            //    correctUserName = true;
            //}//end if 

            //if (correctUserName == true)
            //{
            //    Console.WriteLine("Username accepted. Please enter your password: ");
            //    userPassword = Console.ReadLine();
            //    if (userPassword == "DOUBLEOHSEVEN")
            //    {
            //        correctPassword = true;  
            //    }//end if
            //}//end if

            //if (correctUserName == false)
            //{
            //    Console.WriteLine("Access denied. Please try again.");
            //}//end if

            //if (correctPassword == true)
            //{
            //    Console.WriteLine("Access granted. Welcome, Mr. Bond");
            //}//end if

            //if (correctPassword == false)
            //{
            //    Console.WriteLine("Incorrect password. Please try again.");
            //}//end if

            //   do
            // {
            //  
            //} while (repeatMenu);

        }//end main
    }//end class
    }//end namespace
