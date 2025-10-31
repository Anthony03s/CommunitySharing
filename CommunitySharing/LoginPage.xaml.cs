namespace CommunitySharing;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    { 
        await DisplayAlert("Login Success", "Welcome back! (Placeholder)", "OK");
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"../{nameof(RegistrationPage)}");
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Forgot Password", "Forgot Password functionality is not implemented yet.", "OK");
    }
}
