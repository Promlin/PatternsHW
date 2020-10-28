using System;


namespace hw5.task1
{
    public class DrawSquare : IDrawFigure
    {
        public static int ObjectCounter = 0;

        public void DrawFigure(int value)
        {
            Console.WriteLine($"Квадрат со стороной {value}");
            ObjectCounter++;
        }
    }
}
