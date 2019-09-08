using Microsoft.EntityFrameworkCore;
using ServiceDesk.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Crashes.Context
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
