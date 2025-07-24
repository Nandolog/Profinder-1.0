using Profinder_1._0.Views;

namespace Profinder_1._0.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    // 🔐 Validación básica y navegación a MainPage
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Error", "Por favor ingresa usuario y contraseña.", "OK");
            return;
        }

        // 👉 Simulación de usuario válido
        if (username == "admin" && password == "1234")
        {
            await Shell.Current.GoToAsync("main");
        }
        else
        {
            await DisplayAlert("Error", "Credenciales inválidas.", "OK");
        }
    }

    // 🆕 Navegación a la página de registro
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("register");

    }
}