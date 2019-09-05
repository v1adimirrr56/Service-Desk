using Microsoft.EntityFrameworkCore;
using ServiceDesk.Incidents.Entities;

namespace ServiceDesk.Incidents.Context
{
    public class IncidentsContext : DbContext
    {
        public DbSet<Incident> Incidents { get; set; }
        public IncidentsContext(DbContextOptions<IncidentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
