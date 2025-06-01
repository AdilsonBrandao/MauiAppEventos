using MauiAppEventos.Views;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CadastroEventos());
        }
    }
}