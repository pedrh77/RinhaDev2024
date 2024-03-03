using System.ComponentModel.DataAnnotations;

namespace Domain.DTO.Request
{
    public class TransacaoRequestDto
    {
        [Required]
        public long valor { get; set; }
        [Required]
        public string tipo { get; set; }
        [Required]
        public string descricao { get; set; }

        public TransacaoRequestDto(long valor, string tipo, string descricao)
        {
            this.valor = valor;
            this.descricao = descricao;
            if (tipo == "d" || tipo == "c")
                this.tipo = tipo;
            else throw new KeyNotFoundException("Tipo de Transação não aceita");
        }
    }
}
