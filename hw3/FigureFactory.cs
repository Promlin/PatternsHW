using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class FigureFactory
    {
        public static IFigure GetFigure(string type,
            float radius,
            float side1,
            float side2)
        {
            switch (type)
            {
                case "Круг": return new Circle(radius, 0f, 0f);
                case "Квадрат": return new Square(0f, side1, side1);
                case "Прямоугольник": return new Rectangle(0f, side1, side2);
                default: return null;
            } 
        }
    }
}
