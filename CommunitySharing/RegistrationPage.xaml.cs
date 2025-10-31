namespace CommunitySharing;

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        if (!TermsCheckBox.IsChecked)
        {
            await DisplayAlert("Terms", "You must agree to the Terms & Conditions and Privacy Policy.", "OK");
            return;
        }

        if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
        {
            await DisplayAlert("Password Error", "Passwords do not match.", "OK");
            return;
        }

        await DisplayAlert("Success", "Account created successfully! (Placeholder)", "OK");

        await Shell.Current.GoToAsync(nameof(LoginPage));
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
