using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Map
    {
        Space[,,] spaces;
        public Map(int size_x, int size_y, int size_z)
        {
            spaces = new Space[size_x, size_y, size_z];
        }
    }


}
