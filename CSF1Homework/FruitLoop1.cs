using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warm-Up Exercise: Fruit Loops Part 1");
            /*
             * Warm-Up Exercise - Fruit Loops
             * Declare and initialize an array of any six fruit names (as text).
             * Set up a for loop and iterate through them (displaying each value in the console).
             * 
             * Part 2 is included below. The prompt was:
             * Repeat the FruitLoop1 exercise, but for each of the fruit names that you display, on the next line dislpay a number of periods that is equal to the number of the index of the array.
             */

            //string[] fruits = new string[6]; //declaration
            //fruits[0] = "lime"; //initialization
            //fruits[1] = "orange";
            //fruits[2] = "lemon";
            //fruits[3] = "strawberry";
            //fruits[4] = "watermelon";
            //fruits[6] = "grape";

            string[] fruits = { "lime", "orange", "lemon", "strawberry", "watermelon", "grape" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
                if (i == 0)
                {
                    Console.WriteLine(" "); //no periods here, this fruit is [0] index on array.
                }//end if
                if (i == 1)
                {
                    Console.WriteLine(".");
                }//end if
                if (i == 2)
                {
                    Console.WriteLine("..");
                }//end if
                if (i == 3)
                {
                    Console.WriteLine("...");
                }//end if
                if (i == 4)
                {
                    Console.WriteLine("....");
                }//end if
                if (i == 5)
                {
                    Console.WriteLine(".....");
                }//end if

            }//end for loop




            //string[] fruits = {"lime", "orange", "lemon", "strawberry", "watermelon", "grape"};

            //Console.WriteLine("Here are the fruits we have: ");
            //int fruit = (Convert.ToInt32(fruits));

            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.WriteLine(fruits);
            //}

        }//end main
    }//end class
}//end namespace
