using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textgame
{
    public class Inventory
    {
        int size;
        List<Item> contents;
        public Inventory(int _size)
        {
            size = _size;
        }
    }
}
