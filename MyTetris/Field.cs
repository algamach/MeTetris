using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    internal class Field
    {
        private const int _width = 10;
        private const int _height = 20;
        public static int Width { get { return _width; } }
        public static int Height { get { return _height; } }
        public static Color[,] BlocksOnField = new Color[10, 20];
        public static void Inint()
        {
            Console.SetWindowSize(60, 22);
            Console.SetBufferSize(60, 22);

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 20; j++)
                    BlocksOnField[i, j] = Color.GRAY;

            for (int i = 0; i < Height +1 ; i++)
            {
                Console.SetCursorPosition(17, i);
                Console.Write("<!");
                Console.SetCursorPosition(17 + 2 + Width*2, i);
                Console.Write("!>");
            }
            for (int i = 1; i <= Width*2; i++)
            {
                Console.SetCursorPosition(18 + i, Height);
                Console.Write("=");

                Console.SetCursorPosition(18 + i, Height+1);
                if (i % 2 == 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("\\");
                }
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(19, i);
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(" .");
                }
            }
            Console.SetCursorPosition(4, 2);
            Console.Write("Счет: ");

            Console.SetCursorPosition(42, 2);
            Console.Write("Следующая фигура:");

            Console.SetCursorPosition(0,0);
        }
        public static bool IsBlockStrike(int x, int y)
        {
            if (BlocksOnField[(x - 19) / 2, y] != Color.GRAY)
                return true;
            else return false;
        }
        public static void Test()
        {
            S test1 = new S(4, 19);
            test1.Draw();

            T test2 = new T(6, 19);
            test2.Draw();

            //счет
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("690");

            //след. фигура            
            Z test3 = new Z(16, 5);
            test3.Draw();

            Console.SetCursorPosition(0, 0);
        }
        public static void Test2()
        {
            Figure[] figArr = new Figure[7];
            figArr[0] = new S(2, 3);
            figArr[1] = new Z(1, 1);
            figArr[2] = new Square(9, 1);
            figArr[3] = new Stick(4, 4);
            figArr[4] = new T(3, 7);
            figArr[5] = new J(7, 3);
            figArr[6] = new L(10, 9);

            foreach (Figure i in figArr)
            {
                Thread.Sleep(1000);
                i.Draw();
            }
            foreach (Figure i in figArr)
            {
                Thread.Sleep(1000);
                i.Hide();
            }
        }
    }   
}
