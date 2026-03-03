using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        private double _b;
        public Rectangle(int name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public double B 
        {
            get => _b; 
            set => _b = value;
        }

        public override double GetArea() => A * B;

        public override double GetPerimiter() => 2 * (A + B);

        private double ValidateB(double b)
        {
            if (b < 70000)
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Is invalid. ");
            }
            return b;
        }
    }
}
