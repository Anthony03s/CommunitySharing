<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace CommunitySharing;
=======
namespace CommunitySharing;
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

<<<<<<< HEAD
    // ✅ SIGN UP BUTTON CLICK HANDLER
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        // Hide any old message
        ValidationMessageLabel.IsVisible = false;

        // Read user input
        string fullName = FullNameEntry.Text?.Trim();
        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;
        bool termsAccepted = TermsCheckBox.IsChecked;

        // --- VALIDATION SECTION ---
        if (string.IsNullOrEmpty(fullName))
        {
            ShowValidationMessage("Please enter your full name.");
            return;
        }

        if (string.IsNullOrEmpty(email))
        {
            ShowValidationMessage("Please enter your email address.");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            ShowValidationMessage("Please enter a password.");
            return;
        }

        if (string.IsNullOrEmpty(confirmPassword))
        {
            ShowValidationMessage("Please confirm your password.");
            return;
        }

        if (password != confirmPassword)
        {
            ShowValidationMessage("Passwords do not match.");
            return;
        }

        if (!termsAccepted)
        {
            ShowValidationMessage("Please agree to the Terms & Conditions before signing up.");
            return;
        }

        // ✅ If all checks pass, navigate to DiscoverPage
        await Shell.Current.GoToAsync($"//{nameof(DiscoverPage)}");
    }

    // Displays the red validation message under the Sign Up button
    private void ShowValidationMessage(string message)
    {
        ValidationMessageLabel.Text = message;
        ValidationMessageLabel.IsVisible = true;
    }

    // ✅ LOGIN CLICK HANDLER
=======
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

>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
<<<<<<< HEAD

    // ✅ SHOW PASSWORD CHECKBOX HANDLER
    private void OnShowPasswordCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        PasswordEntry.IsPassword = !e.Value;
        ConfirmPasswordEntry.IsPassword = !e.Value;
    }

    // ✅ HIDE PASSWORD WHEN USER PRESSES "NEXT"
    private void OnPasswordCompleted(object sender, EventArgs e)
    {
        PasswordEntry.IsPassword = true;
        ConfirmPasswordEntry.IsPassword = true;
        ShowPasswordCheckBox.IsChecked = false;
    }

    // ✅ RESET SHOW PASSWORD CHECKBOX IF PASSWORD IS CLEARED
    private void OnPasswordTextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
            ShowPasswordCheckBox.IsChecked = false;
    }
=======
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
}
=======
<<<<<<< HEAD
﻿namespace CommunitySharing;
=======
namespace CommunitySharing;
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

<<<<<<< HEAD
    // ✅ SIGN UP BUTTON CLICK HANDLER
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        // Hide any old message
        ValidationMessageLabel.IsVisible = false;

        // Read user input
        string fullName = FullNameEntry.Text?.Trim();
        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;
        bool termsAccepted = TermsCheckBox.IsChecked;

        // --- VALIDATION SECTION ---
        if (string.IsNullOrEmpty(fullName))
        {
            ShowValidationMessage("Please enter your full name.");
            return;
        }

        if (string.IsNullOrEmpty(email))
        {
            ShowValidationMessage("Please enter your email address.");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            ShowValidationMessage("Please enter a password.");
            return;
        }

        if (string.IsNullOrEmpty(confirmPassword))
        {
            ShowValidationMessage("Please confirm your password.");
            return;
        }

        if (password != confirmPassword)
        {
            ShowValidationMessage("Passwords do not match.");
            return;
        }

        if (!termsAccepted)
        {
            ShowValidationMessage("Please agree to the Terms & Conditions before signing up.");
            return;
        }

        // ✅ If all checks pass, navigate to DiscoverPage
        await Shell.Current.GoToAsync($"//{nameof(DiscoverPage)}");
    }

    // Displays the red validation message under the Sign Up button
    private void ShowValidationMessage(string message)
    {
        ValidationMessageLabel.Text = message;
        ValidationMessageLabel.IsVisible = true;
    }

    // ✅ LOGIN CLICK HANDLER
=======
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

>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
<<<<<<< HEAD

    // ✅ SHOW PASSWORD CHECKBOX HANDLER
    private void OnShowPasswordCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        PasswordEntry.IsPassword = !e.Value;
        ConfirmPasswordEntry.IsPassword = !e.Value;
    }

    // ✅ HIDE PASSWORD WHEN USER PRESSES "NEXT"
    private void OnPasswordCompleted(object sender, EventArgs e)
    {
        PasswordEntry.IsPassword = true;
        ConfirmPasswordEntry.IsPassword = true;
        ShowPasswordCheckBox.IsChecked = false;
    }

    // ✅ RESET SHOW PASSWORD CHECKBOX IF PASSWORD IS CLEARED
    private void OnPasswordTextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
            ShowPasswordCheckBox.IsChecked = false;
    }
=======
>>>>>>> 2c2e97432db390f6a9492ac824ce27e52bc47044
}
>>>>>>> e65750449b65524b45e3e9a8482202d8c5d4600a
