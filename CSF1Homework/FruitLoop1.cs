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

        }//end main
    }//end class
}//end namespace
