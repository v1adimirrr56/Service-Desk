using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class StateConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasData(
                new State { Id = 1, Name = "New York" },
                new State { Id = 2, Name = "California" },
                new State { Id = 3, Name = "Illinois" },
                new State { Id = 4, Name = "Texas" },
                new State { Id = 5, Name = "Arizona" },
                new State { Id = 6, Name = "Pennsylvania" },
                new State { Id = 7, Name = "Florida" },
                new State { Id = 8, Name = "Ohio" },
                new State { Id = 9, Name = "Washington" }
            );
        }
    }
}
