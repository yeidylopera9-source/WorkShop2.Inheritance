using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public Triangle(int name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public double C 
        { 
            get => _c; 
            set => _c = ValidateC(value);
        }
        public double H 
        {
            get => _h; 
            set => _h = ValidateH(value); 
        }

        public override double GetArea() => (B * H) / 2;

        public override double GetPerimiter() => A + B + C;

        private double ValidateC(double c)
        {
            if (c < 60.00)
            {
                throw new ArgumentOutOfRangeException(nameof(c), "Is invalid. ");
            }
            return c;
        }

        private double ValidateH(double h)
        {
            if (h < 60.00)
            {
                throw new ArgumentOutOfRangeException(nameof(h), "Is invalid. ");
            }
            return h;
        }
    }
}
