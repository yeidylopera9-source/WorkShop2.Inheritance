using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {

        private double _r;

        public Circle(int name, double r) : base(name)
        {
            R = r;
        }

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }


        public override double GetArea() => Math.PI * Math.Pow(R, 2);

        public override double GetPerimiter() => 2 * Math.PI * R;

        private double ValidateR(double r)
        {
            if (r < 6)
            {
                throw new ArgumentOutOfRangeException(nameof(r), "Is invalid ");
            }
            return r;
        }
    }
}
