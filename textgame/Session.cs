using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Session
    {
        public Map map;
        public Player player;

        public Session()
        {
            //Create a new Player
            string enteredName = Methods.GetNewName();
            map = new Map(3, 3, 3);
            player = new Player(enteredName, map);
        }

        List<string> moveCommands = new List<string>{
            "walk",
            "go"
        };
        List<string> lookCommands = new List<string>{
            "look",
            "l"
        };

        public void ProcessInput(string input)
        {
            string[] words = input.Split(' ');

            if (moveCommands.Contains(words[0]))
            {
                if (words.Length == 1)
                {
                    Console.WriteLine("Walk where?");
                    return;
                }

                Actions.Move(Methods.GetDirection(words[0]), player, map);
                return;
            }

            Direction direction = Methods.GetDirection(words[0]);
            //if the user entered a valid direction
            if(direction != Direction.Invalid)
            {
                //if there were multiple words entered
                if (words.Length > 1)
                {
                    Console.WriteLine("Enter a direction by itself to go that way.");
                }
                else
                {
                    Actions.Move(direction, player, map);
                }
            }

            if (lookCommands.Contains(words[0]))
            {
                if (words.Length == 1)
                {
                    Actions.Look(player.playerSpace);
                    return;
                }
                else if (words.Length == 2)
                {
                    if (player.playerSpace.IsPassableExitDirection(Methods.GetDirection(words[1])))
                    {
                        Actions.LookDirection(map, player.playerSpace, Methods.GetDirection(words[1]));
                    }
                    else if(Methods.GetDirection(words[1]) != Direction.Invalid)
                    {
                        Console.WriteLine(string.Format("You can't go {0}, so you can't look that way either.", Methods.GetDirection(words[1])));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("{0} is not a valid direction.", words[1]));
                    }
                }
                else
                {
                    Console.WriteLine("Too many words.");
                }
            }

            /*
            switch (inputList[0])
            {
                case commandMove:
                    if (inputList.Length == 1)
                    {
                        Console.WriteLine("Move where?");
                        break;
                    }

                    Actions.Move(inputList[1], player, map);
                    break;
                case commandLook:
                    break;
                default:
                    Console.WriteLine("Unrecognized input.");
                    break;
            }
            */
        }
    }
}
