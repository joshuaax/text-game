using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Player
    {
        public string name;
        public int defaultInventorySize = 20;
        public int xLocation;
        public int yLocation;
        public int zLocation;

        public Player(string _name)
        {
            name = _name;
            Inventory inv = new Inventory(defaultInventorySize);
            xLocation = 0;
            yLocation = 0;
            zLocation = 0;
        }

        public Space GetPlayerSpace(Map map)
        {
            return map.spaces[xLocation, yLocation, zLocation];
        }
    }
}
