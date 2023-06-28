using MyTetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Field.Inint();
        Field.Test();
        Console.ReadKey();
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

        Console.ReadKey();

    }
}