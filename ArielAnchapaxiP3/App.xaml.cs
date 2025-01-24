using ArielAnchapaxiP3.Repositories;

namespace ArielAnchapaxiP3
{
    public partial class App : Application
    {
        public static AirportRepository repository { get; private set; }

        public App(AirportRepository _repository)
        {
            InitializeComponent();
            _repository = repository;
            MainPage = new AppShell();
        }
    }
}
