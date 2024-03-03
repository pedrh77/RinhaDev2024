namespace Domain.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Realizada_Em { get; set; }

        public Cliente Cliente { get; set; }
    }
}
