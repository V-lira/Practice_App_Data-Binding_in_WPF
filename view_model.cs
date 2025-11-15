using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Input;

namespace WpfApp3
{
    internal class view_model : INotifyPropertyChanged
    {
        private double _width;
        private double _height;
        private ColorItem _selectedColor;
        public event PropertyChangedEventHandler PropertyChanged;

        //for rectangle:
        public double Width
        {
            get => _width;
            set
            {
                if (_width != value)
                {
                    _width = value;
                    changed();
                    changed(nameof(Area));
                }
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = value;
                    changed();
                    changed(nameof(Area));
                }
            }
        }

        //for get rectangle:
        public double Area => Width * Height;

        //change(choose) color:
        public ObservableCollection<ColorItem> AvailableColors { get; } = new ObservableCollection<ColorItem>();
        public ColorItem SelectedColor
        {
            get => _selectedColor;
            set
            {
                if (_selectedColor != value)
                {
                    _selectedColor = value;
                    changed();
                }
            }
        }
        public view_model()
        {
            COLORS();
            //basic:
            SelectedColor = AvailableColors[0];
        }

        private void COLORS()
        {
            AvailableColors.Add(new ColorItem("red", Brushes.Red));
            AvailableColors.Add(new ColorItem("green", Brushes.Green));
            AvailableColors.Add(new ColorItem("blue", Brushes.Blue));
            AvailableColors.Add(new ColorItem("yellow", Brushes.Yellow));
            AvailableColors.Add(new ColorItem("purple", Brushes.Purple));
        }
        protected virtual void changed([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    //model about color (saving it)
    public class ColorItem
    {
        public string Name { get; set; }
        public Brush Brush { get; set; }
        public ColorItem(string name, Brush brush)
        {
            Name = name;
            Brush = brush;
        }
    }

}
