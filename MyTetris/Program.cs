using MyTetris;
using System.Timers;

internal class Program
{
    static private Object _lockObject = new Object();
    static private int _timerInterval = 500;
    static System.Timers.Timer timer;
    public int TimeInterval
    {
        get
        {
            return _timerInterval;
        }
        set
        {
            _timerInterval = value;
        }
    }

    static Figure currentFigure;
    static Figure nextFigure;
    private static void Main(string[] args)
    {
        Field.Inint(ref currentFigure, ref nextFigure);

        SetTimer();

        while (true)
        {
            while (currentFigure.Life)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    Monitor.Enter(_lockObject);
                    MoveByButton(cki, currentFigure);
                    Monitor.Exit(_lockObject);
                }
            }
            GetNextFigure();
        }
    }
    private static void MoveByButton(ConsoleKeyInfo cki, Figure figure)
    {
        switch (cki.Key)
        {
            case ConsoleKey.Spacebar:
                figure.Rotate(); break;
            case ConsoleKey.UpArrow:
                figure.Move(Direction.UP); break;
            case ConsoleKey.DownArrow:
                figure.Move(Direction.DOWN); break;
            case ConsoleKey.RightArrow:
                figure.Move(Direction.RIGHT); break;
            case ConsoleKey.LeftArrow:
                figure.Move(Direction.LEFT); break;
        }
    }
    private static void GetNextFigure()
    {
        Monitor.Enter(_lockObject);
        nextFigure.FullyHide();
        currentFigure = nextFigure;
        currentFigure.MoveFromNextToCurrent();
        nextFigure = Figure.GetRandomFigure(16, 5);
        currentFigure.Draw();
        nextFigure.Draw();
        Monitor.Exit(_lockObject);
    }
    private static void SetTimer()
    {
        timer = new System.Timers.Timer(_timerInterval);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }
    private static void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
        Monitor.Enter(_lockObject);
        currentFigure.Move(Direction.DOWN);
        Monitor.Exit(_lockObject);
    }
}