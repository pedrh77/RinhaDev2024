using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class RinhaContext : DbContext
    {

        public RinhaContext(DbContextOptions<RinhaContext> options) : base(options)
        {

        }

        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
