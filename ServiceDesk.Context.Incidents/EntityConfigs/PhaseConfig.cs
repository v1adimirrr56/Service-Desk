using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class PhaseConfig : IEntityTypeConfiguration<Phase>
    {
        public void Configure(EntityTypeBuilder<Phase> builder)
        {
            builder.HasData(
                new Phase { Id = 1, Name = "Registration" },
                new Phase { Id = 2, Name = "In working" },
                new Phase { Id = 3, Name = "Resolving" },
                new Phase { Id = 4, Name = "Closed" }
            );
        }
    }
}
