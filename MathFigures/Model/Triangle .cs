using MathFigures.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MathFigures.Model
{
    public class Triangle : IPolygonProperty
    {
        public string Title { get; private set; }
        public byte SidesCount { get; private set; }
        public List<double> SidesLength { get; private set; }
        public double Radius { get; private set; }


        public double perimetr;
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
        string data;
        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                List<string> lst_str = Data.Split(new char[] { ';' }).ToList();
                List<double> lst = new List<double>();
                for (int i = 0; i < lst_str.Count() - 1; i++)
                {
                    lst.Add(Convert.ToDouble(lst_str[i]));
                }
                SidesLength = lst;
                Area = GetArea();
                Perimetr = GetPerimetr();
                new OnPropertyChanged("Data");
            }
        }

        public Triangle(string title, byte sidesCount, string sidesLength)
        {
            Title = title;
            SidesCount = sidesCount;
            Data = sidesLength;
            
        }

        public double  GetArea()
        {
            double p = GetSemiPerimetr();
            return Math.Sqrt(p*(p-SidesLength[0])*(p-SidesLength[1])*(p- SidesLength[2]));
        }
        public double GetPerimetr()
        {
            return SidesLength.Sum();
        }

        double GetSemiPerimetr()
        {
            return SidesLength.Sum()/2;
        }
    }
}
