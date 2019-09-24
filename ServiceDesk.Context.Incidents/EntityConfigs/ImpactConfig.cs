using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class ImpactConfig : IEntityTypeConfiguration<Impact>
    {
        public void Configure(EntityTypeBuilder<Impact> builder)
        {
            builder.HasData(
                new Impact { Id = 1, Name = "Single" },
                new Impact { Id = 2, Name = "Group" },
                new Impact { Id = 3, Name = "Mass" }
            );
        }
    }
}
