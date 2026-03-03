using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b;

        public Kite(int name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }

        public double B 
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public override double GetArea() => (D1 * D2) / 2;

        public override double GetPerimiter() => 2 * (A + B);

        private double ValidateB(double b)
        {
            if (b < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Is invalid. ");
            }
            return b;
        }
    }
}
