using Microsoft.Maui.Controls;

namespace Profinder_1._0.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGoToMarketplaceClicked(object sender, EventArgs e)
        {
            try
            {
               
                await Shell.Current.GoToAsync("marketplace");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo abrir la página: {ex.Message}", "OK");
            }
        }

        private async void OnPublishProfileClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("publishprofile");

        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
       
            await Shell.Current.GoToAsync("settings");

        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Transición a Login como nueva raíz
            await this.FadeTo(0, 500);
            await Shell.Current.GoToAsync("//login");

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            logo.Opacity = 0;
            ButtonStack.Opacity = 0;

            await logo.FadeTo(1, 800);
            await Task.Delay(300);
            await ButtonStack.FadeTo(1, 800);
        }


    }

}
