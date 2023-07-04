using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    internal class Score
    {
        private static int _count = 0;
        private static int _lines = 0;
        private static bool _game = true;
        public static int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public static int Lines
        {
            get
            {
                return _lines;
            }
            set
            {
                _lines = value;
            }
        }
        public static bool Game
        {
            get
            {
                return _game;
            }
            set
            {
                _game = value;
            }
        }

        internal static void UpdateScore(int lines)
        {
            switch (lines)
            {
                case 1:
                    Count += 10;
                    Lines += 1;
                    break;
                case 2:
                    Count += 25;
                    Lines += 2;
                    break;
                case 3:
                    Count += 50;
                    Lines += 3;
                    break;
                case 4:
                    Count += 100;
                    Lines += 4;
                    break;
            }
            Field.WriteScore();
        }
    }
}
