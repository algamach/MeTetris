using MyTetris;

namespace MyTetris
{
    internal class Block
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public Block(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void Draw(Color color)
        {
            Console.SetCursorPosition(X, Y);
            switch (color)
            {

                case Color.YELLOW:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Color.RED:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.GREEN:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.MAGENTA:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Color.BLUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.CYAN:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case Color.DARK_YELLOW:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }
            Console.Write("[]");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
        public void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" .");
            Console.SetCursorPosition(0, 0);
        }
        public void FullyHide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("  ");
            Console.SetCursorPosition(0, 0);
        }

        internal void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    Y--;
                    break;
                case Direction.DOWN:
                    Y++;
                    break;
                case Direction.LEFT:
                    X -= 2;
                    break;
                case Direction.RIGHT:
                    X += 2;
                    break;
            }
        }
        internal void MoveReverse(Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    Y++;
                    break;
                case Direction.DOWN:
                    Y--;
                    break;
                case Direction.LEFT:
                    X += 2;
                    break;
                case Direction.RIGHT:
                    X -= 2;
                    break;
            }
        }
        internal ValidationResult Validation()
        {
            if (X < 19 || X > 38 || Y < 0)
                return ValidationResult.BORDER;
            else if (Y>19)
                return ValidationResult.BLOCKS_OR_DOWN_BORDER;
            else   
                if (Field.IsBlockStrike(X,Y))
                    return ValidationResult.BLOCKS_OR_DOWN_BORDER;
            else
                return ValidationResult.SUCCESS;
        }
        public void AddBlockOnField(Color color)
        {
            Field.BlocksOnField[(X - 19) / 2, Y] = color;
        }
    }
}
