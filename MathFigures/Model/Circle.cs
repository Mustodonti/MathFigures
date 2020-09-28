using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MathFigures.Interface;

namespace MathFigures.Model
{
    public class Circle: IPolygonProperty
    {
        public string Title { get; private set; }
        public double Radius { get; private set; }
        public byte SidesCount { get; private set; }
        public List<double> SidesLength { get; private set; }
        string data;
        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                this.Radius = Convert.ToDouble(data);
                this.Area = GetArea();
                this.Perimetr = GetPerimetr();
                new OnPropertyChanged("Data");
            }
        }
        double perimetr;
        public double Perimetr
        {
            get { return perimetr; }
            set
            {
                perimetr = value;
                new OnPropertyChanged("Perimetr");
            }
        }
        double area;
        public double Area
        {
            get { return area; }
            set
            {
                area = value;
                new OnPropertyChanged("Area");
            }
        }

        public Circle(string title, string data)
        {
            Title = title;
            Data = data;
            //Radius =Convert.ToDouble(data);
            //Area = GetArea();
            //Perimetr = GetPerimetr();
        }

        public double GetArea()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
        public double GetPerimetr()
        {
            return 2*Math.PI*Radius;
        }
    }
}
