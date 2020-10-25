using System;



namespace hw5
{
    class CalculatingClass : ICalculating
    {

        public float Dividing(float a, float b) //деление
        {
            return a / b;
        }

        public float Multiply(float a, float b)  //умножение
        {
            return a * b;
        }

        public float Substraction(float a, float b) //вычитание
        {
            return a - b;
        }

        public float Sum(float a, float b)  //сложение
        {
            return a + b;
        }
    }
}
