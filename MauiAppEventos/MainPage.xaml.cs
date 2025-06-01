namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent(); // Este método é gerado automaticamente - não implemente manualmente
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            // O botão está declarado no XAML com x:Name="CounterBtn"
            // Não precisa da propriedade CounterBtn, pois o compilador gera uma referência automática

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}