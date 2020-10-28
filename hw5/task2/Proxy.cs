using System;


namespace hw5
{
    class Proxy : ICalculating
    {
        CalculatingClass calculating;

        
        public float Dividing(float a, float b)
        {
            if(calculating == null)
            {
                Console.WriteLine($"Результат деление: {a/b}");
            }
            return a / b;
        }

        public float Multiply(float a, float b)
        {
            if (calculating == null)
            {
                Console.WriteLine($"Результат умножения: {a * b}");
            }
            return a * b;
        }

        public float Substraction(float a, float b)
        {
            if (calculating == null)
            {
                Console.WriteLine($"Результат вычитания: {a - b}");
            }
            return a - b;
        }

        public float Sum(float a, float b)
        {
            if (calculating == null)
            {
                Console.WriteLine($"Результат сложения: {a / b}");
            }
            return a + b;
        }
    }
}
