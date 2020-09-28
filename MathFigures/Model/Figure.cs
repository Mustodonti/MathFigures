using MathFigures.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MathFigures.Model
{
    public class Figure
    {
        public IPolygonProperty Primer { get; set; }
        
        public static ObservableCollection<Figure> GetFigure(string number)
        {
            var result = new ObservableCollection<Figure>
            {
                new Figure(){Primer = new Triangle("Triangle",3,number)},
                new Figure(){Primer = new Circle("Circle","5")}
            };
            return result;
        }
    }
}
