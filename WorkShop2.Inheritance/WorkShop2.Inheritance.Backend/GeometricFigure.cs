using System.Security.Cryptography.X509Certificates;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public GeometricFigure(string name)
        {
            Name = name;
        }

        public string Name { get; } 
        
        public override string ToString() => $"{Name, - 8}" + $"\t => Area........: {GetArea(),12:C5}\t" + $"\tPerimiter: {GetPerimiter(),12:C5}";
        
        public abstract double GetArea();
        public abstract double GetPerimiter();
    }
}
