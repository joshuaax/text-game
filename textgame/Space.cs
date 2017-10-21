using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public enum Direction { North, South, East, West, Up, Down};
    public class Space
    {
        List<Exit> exits;
        bool isLit;
        Inventory inv;

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
