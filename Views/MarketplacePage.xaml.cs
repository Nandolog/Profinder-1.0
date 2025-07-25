using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Profinder_1._0.Models;

namespace Profinder_1._0.Views
{
    public partial class MarketplacePage : ContentPage
    {
        public ObservableCollection<PerfilProfesional> ProfesionalesOriginal { get; set; }
        public ObservableCollection<PerfilProfesional> ProfesionalesFiltrados { get; set; }

        public MarketplacePage()
        {
            InitializeComponent();

            ProfesionalesOriginal = new ObservableCollection<PerfilProfesional>
            {
                new ()
                {
                    Nombre = "María López",
                    Especialidad = "Electricista",
                    Ubicacion = "Villa Hayes",
                    Descripcion = "Instalaciones eléctricas certificadas.",
                    Correo = "maria@example.com",
                    Telefono = "0981-123456",
                    FotoUrl = "maria.png"
                },
                new ()
                {
                    Nombre = "Juan Torres",
                    Especialidad = "Plomero",
                    Ubicacion = "Remansito",
                    Descripcion = "Plomería residencial y comercial.",
                    Correo = "juan@example.com",
                    Telefono = "0971-654321",
                    FotoUrl = "juan.png"
                }
                // 💡 Agregá más perfiles para testear la interfaz
            };

            ProfesionalesFiltrados = new ObservableCollection<PerfilProfesional>(ProfesionalesOriginal);
            ProjectList.ItemsSource = ProfesionalesFiltrados;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            AplicarFiltros();
        }

        private void OnEspecialidadSelected(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void OnCiudadSelected(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string textoBuscado = Buscador.Text?.ToLower() ?? "";
            string especialidadSeleccionada = EspecialidadPicker.SelectedItem?.ToString() ?? "";
            string ciudadSeleccionada = CiudadPicker.SelectedItem?.ToString() ?? "";

            var resultados = ProfesionalesOriginal.Where(p =>
                (string.IsNullOrEmpty(textoBuscado) || p.Especialidad.ToLower().Contains(textoBuscado)) &&
                (string.IsNullOrEmpty(especialidadSeleccionada) || p.Especialidad == especialidadSeleccionada) &&
                (string.IsNullOrEmpty(ciudadSeleccionada) || p.Ubicacion == ciudadSeleccionada)
            );

            ProfesionalesFiltrados.Clear();
            foreach (var p in resultados)

                ProfesionalesFiltrados.Add(p);
        }

        private async void OnViewProfileClicked(object sender, EventArgs e)
        {
            if (sender is Button boton && boton.BindingContext is PerfilProfesional perfil)
            {
                await DisplayAlert(perfil.Nombre,
                    $"Especialidad: {perfil.Especialidad}\nUbicación: {perfil.Ubicacion}\n{perfil.Descripcion}",
                    "Cerrar");
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            if (sender is VisualElement button)
            {
                await Task.WhenAll(
                    button.ScaleTo(0.9, 100),
                    button.FadeTo(0.5, 100)
                );

                await Task.WhenAll(
                    button.ScaleTo(1, 100),
                    button.FadeTo(1, 100)
                );

                await Shell.Current.GoToAsync("main");
            }

        }
    }
}