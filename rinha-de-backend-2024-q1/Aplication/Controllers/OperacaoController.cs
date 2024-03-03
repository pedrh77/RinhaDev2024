using Domain.DTO.Request;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aplication.Controllers
{
    [ApiController]
    public class OperacaoController : ControllerBase
    {
        private readonly IExtratoService _Extrato;
        public OperacaoController(IExtratoService extrato)
        {
            _Extrato = extrato;
        }

        // Endpoint de Transação
        [HttpPost("/clientes/{id}/transacoes")]
        public IActionResult NovaTransicao(int id, [FromBody] TransacaoRequestDto test)
        {
            return Ok(test);
        }

        [HttpGet("/clientes/{id}/extrato")]
        public IActionResult ExtratoCliente(int id)
        {
            return Ok(_Extrato.ExtratoClientePorId(id));
        }
    }
}
