using System;


namespace hw5.task1
{
    public class DrawCircle : IDrawFigure
    {
        public static int ObjectCounter = 0;

        public void DrawFigure(int value)
        {
            Console.WriteLine($"Окружность радиусом {value}");
            ObjectCounter++;
        }
    }
}
