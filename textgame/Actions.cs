using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public static class Actions
    {
        //static string command;          //full player-entered command
        //static int minCommandChars;     //the minimum number of characters of the command string that may be entered

        public static void Move(string input, Player player, Map map)
        {
            Direction direction = Methods.GetDirection(input);
            if (direction == Direction.Invalid)
            {
                Console.WriteLine(input + " is not a valid direction.");
            }
            else if (player.GetPlayerSpace(map).IsValidExitDirection(direction))
            {
                if (direction == Direction.North) player.yLocation++;
                if (direction == Direction.South) player.yLocation--;
                if (direction == Direction.East)  player.xLocation++;
                if (direction == Direction.West)  player.xLocation--;
                if (direction == Direction.Up)    player.zLocation++;
                if (direction == Direction.Down)  player.zLocation--;
            }
            else
            {
                Console.WriteLine("You can't go that way.");
            }
        }

        public static void Look(Space s)
        {
            Console.WriteLine(s.description);
            s.DisplayExits();
        }

        public static void LookDirection(string direction)
        {
            Console.WriteLine("");
        }
    }
}
