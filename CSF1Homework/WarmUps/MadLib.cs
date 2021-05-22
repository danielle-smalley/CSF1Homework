using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework: MadLib Warm Up");

            /*
             * Create a "mad lib" that asks the user for various pieces of information.
             * Store the information as strings.
             * Once the information has been collected, output a story using the stored info.
             */

            Console.WriteLine("Hello! Welcome to Mad Libs.\n" +
                "Please enter an answer to each prompt below.\n" +
                "Unless otherwise specified, verbs should be in present tense (i.e. swim, run, jump).\n" +
                "A prompt for a noun will be for a singular one unless otherwise noted.'n" +
                "Adjectives are words that describe nouns (think green, round, silly, small, big, wonderful).");

            Console.WriteLine("Animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("Plural Noun: ");
            string pluralNoun = Console.ReadLine();
            Console.WriteLine("A food: ");
            string food = Console.ReadLine();
            Console.WriteLine("Noun: ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Noun: ");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("Verb: ");
            string verbOne = Console.ReadLine();
            Console.WriteLine("Verb: ");
            string verbTwo = Console.ReadLine();
            Console.WriteLine("Adjective: ");
            string adjective = Console.ReadLine();

            Console.WriteLine($"The majestic {animal} has roamed the forests of {country} for thousands of years. Today, she wanders in search of {pluralNoun}. She must find food to survive. While hunting for {food}, she found a/an {nounOne} hidden behind a {nounTwo}. She has never seen anything like this before! What will she do? With the {nounOne} in her teeth, she tries to {verbOne}, but nothing happens. She takes it back to her family. When her family sees it, they quickly {verbTwo}. Soon, the {nounOne} becomes {adjective}, and the family decides to put it back where they found it. The end!");
        }//end main
    }//end class
}//end namespace
