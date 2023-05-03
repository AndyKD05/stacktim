using Microsoft.EntityFrameworkCore;
using stacktimm.Models.Domain;

namespace stacktimm.Data
{
    public class stacktimmDbContext : DbContext
    {
        public stacktimmDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Connaissance> Connaissances { get; set; }
        public DbSet<Ressource> Ressources { get; set; }
    }
}
