using Microsoft.EntityFrameworkCore;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;

namespace ServiceDesk.Context.Incidents
{
    public class IncidentsContext : DbContext, IIncidentsQueryableProvider
    {
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Branch> Brabches { get; set; }
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
