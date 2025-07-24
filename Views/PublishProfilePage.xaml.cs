using Microsoft.Maui.Controls;

namespace Profinder_1._0.Views
{
    public partial class PublishProfilePage : ContentPage
    {
        public PublishProfilePage()
        {
            InitializeComponent();
        }

        private async void OnPublishClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            string especialidad = EspecialidadEntry.Text;
            string ubicacion = UbicacionEntry.Text;
            string descripcion = DescripcionEditor.Text;

            await DisplayAlert("Perfil creado", $"Gracias {nombre}, tu perfil ha sido publicado.", "Aceptar");

            // A futuro: guardar el perfil en una base de datos o enviarlo a un listado global
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
}