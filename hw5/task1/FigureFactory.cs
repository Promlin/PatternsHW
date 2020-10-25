using System;
using System.Collections.Generic;


namespace hw5.task1
{
    public class FigureFactory 
    {
        static Dictionary<string, IDrawFigure> figures = new Dictionary<string, IDrawFigure>();

        public static IDrawFigure GetFigures(string figureType)
        {
            switch (figureType)
            {
                case "Окружность":
                    if (!figures.ContainsKey("Окружность"))
                        figures["Окружность"] = new DrawCircle();
                    return figures["Окружность"];
                case "Квадрат":
                    if (!figures.ContainsKey("Квадрат"))
                        figures["Квадрат"] = new DrawSquare();
                    return figures["Квадрат"];
                default: break;
            }
            return null;
        }
    }
}
