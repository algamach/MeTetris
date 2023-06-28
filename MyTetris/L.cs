namespace MyTetris
{
    internal class L : Figure
    {
        public L(int x, int y)
        {
            x--;
            y--;
            x *= 2;
            x += 19;

            Blocks[0] = new Block(x, y);
            Blocks[1] = new Block(x, y + 1);
            Blocks[2] = new Block(x - 2, y + 1);
            Blocks[3] = new Block(x - 4, y + 1);
            Color = Color.DARK_YELLOW;
        }
    }
}
