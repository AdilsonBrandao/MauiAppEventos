namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public int Participantes { get; set; }
        public string Local { get; set; }
        public const double CustoPorParticipante = 50.00; // Valor fixo

        public TimeSpan Duracao => Termino - Inicio;
        public double CustoTotal => Participantes * CustoPorParticipante;

        public override string ToString() =>
            $"**📋 Resumo Completo**\n\n" +
            $"**🎉 Evento:** {Nome}\n" +
            $"**📍 Local:** {Local}\n" +
            $"**📅 Data:** {Inicio:dd/MM/yyyy} a {Termino:dd/MM/yyyy}\n" +
            $"**⏳ Duração:** {Duracao.Days} dias\n" +
            $"**👥 Participantes:** {Participantes}\n" +
            $"**💵 Valor total:** {CustoTotal:C} (R$50 por pessoa)";
    }
}