namespace Domain.DTO.Response
{
    public class TransacaoResponseDto
    {
        public long limite { get; private set; }
        public long saldo { get; private set; }

        public TransacaoResponseDto(long limite, long saldo)
        {
            this.limite = limite;
            this.saldo = saldo;
        }
    }
}
