using Domain;
using Domain.DTO.Response;
using Domain.Interfaces;
using Domain.Models;
using Infra;

namespace Services.Service
{
    public class ExtratoService : IExtratoService
    {
        private readonly RinhaContext _context;


        public ExtratoService(RinhaContext context)
        {
            _context = context;
        }

        public ExtratoResponseDto ExtratoClientePorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            if (cliente != null)
            {
                var saldo = new ExtratoResponseSaldoDto(cliente.Saldo, cliente.Limite);

                List<Transacao> transacoes = _context.Transacoes.Where(x => x.Cliente.Id == id).OrderBy(x => x.Realizada_Em).Take(10).ToList();
                if (transacoes == null || transacoes.Count() == 0)

                    return new ExtratoResponseDto(saldo);
            }

            throw new Exception();
        }

    }
}
