using Microsoft.EntityFrameworkCore;

namespace ProjetoCorina.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<TipoUsuarios> TipoUsuarios { get; set; }

        public DbSet<Horarios> Horarios { get; set; }

        public DbSet<Classificacoes> Classificacoes{ get; set; }
    }
}
    