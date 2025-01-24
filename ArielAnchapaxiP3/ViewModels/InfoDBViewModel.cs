using ArielAnchapaxiP3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ArielAnchapaxiP3.ViewModels
{
    public class InfoDBViewModel : INotifyPropertyChanged
    {
        //private readonly AirportRepository _repository;
        private ObservableCollection<AirportModel> _airports = new ObservableCollection<AirportModel>();
        public ICommand GetAirportListCommand { get; set; }

        public ObservableCollection<AirportModel> airports
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
        }

        public void GetAllAirports()
        {
            App._airportRepository.GetAllAirports();
            OnPropertyChanged(nameof(airports));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}