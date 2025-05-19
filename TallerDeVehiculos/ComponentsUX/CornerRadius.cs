using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ComponentsUX
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CornerRadius : INotifyPropertyChanged
    {
        private int _all = 1;
        private int _topLeft = 1;
        private int _topRight = 1;
        private int _bottomLeft = 1;
        private int _bottomRight = 1;

        public event PropertyChangedEventHandler PropertyChanged;

        public int All
        {
            get => _all;
            set
            {
                if (_all != value)
                {
                    _all = value;
                    TopLeft = TopRight = BottomLeft = BottomRight = value;
                    OnPropertyChanged(nameof(All));
                    OnPropertyChanged(nameof(TopLeft));
                    OnPropertyChanged(nameof(TopRight));
                    OnPropertyChanged(nameof(BottomLeft));
                    OnPropertyChanged(nameof(BottomRight));
                }
            }
        }

        public int TopLeft
        {
            get => _topLeft;
            set { if (_topLeft != value) { _topLeft = value; OnPropertyChanged(nameof(TopLeft)); } }
        }

        public int TopRight
        {
            get => _topRight;
            set { if (_topRight != value) { _topRight = value; OnPropertyChanged(nameof(TopRight)); } }
        }

        public int BottomLeft
        {
            get => _bottomLeft;
            set { if (_bottomLeft != value) { _bottomLeft = value; OnPropertyChanged(nameof(BottomLeft)); } }
        }

        public int BottomRight
        {
            get => _bottomRight;
            set { if (_bottomRight != value) { _bottomRight = value; OnPropertyChanged(nameof(BottomRight)); } }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return $"{TopLeft};{TopRight};{BottomLeft};{BottomRight}";
        }
    }

}
