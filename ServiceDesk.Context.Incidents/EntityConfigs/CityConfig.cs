using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = 1, Name = "New York" },
                new City { Id = 2, Name = "Los Angeles" },
                new City { Id = 3, Name = "Chicago" },
                new City { Id = 4, Name = "Houston" },
                new City { Id = 5, Name = "Phoenix" },
                new City { Id = 6, Name = "Philadelphia" },
                new City { Id = 7, Name = "Jacksonville" },
                new City { Id = 8, Name = "Columbus" },
                new City { Id = 9, Name = "Seattle" }
            );
        }
    }
}
