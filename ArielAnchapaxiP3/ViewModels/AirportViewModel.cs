
using ArielAnchapaxiP3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.ViewModels
{
    public class AirportViewModel : INotifyPropertyChanged
    {
        public AirportModel _airport;
        public ObservableCollection<AirportModel> _airports ;

        public AirportModel airport
        {
            get => _airport;
            set
            {
                if (_airport != value)
                {
                    _airport = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<AirportModel> list
        {
            get => _list;
            set
            {
                if (_list != value)
                {
                    _list = value;
                    OnPropertyChanged();
                }
            }
        }

        public AirportViewModel()
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
