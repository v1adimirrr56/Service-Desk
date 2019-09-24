using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class IncidentConfig : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.Property(x => x.Rate).HasDefaultValue(1);
            builder.Property(x => x.IsComposite).HasDefaultValue(false);
            builder.Property(x => x.UseNotification).HasDefaultValue(false);
            builder.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");

            builder.HasData(
                new Incident
                {
                    Id = 1,
                    ContactEmail = "ching.hso-lin89@example.com",
                    CreateDate = DateTime.UtcNow,
                    ImpactId = 1,
                    ManagerId = 1,
                    IsComposite = true,
                    PassVendorDate = DateTime.UtcNow.AddDays(32),
                    UseNotification = true,
                    PhaseId = 1,
                    PriorityId = 1,
                    ShareType = ShareType.Internal,
                    StateId = 1,
                    PlanDateResolve = DateTime.UtcNow.AddDays(10),
                    StatusId = 1,
                    CityId = 1,
                    Title = "The Evitable Conflict: The Eastern Region",
                    CreatorName = "Ching Hso-lin",
                    Rate = 5
                },
                new Incident
                {
                    Id = 2,
                    ContactEmail = "ngoma42@example.com",
                    CreateDate = DateTime.UtcNow,
                    ImpactId = 2,
                    ManagerId = 2,
                    PassVendorDate = DateTime.UtcNow.AddDays(23),
                    UseNotification = false,
                    PhaseId = 2,
                    PriorityId = 2,
                    ShareType = ShareType.External,
                    StateId = 2,
                    PlanDateResolve = DateTime.UtcNow.AddDays(16),
                    StatusId = 2,
                    CityId = 2,
                    Title = "The Evitable Conflict: The Tropic Region",
                    CreatorName = "Ngoma",
                    Rate = 7
                },
                new Incident
                {
                    Id = 3,
                    ContactEmail = "szegeczowska90@example.com",
                    CreateDate = DateTime.UtcNow,
                    ImpactId = 3,
                    ManagerId = 3,
                    PassVendorDate = DateTime.UtcNow.AddDays(60),
                    UseNotification = true,
                    PhaseId = 3,
                    PriorityId = 3,
                    ShareType = ShareType.Internal,
                    StateId = 3,
                    PlanDateResolve = DateTime.UtcNow.AddDays(2),
                    StatusId = 3,
                    CityId = 3,
                    Title = "The Evitable Conflict: The European Region",
                    CreatorName = "Szegeczowska",
                    Rate = 2
                },
                new Incident
                {
                    Id = 4,
                    ContactEmail = "hiram-mackenzie9@example.com",
                    CreateDate = DateTime.UtcNow,
                    ImpactId = 1,
                    ManagerId = 1,
                    IsComposite = true,
                    PassVendorDate = DateTime.UtcNow.AddDays(2),
                    UseNotification = true,
                    PhaseId = 1,
                    PriorityId = 1,
                    ShareType = ShareType.Internal,
                    StateId = 1,
                    PlanDateResolve = DateTime.UtcNow.AddDays(8),
                    StatusId = 1,
                    CityId = 1,
                    Title = "The Evitable Conflict: The Northern Region",
                    CreatorName = "Hiram Mackenzie",
                    Rate = 5
                }
            );
        }
    }
}
