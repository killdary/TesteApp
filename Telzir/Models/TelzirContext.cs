using Microsoft.EntityFrameworkCore;

namespace Telzir.Models
{
    public class TelzirContext: DbContext
    {
        public TelzirContext(DbContextOptions<TelzirContext> options):base(options)
        {            
        }

        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<Pacote> Pacote { get; set; }
    }
}