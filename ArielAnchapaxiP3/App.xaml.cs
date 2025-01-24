using ArielAnchapaxiP3.Repositories;

namespace ArielAnchapaxiP3
{
    public partial class App : Application
    {
        public static AirportRepository _sqliteRepository { get; private set; }
        public static APIRepository _apiRepository { get; private set; }

        public App(AirportRepository SQLiteRepository, APIRepository APIRepository)
        {
            InitializeComponent();
            _sqliteRepository = SQLiteRepository;
            _apiRepository = APIRepository;
            MainPage = new AppShell();
        }
    }
}
