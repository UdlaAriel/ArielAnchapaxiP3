
using ArielAnchapaxiP3.Models;
using ArielAnchapaxiP3.Repositories;
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
        //private readonly AirportRepository _repository;
        private AirportModel _airport;
        public Command GetAirportCommand;
        public Command SaveAirportInSQLiteCommand;

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


        public AirportViewModel()
        {
            GetAirportCommand = new Command(GetAirport);
            SaveAirportInSQLiteCommand = new Command(SaveInSQLite);
        }

        public void GetAirport()
        {
            
        }

        public void GetAllAirports()
        {

        }

        public void SaveInSQLite()
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
