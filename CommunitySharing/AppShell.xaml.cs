namespace CommunitySharing;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(IntroductionPage), typeof(IntroductionPage));
        Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));

    }
}