using Microsoft.EntityFrameworkCore;
using ServiceDesk.Context.Infrastructure;

namespace ServiceDesk.Context.Crashes
{
    public class CrashesContext : DbContext, ICrashesQueryableProvider
    {
        public DbContext Context => this;

        public CrashesContext(DbContextOptions<CrashesContext> options)
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
