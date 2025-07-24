namespace Profinder_1._0.Pages;
using Profinder_1._0.Views;
using System;

public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Comenzamos ocultando el logo
        SplashLogo.Opacity = 0;
        SplashLogo.Scale = 0.7;

        // 🌟 Animación suave de entrada (fade + zoom lento)
        await Task.WhenAll(
            SplashLogo.FadeTo(1, 1500, Easing.CubicOut),
            SplashLogo.ScaleTo(1, 1500, Easing.CubicOut)
        );

        // Pausa para que el usuario lo aprecie
        await Task.Delay(800);

        // Salta directamente a la página "Bienvenida" registrada en AppShell, ignorando historial
        Application.Current.MainPage = new AppShell();



    }
}
