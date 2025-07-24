using Profinder_1._0.Pages;
using Profinder_1._0.Views;
namespace Profinder_1._0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SplashPage(); // 👈 hace que el splash aparezca primero
            ;


        }
    }
}
