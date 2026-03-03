using System.Security.Cryptography.X509Certificates;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        protected GeometricFigure(int name)
        {
            Name = name;
        }

        public int Name { get; } 
        
        public override string ToString() => $"{Name}\t" + $"Area........: {GetArea(),20:C2}\t" + $"Perimiter: {GetPerimiter(),20:C2}";
        
        public abstract double GetArea();
        public abstract double GetPerimiter();
    }
}
