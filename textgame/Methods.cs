using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public static class Methods
    {
        public static bool? YesOrNo(string input)
        {
            if (string.Equals(input, "yes") || string.Equals(input, "y"))
            {
                return true;
            }
            else if (string.Equals(input, "no") || string.Equals(input, "n"))
            {
                return false;
            }
            else
            {
                return null;
            }
        }

        public static Direction GetDirection(string input)
        {
            if (string.Equals(input, "north") || string.Equals(input, "n"))
            {
                return Direction.North;
            }
            else if (string.Equals(input, "south") || string.Equals(input, "s"))
            {
                return Direction.South;
            }
            else if (string.Equals(input, "east") || string.Equals(input, "e"))
            {
                return Direction.East;
            }
            else if (string.Equals(input, "west") || string.Equals(input, "w"))
            {
                return Direction.West;
            }
            else if (string.Equals(input, "up") || string.Equals(input, "u"))
            {
                return Direction.Up;
            }
            else if (string.Equals(input, "down") || string.Equals(input, "d"))
            {
                return Direction.Down;
            }
            else
            {
                return Direction.Invalid;
            }
        }

        public static string GetNewName()
        {
            string enteredName;
            string input;

            while (true)
            {
                Console.WriteLine("Enter character name:");
                enteredName = Console.ReadLine();
                Console.WriteLine(string.Format("You have entered: \n{0}\nIs this correct?", enteredName));
                input = Console.ReadLine();
                if (Methods.YesOrNo(input) == null)
                {
                    Console.WriteLine("C'mon. Please enter yes or no, y or n.");
                    Console.ReadLine();
                }
                else if (Methods.YesOrNo(input) == true)
                {
                    return enteredName;
                }
            }
        }
        
        /*
        public static void Initialize(Map map)
        {
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();

            //Initialize the Map
            map = new Map(3, 3, 3);

            //Create a new Player
            while (true)
            {
                Console.WriteLine("Enter character name:");
                string enteredName = Console.ReadLine();
                Console.WriteLine(string.Format("You have entered: \n{0}\nIs this correct?"));
                string input = Console.ReadLine();
                if (Methods.YesOrNo(input) == null)
                {
                    Console.WriteLine("C'mon. Please enter yes or no, y or n.");
                    Console.ReadLine();
                }
                else
                {
                    if (Methods.YesOrNo(input) ?? true)
                    {
                        Player player = new Player(enteredName);
                        break;
                    }
                }
            }
        }
        */

        public static void Debug(string message)
        {
            if (Program.debug)
            {
                Console.WriteLine("Info: " + message);
            }
        }
    }
}
