using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

        public Trapeze(int name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            D = d;
        }

        public double D
        {
            get => _d;
            set => _d = value;
        }


        public override double GetArea() => (B + D) * H / 2;

        public override double GetPerimiter() => A + B + C + D;

        private double ValidateD(double d)
        {
            if (d < 70.000)
            {
                throw new ArgumentOutOfRangeException(nameof(d), "Is invalid. ");
            }
            return d;
        }
    }
}
