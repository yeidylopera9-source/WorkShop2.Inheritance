using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        public Square(int name, double a) : base(name)
        {
            A = a;
        }

        public double A
        { 
            get => _a;
            set => _a = ValidateA(value); 
        
        }

        public override double GetArea() => A * A;
        
        public override double GetPerimiter() => 4 * A;
      
        public double ValidateA(double a)
        {
            if (a < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(a), "Is invalid");
            }
            return a;
        }
    }
}
