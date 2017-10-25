using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public enum Direction { North, South, East, West, Up, Down, Invalid};
    public class Space
    {
        public List<Exit> exits;
        public bool isLit;
        public Inventory inv;
        public string description;
        public int xPos;
        public int yPos;
        public int zPos;

        public Space(int _xPos, int _yPos, int _zPos)
        {
            xPos = _xPos;
            yPos = _yPos;
            zPos = _zPos;

            exits = new List<Exit>();
            description = "You find yourself in a space.";
        }

        public class Exit
        {
            bool visible;
            bool passable;
            string message;
            public Direction direction;

            public Exit(Direction _direction)
            {
                direction = _direction;
                message = "You go " + direction.ToString();
                visible = true;
                passable = true;
            }
        }

        public void DisplayExits()
        {
            Console.Write("Exits: ");
            int exitsWritten = 0;
            foreach(Exit e in exits)
            {
                Console.Write(e.direction.ToString());
                exitsWritten++;
                if(exitsWritten < exits.Count())
                {
                    Console.Write(", ");
                }
            }
        }

        public bool IsPassableExitDirection(Direction direction)
        {
            foreach(Exit e in exits)
            {
                if (e.direction == direction)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
