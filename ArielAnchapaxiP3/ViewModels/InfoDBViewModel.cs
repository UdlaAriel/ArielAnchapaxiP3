using ArielAnchapaxiP3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.ViewModels
{
    public class InfoDBViewModel : INotifyPropertyChanged
    {
        //private readonly AirportRepository _repository;
        private AirportModel _airport;
        private ObservableCollection<AirportModel> _airports;
        public Command GetAirportCommand;
        public Command GetAirportListCommand;
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

        public ObservableCollection<AirportModel> list
        {
            get => _airports;
            set
            {
                if (_airports != value)
                {
                    _airports = value;
                    OnPropertyChanged();
                }
            }
        }

        public InfoDBViewModel()
        {
            GetAirportListCommand = new Command(GetAllAirports);
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