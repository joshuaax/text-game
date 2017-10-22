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

        public Space()
        {
            exits = new List<Exit>();
        }

        public class Exit
        {
            bool visible;
            bool passable;
            string message;
        }

    }
}
