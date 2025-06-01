using MauiAppEventos.Models;

namespace MauiAppEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            lblResumo.Text = evento.ToString();
        }

        private async void BtnConfirmar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso", "Evento cadastrado com sucesso!", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}