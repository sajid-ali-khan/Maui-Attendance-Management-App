using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("CooperHewitt-Book.otf", "MyFont_Book");
                    fonts.AddFont("CooperHewitt-Bold.otf", "MyFont_Bold");
                    fonts.AddFont("CooperHewitt-Semibold.otf", "MyFont_SemiBold");
                    fonts.AddFont("CooperHewitt-Light.otf", "MyFont_Light");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
