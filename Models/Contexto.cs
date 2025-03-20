using Microsoft.EntityFrameworkCore;

namespace ProjetoCorina.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
