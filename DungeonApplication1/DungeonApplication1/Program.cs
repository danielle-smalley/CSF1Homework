using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Title = "Dungeon of Doom!";
                Console.WriteLine("Your journey  begins...");

                //score running total variable
                int score = 0;

                //TODO - create the player
                //need to learn custom classes for this
                //create a weapon & creating the player with the weapon included

                //create the outer loop - for the room and monster
                bool exit = false;

                do
                {
                //TODO - Create a monster array

                //TODO - Load a room
                Console.WriteLine(GetRoom()); 

                    //TODO - Randomly select a monster to fight

                    //TODO - Show the monster in the room

                    //Inner loop for menu
                    bool reload = false;

                    do
                    {
                        //Create a menu 
                        #region Menu
                        Console.Write("\nPlease Choose an Action:\n" +
                            "A) Attack\n" +
                            "R) Run Away\n" +
                            "P) Player Info\n" +
                            "M) Monster Info\n" +
                            "X) Exit\n");

                        //Catch the user choice
                        ConsoleKey userChoice = Console.ReadKey(true).Key;
                        //Clear the console after the user chooses
                        Console.Clear();

                        switch (userChoice)
                        {
                            case ConsoleKey.A:
                                Console.WriteLine("Attack!");
                                //TODO - Handle attack functionality
                                break;

                            case ConsoleKey.R:
                                Console.WriteLine("Run Away!");
                                //TODO - Handle run away logic
                                break;

                            case ConsoleKey.P:
                                Console.WriteLine("Player Info");
                                //TODO - Handle showing player info
                                break;

                            case ConsoleKey.M:
                                Console.WriteLine("Monster Info");
                                //TODO - Handle showing monster info
                                break;

                            case ConsoleKey.X:
                            case ConsoleKey.E:
                                Console.WriteLine("No one likes a quitter!");
                                exit = true; //this will now get us to exit both inner & outer loops
                                             //TODO - Handle attack functionality
                                break;

                            default:
                                Console.WriteLine("Thou hast chosen an improper action. Triest thou again!");
                                break;

                        }//end switch
                        #endregion
                    } while (!exit && !reload); //end do while  - want both exit & reload to be true  
                } while (!exit); //end do while  -  while exit is false, we will stay in this loop

            //this will display the score for the user upon exiting the program.
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));
        }//end main

        //Create a GetRoom() and plug this into the appropriate ToDo above.
        private static string GetRoom()//put string instead of void bc we're returning a string with the room in it
        {
            //Create a collection of different rooms.
            string[] rooms =
            {
                "Fire crackles and pops in a small cooking fire set in the center of the room. The smoke from a burning rat on a spit curls up through a hole in the ceiling. Around the fire lie several fur blankets and a bag. It looks like someone camped here until not long ago, but then left in a hurry.", "You feel a sense of foreboding upon peering into this cavernous chamber. At its center lies a low heap of refuse, rubble, and bones atop which sit several huge broken eggshells. Judging by their shattered remains, the eggs were big enough to hold a crouching man, making you wonder how large -- and where -- the mother is.", "You enter a small room and your steps echo. Looking about, you're uncertain why, but then a wall vanishes and reveals an enormous chamber. The wall was an illusion and whoever cast it must be nearby!", "Huge rusted metal blades jut out of cracks in the walls, and rusting spikes project down from the ceiling almost to the floor. This room may have once been trapped heavily, but someone triggered them, apparently without getting killed. The traps were never reset and now seem rusted in place.", "This room is a tomb. Stone sarcophagi stand in five rows of three, each carved with the visage of a warrior lying in state. In their center, one sarcophagus stands taller than the rest. Held up by six squat pillars, its stone bears the carving of a beautiful woman who seems more asleep than dead. The carving of the warriors is skillful but seems perfunctory compared to the love a sculptor must have lavished upon the lifelike carving of the woman.", "Many doors fill the room ahead. Doors of varied shape, size, and design are set in every wall and even the ceiling and floor. Barely a hand's width lies between one door and the next. All the doors but the one you entered by are shut, and many have obvious locks.", "This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.", "The burble of water reaches your ears after you open the door to this room. You see the source of the noise in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat spewing clear water into its basin."
            }; //end string rooms

            //Generate a random object.
            Random rand = new Random();
            //Generate a random index number using Next()
            int indexNbr = rand.Next(rooms.Length);
            //Create a string for the single room that will be returned
            string room = rooms[indexNbr];
            //Return the room
            return room;

        }//end GetRoom()
    }//end class
}//end namespace
