using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class StatusConfig : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status { Id = 1, Name = "Open" },
                new Status { Id = 2, Name = "In work" },
                new Status { Id = 3, Name = "Pass vendor" },
                new Status { Id = 4, Name = "Hold" },
                new Status { Id = 5, Name = "Resolve" },
                new Status { Id = 6, Name = "Closed" }
            );
        }
    }
}
