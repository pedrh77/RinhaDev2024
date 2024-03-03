namespace Domain.DTO.Response
{
    public class ExtratoResponseDto
    {
        public ExtratoResponseSaldoDto saldo { get; set; }
        public List<ExtratoResponseTransacoesDto> ultimas_transacoes { get; set; }

        public ExtratoResponseDto(ExtratoResponseSaldoDto saldo)
        {
            this.saldo = saldo;
        }
        public ExtratoResponseDto(ExtratoResponseSaldoDto saldo, List<ExtratoResponseTransacoesDto> transacoes)
        {
            this.saldo = saldo;
            ultimas_transacoes = transacoes;
        }

    }

}
