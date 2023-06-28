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
        public static Figure GetRandomFigure(int x, int y)
        {
            Random random = new Random();
            int randomInt = random.Next(0, 7);
            switch (randomInt)
            {
                case 0:
                    return new Square(x, y);
                    break;
                case 1:
                    return new T(x, y);
                    break;
                case 2:
                    return new Z(x, y);
                    break;
                case 3:
                    return new S(x, y);
                    break;
                case 4:
                    return new L(x, y);
                    break;
                case 5:
                    return new J(x, y);
                    break;
                case 6:
                    return new Stick(x, y);
                    break;
                default:
                    return new Z(x, y);
                    break;
            }
        }
        public void MoveFromNextToCurrent()
        {
            foreach (var block in Blocks)
            {
                block.X -= 22;
                block.Y -= 4;

            }
        }
    }
}
