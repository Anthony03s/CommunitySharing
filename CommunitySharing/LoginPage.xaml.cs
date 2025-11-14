<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace CommunitySharing;
=======
namespace CommunitySharing;
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
<<<<<<< HEAD
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
=======
    { 
        await DisplayAlert("Login Success", "Welcome back! (Placeholder)", "OK");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
<<<<<<< HEAD
        await Shell.Current.GoToAsync("RegistrationPage");
=======
        await Shell.Current.GoToAsync($"../{nameof(RegistrationPage)}");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
<<<<<<< HEAD
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
=======
        await DisplayAlert("Forgot Password", "Forgot Password functionality is not implemented yet.", "OK");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }
}
=======
<<<<<<< HEAD
﻿namespace CommunitySharing;
=======
namespace CommunitySharing;
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
<<<<<<< HEAD
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
=======
    { 
        await DisplayAlert("Login Success", "Welcome back! (Placeholder)", "OK");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
<<<<<<< HEAD
        await Shell.Current.GoToAsync("RegistrationPage");
=======
        await Shell.Current.GoToAsync($"../{nameof(RegistrationPage)}");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }

    private async void OnForgotPasswordClicked(object sender, EventArgs e)
    {
<<<<<<< HEAD
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
=======
        await DisplayAlert("Forgot Password", "Forgot Password functionality is not implemented yet.", "OK");
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    }
}
>>>>>>> e65750449b65524b45e3e9a8482202d8c5d4600a
