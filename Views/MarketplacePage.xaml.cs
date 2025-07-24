using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Profinder_1._0.Models;

namespace Profinder_1._0.Views
{
    public partial class MarketplacePage : ContentPage
    {
        public ObservableCollection<PerfilProfesional> Profesionales { get; set; }

        public MarketplacePage()
        {
            InitializeComponent(); // 🔄 Esto debe compilar correctamente si el XAML está bien vinculado

            // 🧪 Cargar perfiles simulados
            Profesionales = new ObservableCollection<PerfilProfesional>
            {
                new ()
                {
                    Nombre = "María López",
                    Especialidad = "Supervisión técnica",
                    Ubicacion = "Asunción",
                    Descripcion = "Ingeniera con 5 años de experiencia en industria alimentaria.",
                    Correo = "maria@example.com",
                    Telefono = "0981-123456",
                    FotoUrl = "maria.png"
                },
                new ()
                {
                    Nombre = "Juan Torres",
                    Especialidad = "Recursos Humanos",
                    Ubicacion = "Luque",
                    Descripcion = "Especialista en reclutamiento y desarrollo de equipos.",
                    Correo = "juan@example.com",
                    Telefono = "0971-654321",
                    FotoUrl = "juan.png"
                }
            };

            // 🔗 Enlazar la lista al CollectionView definido en XAML
            ProjectList.ItemsSource = Profesionales;
        }

        // 🎯 Acción al pulsar “Ver perfil completo”
        private async void OnViewProfileClicked(object sender, EventArgs e)
        {
            var boton = sender as Button;
            var perfil = boton?.BindingContext as PerfilProfesional;

            if (perfil != null)
            {
                await DisplayAlert(perfil.Nombre,
                    $"Especialidad: {perfil.Especialidad}\nUbicación: {perfil.Ubicacion}\n{perfil.Descripcion}",
                    "Cerrar");
            }
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