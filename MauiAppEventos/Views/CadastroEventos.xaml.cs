using MauiAppEventos.Models;
using System;

namespace MauiAppEventos.Views
{
    public partial class CadastroEventos : ContentPage
    {
        public CadastroEventos()
        {
            InitializeComponent();
            dtpInicio.Date = DateTime.Today;
            dtpTermino.Date = DateTime.Today.AddDays(1);
        }

        private async void BtnAvancar_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Validações
                if (pickerEvento.SelectedItem == null)
                {
                    await DisplayAlert("Atenção", "Selecione um tipo de evento", "OK");
                    return;
                }

                if (pickerLocal.SelectedItem == null)
                {
                    await DisplayAlert("Atenção", "Selecione um local", "OK");
                    return;
                }

                // Cria o objeto evento com os dados
                var evento = new Evento
                {
                    Nome = pickerEvento.SelectedItem.ToString(),
                    Local = pickerLocal.SelectedItem.ToString(),
                    Inicio = dtpInicio.Date,
                    Termino = dtpTermino.Date,
                    Participantes = (int)stpParticipantes.Value
                };

                // Navega para a tela de resumo
                await Navigation.PushAsync(new ResumoEventoPage(evento));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
            }
        }
    }
}