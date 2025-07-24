namespace Profinder_1._0.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirm = ConfirmEntry.Text;

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirm))
        {
            await DisplayAlert("Error", "Completa todos los campos.", "OK");
            return;
        }

        if (password != confirm)
        {
            await DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
            return;
        }

        // 💾 Aquí podrías guardar el usuario en memoria o DB más adelante
        await DisplayAlert("Éxito", "Usuario registrado correctamente.", "OK");

        // Redirige al login
        await Shell.Current.GoToAsync("//login"); // ✅ reemplaza toda la pila

    }
}
