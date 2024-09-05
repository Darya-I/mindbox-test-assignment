using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Circle : IFigure
    {
        private double radius;
     
        public Circle(double radius)
        {
            
            this.radius = radius;
        }

        public double CalculateArea()
        {
            if (radius <= 0)
            {
                return 0;
            }

            double S = Math.PI * Math.Pow(radius, 2);
            return Math.Round(S, 3);
        }
        
    }
}
