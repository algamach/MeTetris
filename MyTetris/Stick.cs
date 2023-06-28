using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    internal class Stick : Figure
    {
        public Stick(int x, int y)
        {
            x--;
            y--;
            x *= 2;
            x += 19;
            
            Blocks[0] = new Block(x, y);
            Blocks[1] = new Block(x, y + 1);
            Blocks[2] = new Block(x, y + 2);
            Blocks[3] = new Block(x, y + 3);
            Color = Color.CYAN;
        }
    }
}
