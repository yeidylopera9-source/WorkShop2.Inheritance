using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public Parallelogram(int name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public override double GetArea() => B * H;

        public override double GetPerimiter() => 2 * (A + B);

        private double ValidateH(double h)
        {
            if (h < 70.000)
            {
                throw new ArgumentOutOfRangeException(nameof(h), "Is invalid. ");
            }
            return h;

        }
    }
}