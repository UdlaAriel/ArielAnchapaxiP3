using ArielAnchapaxiP3.Repositories;
using Microsoft.Extensions.Logging;

namespace ArielAnchapaxiP3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
#if ANDROID
    string dbPath = Path.Combine(FileSystem.AppDataDirectory, "ariel_anchapaxi.db3");
#elif IOS
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ariel_anchapaxi.db3");
#else
    string dbPath = Path.Combine(FileSystem.AppDataDirectory, "ariel_anchapaxi.db3");
#endif

            builder.Services.AddSingleton<AirportRepository>(s => ActivatorUtilities.CreateInstance<AirportRepository>(s, dbPath));

            builder.Services.AddSingleton<APIRepository>();

            return builder.Build();
        }
    }
}
