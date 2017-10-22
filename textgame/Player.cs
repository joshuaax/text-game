using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Player
    {
        string name;
        int defaultInventorySize = 20;
        int xLocation;
        int yLocation;
        int zLocation;



        public Player(string _name)
        {
            name = _name;
            Inventory inv = new Inventory(defaultInventorySize);
            xLocation = 0;
            yLocation = 0;
            zLocation = 0;
        }

        public Space GetPlayerSpace()
        {
            return;
        }
    }
}
