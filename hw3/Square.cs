using System;


namespace hw3
{
    class Square  :IFigure
    {
        private float radius;
        private float side1;
        private float side2;

        public Square(float radius, float side1, float side2)
        {
            this.radius = 0f;
            this.side1 = side1;
            this.side2 = side1;
        }


        public string Name => "Квадрат";

        public float Radius => this.radius;

        public float Side1 => this.side1;

        public float Side2 => this.side2;

        public void PrintToConsole()
        {
            Console.WriteLine($"Фигура - {Name}, со стороной: {this.side1}");
        }
    }
}
