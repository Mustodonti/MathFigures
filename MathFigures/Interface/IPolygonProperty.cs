using System;
using System.Collections.Generic;
using System.Text;

namespace MathFigures.Interface
{

    public interface IPolygonProperty
    {
        public string Data { get; }
        public double Area { get; }
        public double Perimetr{ get; }
        public string Title { get; }
        public byte SidesCount { get; }
        public List<double> SidesLength { get; }
        public double Radius { get; }

        public double GetArea();
        public double GetPerimetr();
    }
}
