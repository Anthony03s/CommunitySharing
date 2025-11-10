namespace CommunitySharing
{
    public partial class DiscoverPage : ContentPage
    {
        public DiscoverPage()
        {
            InitializeComponent();
        }

        // ?? Search button click
        private async void OnSearchClicked(object sender, EventArgs e)
        {
            string query = SearchEntry.Text?.Trim();

            if (string.IsNullOrEmpty(query))
            {
                await DisplayAlert("Search", "Please enter something to search.", "OK");
                return;
            }

            await DisplayAlert("Search", $"You searched for: {query}", "OK");
        }

        // ?? Bottom Navigation — Discover
        private async void OnNavDiscover(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Discover", "You’re already on the Discover page.", "OK");
        }

        // ?? Bottom Navigation — Upload
        private async void OnNavUpload(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///UploadPage");
        }

        // ?? Bottom Navigation — Messages
        private async void OnNavMessage(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///MessagesPage");
        }

        // ?? Bottom Navigation — Profile
        private async void OnNavProfile(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("///ProfilePage");
        }
    }
}
