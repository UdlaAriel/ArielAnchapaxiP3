
using ArielAnchapaxiP3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.ViewModels
{
    public class AirportViewModel : INotifyPropertyChanged
    {
        public AirportModel _airport;
        public IEnumerable<AirportModel> _airports;

        public AirportModel airport
        {
            get
            {
                return _airport;
            }
            set
            {
                if (_airport != value)
                {
                    _airport = value;
                    PropertyChanged(nameof(airport));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
