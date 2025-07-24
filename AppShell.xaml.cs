using Profinder_1._0.Pages;
using Profinder_1._0.Views;
namespace Profinder_1._0
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // 🧭 Registrar rutas personalizadas

            Routing.RegisterRoute("splash", typeof(SplashPage));
            Routing.RegisterRoute("bienvenida", typeof(BienvenidaPage));
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("register", typeof(RegisterPage));
            Routing.RegisterRoute("marketplace", typeof(MarketplacePage));
            Routing.RegisterRoute("main", typeof(MainPage));
            Routing.RegisterRoute("publishprofile", typeof(PublishProfilePage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));


        }
    }
}
