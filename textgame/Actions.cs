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

        public static void Move(Direction direction, Player player, Map map)
        {
            if (direction == Direction.Invalid)
            {
                //shouldn't happen
                Methods.Debug("Move was passed an invalid direction.");
            }
            else if (player.playerSpace.IsPassableExitDirection(direction))
            {
                //move the player
                player.playerSpace = map.spaceInDirection(player.playerSpace, direction);
                //look around
                Actions.Look(player.playerSpace);
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

        public static void LookDirection(Map map, Space currentSpace, Direction direction)
        {
            Console.WriteLine(string.Format("You look {0}.", direction.ToString()));
            Console.WriteLine(map.spaceInDirection(currentSpace, direction).description);
        }
    }
}
