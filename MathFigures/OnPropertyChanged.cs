using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MathFigures
{
    public class OnPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OnPropertyChanged(string propetyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
