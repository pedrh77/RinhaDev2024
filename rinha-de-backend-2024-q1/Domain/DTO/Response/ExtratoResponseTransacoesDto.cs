namespace Domain.DTO.Response
{
    public class ExtratoResponseTransacoesDto
    {
        public int valor { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public DateTime realizada_em { get; set; }
    }
}
