using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class PriorityConfig : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.HasData(
                new Priority { Id = 1, PriorityType = "None" },
                new Priority { Id = 2, PriorityType = "Normal" },
                new Priority { Id = 3, PriorityType = "Major" },
                new Priority { Id = 4, PriorityType = "Critical" }
            );
        }
    }
}
