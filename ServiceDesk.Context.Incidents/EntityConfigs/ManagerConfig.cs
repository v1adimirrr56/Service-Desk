using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasData(
                new Manager { Id = 1, FirstName = "Linda",  LastName = "Armstrong", Email = "linda.armstrong76@example.com" },
                new Manager { Id = 2, FirstName = "Dylan", LastName = "Cole", Email = "dylan.cole27@example.com" },
                new Manager { Id = 3, FirstName = "Travis", LastName = "Murphy", Email = "travis.murphy20@example.com" },
                new Manager { Id = 4, FirstName = "Barry", LastName = "Frazier", Email = "barry.frazier29@example.com" }
            );
        }
    }
}
