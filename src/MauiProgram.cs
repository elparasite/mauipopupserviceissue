using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PopupServiceIssue.ViewModels;
using PopupServiceIssue.Views;

namespace PopupServiceIssue
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransientPopup<MyPopup,MyPopupViewModel>();
            return builder.Build();
        }
    }
}
