using System;


namespace hw3
{
    class Circle : IFigure
    {
        private float radius;
        private float side1;
        private float side2;

        public Circle(float radius, float side1, float side2)
        {
            this.radius = radius;
            this.side1 = 0f;
            this.side2 = 0f;
        }


        public string Name => "Круг";

        public float Radius => this.radius;

        public float Side1 => this.side1;

        public float Side2 => this.side2;

        public void PrintToConsole()
        {
            Console.WriteLine($"Фигура - {Name}, с радиусом: {this.radius}");
        }
    }
}
