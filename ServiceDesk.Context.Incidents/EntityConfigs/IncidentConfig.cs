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
            builder.Property("Rate").HasDefaultValue(1);
            builder.HasData(
                new Incident
                {
                    Id = 1,
                    ContactEmail = "ching.hso-lin89@example.com",
                    ContactPhone = "+1(137)-691-2995",
                    CreateDate = DateTime.Now,
                    ImpactId = 1,
                    ManagerId = 1,
                    NotificationType = NotificationType.Email,
                    PhaseId = 1,
                    PriorityId = 1,
                    ShareType = ShareType.Internal,
                    StateId = 1,
                    PlanDateResolve = DateTime.Now.AddDays(10),
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
                    ContactPhone = "+1(137)-691-2995",
                    CreateDate = DateTime.Now,
                    ImpactId = 2,
                    ManagerId = 2,
                    NotificationType = NotificationType.Email | NotificationType.Sms,
                    PhaseId = 2,
                    PriorityId = 2,
                    ShareType = ShareType.External,
                    StateId = 2,
                    PlanDateResolve = DateTime.Now.AddDays(16),
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
                    ContactPhone = "+1(137)-691-2995",
                    CreateDate = DateTime.Now,
                    ImpactId = 3,
                    ManagerId = 3,
                    NotificationType = NotificationType.Email,
                    PhaseId = 3,
                    PriorityId = 3,
                    ShareType = ShareType.Internal,
                    StateId = 3,
                    PlanDateResolve = DateTime.Now.AddDays(2),
                    StatusId = 3,
                    CityId = 3,
                    Title = "The Evitable Conflict: The European Region",
                    CreatorName = "Szegeczowska",
                    Rate = 2
                }
            );
        }
    }
}
