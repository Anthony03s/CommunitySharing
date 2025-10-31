using CommunitySharing.ViewModels;
using Microsoft.Extensions.Logging;

namespace CommunitySharing;

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

                // This makes the icons (like visibility) available to the app
                fonts.AddFont("MaterialIcons-Regular.ttf", "MauiMaterial");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Register ViewModels
        builder.Services.AddSingleton<DiscoverPageViewModel>();

        // Register Pages
        builder.Services.AddSingleton<SplashPage>();
        builder.Services.AddSingleton<IntroductionPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<RegistrationPage>();
        builder.Services.AddSingleton<ForgotPasswordPage>();

        // Main App Pages
        builder.Services.AddSingleton<DiscoverPage>();
        builder.Services.AddSingleton<UploadPage>();
        // === THIS IS THE FIX ===
        builder.Services.AddSingleton<MessagesPage>();
        builder.Services.AddSingleton<ProfilePage>();

        return builder.Build();
    }
}