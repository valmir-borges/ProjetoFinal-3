using Microsoft.EntityFrameworkCore;
using Projeto_Final.Models;

namespace WebApplication1.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoProduto> TipoProduto { get; set; }
        public DbSet<EntradaProduto> EntradaProduto { get; set; }
        public DbSet<TipoSaida> TipoSaida { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
