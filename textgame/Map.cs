using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Map
    {
        public Space[,,] spaces;

        public Map(int size_x, int size_y, int size_z)
        {
            spaces = new Space[size_x, size_y, size_z];
            for(int x = 0; x < size_x; x++)
            {
                for (int y = 0; y < size_y; y++)
                {
                    for (int z = 0; z < size_z; z++)
                    {
                        spaces[x, y, z] = new Space(x, y, z);

                        if (x != 0)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.West));
                        }
                        if (x != size_x - 1)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.East));
                        }
                        if (y != 0)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.South));
                        }
                        if (y != size_y - 1)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.North));
                        }
                        if (z != 0)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.Down));
                        }
                        if (z != size_z - 1)
                        {
                            spaces[x, y, z].exits.Add(new Space.Exit(Direction.Up));
                        }
                    }
                }
            }
        }

        public Space spaceInDirection(Space currentSpace)
        {

        }
    }
}
