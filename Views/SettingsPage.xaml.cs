namespace Profinder_1._0.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        var button = sender as VisualElement;

        // ✨ Animación de retroceso con efecto táctil
        _ = await Task.WhenAll(
            button.ScaleTo(0.9, 100),
            button.FadeTo(0.5, 100)
        );

        await Task.WhenAll(
            button.ScaleTo(1, 100),
            button.FadeTo(1, 100)
        );

        // 🔙 Navegación hacia atrás
        await Shell.Current.GoToAsync("main");
    }
}