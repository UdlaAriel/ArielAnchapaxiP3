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
            string dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "josure_riera.db3");
            builder.Services.AddSingleton<AirportRepository>(s => ActivatorUtilities.CreateInstance<AirportRepository>(s, dbPath));

            return builder.Build();
        }
    }
}
