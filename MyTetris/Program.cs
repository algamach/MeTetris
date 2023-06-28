using MyTetris;

internal class Program
{
    private static void Main(string[] args)
    {
        Field.Inint();
        //Field.Test2();
        GeneratingTest();
    }
    static void GeneratingTest()
    {
        Figure currenFigure = Figure.GetRandomFigure(Field.Width / 2, 1);

        while (true)
        {
            Figure nextFigure = Figure.GetRandomFigure(16, 5);
            nextFigure.Draw();
            currenFigure.Draw();
            Console.ReadKey();
            currenFigure.Hide();
            nextFigure.FullyHide();
            currenFigure = nextFigure;
            currenFigure.MoveFromNextToCurrent();
            nextFigure = Figure.GetRandomFigure(16, 5);
        }
    }
}