using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Program
    {
        public static int getInput(List<String> options)
        {
            Console.WriteLine(options[0]);
            int length = options.Count;
            for (int i = 1; i < length; i++)
            {
                Console.WriteLine(i + ") : " + options[i]);
            }
            Console.WriteLine("-1) : Back");
            Console.WriteLine("-2) : Credits");
            Console.WriteLine("0) : Quit Game");
            
            return int.Parse(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            List<List<String>> dTree = new List<List<String>>();
            /* 0 */
            dTree.Add(new List<String>(new String[] { "Welcome to the Game", "Go to the forest" }));
            /* 1 */
            dTree.Add(new List<String>(new String[] { "Welcome to the Forest", "Walk straight to go the Beach", "To stay in the forest do not follow and paths, explore the land, 'Coming Soon'" }));
            /* 2 */
            dTree.Add(new List<String>(new String[] { "Welcome to the Beach", "Take the left path to go back to the Forest, Please press '-1' to go back", "Take the straight path to stay in the Beach, 'Coming Soon'", "Take the right path to go the Desert, Please press '1' to go to the next level"}));
            /* 3 */
            dTree.Add(new List<String>(new String[] { "Welcome to the Desert", "Take the left path to go back to the Beach, Please press '-1' to go back", "Take the straight path to stay in the Desert, 'Coming Soon'", "Take the right path to go the Wetland, Please press '1' to go to the next level" }));
            /* 4 */
            dTree.Add(new List<String>(new String[] { "Welcome to the Wetland", "Take the left path to go back to the Desert, Please press '-1' to go back", "Take the straight path to stay in the Wetland, 'Coming Soon'", "Take the right path till you find a door and walk through the door and find your destiny, Please press '1' to go to the next level" }));


            int index = 0;
            int prev_index = 0;
            int temp = 0;
            while (true)
            {
                int option = getInput(dTree[index]);

                if (option == 0)
                {
                    break;
                }
                else
                {
                    if (option == -1)
                    {
                        temp = index;
                        index = prev_index;
                        prev_index = temp;
                    }
                    else if (option == -2)
                    {
                        Console.WriteLine("Thank you for playing the game");
                        Console.WriteLine("Creators: Hendrik & Jashil"+ "\n" + "Story by: Jashil" + "\n " + "KEEP YOUR EYES AND EARS OPEN FOR PART 2 OF 'THE GAME', NOT ADVISABLE FOR PLAYERS UNDER THE AGE OF 6");
                    }
                    else
                    {
                        prev_index = index;
                        index += option;
                    }
                }
            }
        }
    }
}
