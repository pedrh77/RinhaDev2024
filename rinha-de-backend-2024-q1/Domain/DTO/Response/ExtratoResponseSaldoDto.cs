namespace Domain.DTO.Response
{
    public class ExtratoResponseSaldoDto
    {
        public int total { get; set; }
        public DateTime data_extrato { get; set; }
        public int limite { get; set; }

        public ExtratoResponseSaldoDto(int total, int limite)
        {
            this.total = total;
            data_extrato = DateTime.Now;
            this.limite = limite;
        }
    }
}
