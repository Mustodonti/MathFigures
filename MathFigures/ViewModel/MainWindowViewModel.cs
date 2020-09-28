using MathFigures.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MathFigures.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged 
    {
        Figure selectedfigure;      
        public ObservableCollection<Figure> Figures { get; private set; }
        public Figure SelectedFigures
        {
            get { return selectedfigure; }
            set
            {
                selectedfigure = value;
                OnPropertyChanged("SelectedFigures");
            }
        }

        public MainWindowViewModel()
        {  
            Figures = new ObservableCollection<Figure>(Figure.GetFigure("3;3;3;"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
