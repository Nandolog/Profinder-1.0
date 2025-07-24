using Microsoft.Maui.Controls;

namespace Profinder_1._0.Views;

public partial class BienvenidaPage : ContentPage
{
    public BienvenidaPage()
    {
        InitializeComponent();
    }

    // 🚀 Evento que se ejecuta al presionar el botón "Comenzar"
    private async void OnComenzarClicked(object sender, EventArgs e)
    {
        // Aquí decides a qué página navegar, por ejemplo, LoginPage
       await Shell.Current.GoToAsync("login");

    }
}