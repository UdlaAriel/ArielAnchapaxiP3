using ArielAnchapaxiP3.Repositories;

namespace ArielAnchapaxiP3
{
    public partial class App : Application
    {
        public static AirportRepository _airportRepository { get; private set; }
        public static APIRepository _apiRepository { get; private set; }

        public App(AirportRepository AirportRepository, APIRepository APIRepository)
        {
            InitializeComponent();
            _airportRepository = AirportRepository;
            _apiRepository = APIRepository;
            MainPage = new AppShell();
        }
    }
}
