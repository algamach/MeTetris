using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    internal abstract class Figure
    {
        public const int LENGTH = 4;
        public Block[] Blocks = new Block[LENGTH];
        public Color Color;

        public void Draw()
        {
            foreach (var block in Blocks)
            {
                block.Draw(Color);
            }
        }
        public void Hide()
        {
            foreach (var block in Blocks)
            {
                block.Hide();
            }
        }
        public void FullyHide()
        {
            foreach (var block in Blocks)
            {
                block.FullyHide();
            }
        }
    }
}
