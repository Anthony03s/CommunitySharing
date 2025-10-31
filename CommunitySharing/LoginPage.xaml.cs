namespace CommunitySharing;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        ValidationMessageLabel.IsVisible = false;

        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        if (string.IsNullOrEmpty(email))
        {
            ShowValidationMessage("Please enter your email.");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            ShowValidationMessage("Please enter your password.");
            return;
        }

        // ? Replace this with your actual login auth logic later
        await Shell.Current.GoToAsync("//DiscoverPage");
    }

    private void ShowValidationMessage(string message)
    {
        ValidationMessageLabel.Text = message;
        ValidationMessageLabel.IsVisible = true;
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RegistrationPage");
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ForgotPasswordPage");
    }

    private void OnShowPasswordCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        PasswordEntry.IsPassword = !e.Value;
    }

    private void OnPasswordCompleted(object sender, EventArgs e)
    {
        PasswordEntry.IsPassword = true;
        ShowPasswordCheckBox.IsChecked = false;
    }

    private void OnPasswordTextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
            ShowPasswordCheckBox.IsChecked = false;
    }
}
