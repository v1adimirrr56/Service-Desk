using Microsoft.EntityFrameworkCore;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure.Context;

namespace ServiceDesk.Incidents.Context
{
    public class IncidentsContext : DbContext, IIncidentsQueryableProvider
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbContext Context => this;

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
