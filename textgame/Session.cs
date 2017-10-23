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
            player = new Player(enteredName);
            map = new Map(3, 3, 3);
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
                    Console.WriteLine("Move where?");
                    return;
                }

                Actions.Move(words[1], player, map);
                return;
            }

            if (player.GetPlayerSpace(map).IsValidExitDirection(Methods.GetDirection(words[0])));

            if (lookCommands.Contains(words[0]))
            {
                if (words.Length == 1)
                {
                    Actions.Look(player.GetPlayerSpace(map));
                    return;
                }
                else if (words.Length == 2)
                {
                    if (player.GetPlayerSpace(map).IsValidExitDirection(Methods.GetDirection(words[1])))
                    {
                        Actions.LookDirection(words[1]);
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
        }
    }
}
