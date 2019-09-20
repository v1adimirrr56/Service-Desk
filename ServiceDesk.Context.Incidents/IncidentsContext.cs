using Microsoft.EntityFrameworkCore;
using ServiceDesk.Context.Incidents.EntityConfigs;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;

namespace ServiceDesk.Context.Incidents
{
    public class IncidentsContext : DbContext, IIncidentsQueryableProvider
    {
        public DbContext Context => this;
        public DbSet<Incident> Incidents { get; set; }

        public IncidentsContext(DbContextOptions<IncidentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new IncidentConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new ImpactConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());
            modelBuilder.ApplyConfiguration(new PhaseConfig());
            modelBuilder.ApplyConfiguration(new PriorityConfig());
            modelBuilder.ApplyConfiguration(new StateConfig());
            modelBuilder.ApplyConfiguration(new StatusConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
