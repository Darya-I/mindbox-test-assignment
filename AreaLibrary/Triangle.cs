using System;

namespace AreaLibrary
{
    public class Triangle : IFigure
    {
        
        private double a, b, c;
        private double sideA, sideB;
        private double hypotenuse;
        

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            FindSides();
        }

        // реализуем метод интерфейса
        public double CalculateArea()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                {
                return 0;
            }

            // проверим какой у нас треугольник и выполним соотствествующий метод
            if (IsRightTriangle())
            {
                return CalculateRightTriangleArea();
            }
            else
            {
                return CalculateHeronArea();
            }

        }

        public bool IsRightTriangle()
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
        }

        private void FindSides()
        {
            hypotenuse = Math.Max(Math.Max(a, b), c);
            
            if (hypotenuse == a)
            {
                sideA = b;
                sideB = c;

            }
            else if (hypotenuse == b)
            {
                sideA = c;
                sideB = a;
            }
            else
            {
                sideA = a;
                sideB = b;
            }

        }

        private double CalculateRightTriangleArea()
        {
            double S = 0.5 * sideA * sideB;
            return Math.Round(S, 3);
        }

        private double CalculateHeronArea()
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p  - a) * (p - b) * (p - c));
            return Math.Round(S, 3);
        }


    }
}
