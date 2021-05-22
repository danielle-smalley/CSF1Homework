using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework: Temperature Converter");
            /*
             * 1. Write a program that asks the user for a temperature in Celsius and converts it to Fahrenheit. The conversion is done by multiplying the Celsius temp by 9/5 and then adding 32 (fah = cel * (9.0/5.0) + 32).
             * When testing your program, use 100 degrees Celsius as an example - the result should be 212 degrees Fahrenheit.
             * 2. Next, write additional functionality that asks the user for a Fahrenheit temperature and converts it to Celsius.
             * The conversion is done by taking the Fahrenheit temp, subtracting 32, then diving by 9/5. (cel = (fah - 32) / (9.0/5.0)
             * 3. Then, build out a menu that allows the user to choose whether they wish to convert Celsius to Fahrenheit or Fahrenheit to Celsius.
             * Remember, you'll want to capture the user's input, and then utilize the two pieces of functionality you built (steps 1 & 2) to show the result.
             * 4. Lastly, extend the functionality to ask if they have anotherh conversion once you have shown them their initial result. Reload the menu if they choose yes.
             */

            Console.WriteLine("Please enter a temperature in Celsius so I can convert it to Fahrenheit for you: ");
            int userCelsiusTemp = Convert.ToInt32(Console.ReadLine());

        }//end main
    }//end class
}//end namespace
