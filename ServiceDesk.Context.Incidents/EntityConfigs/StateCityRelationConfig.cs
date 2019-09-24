using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Incidents.EntityConfigs
{
    public class StateCityRelationConfig : IEntityTypeConfiguration<StateCityRelation>
    {
        public void Configure(EntityTypeBuilder<StateCityRelation> builder)
        {
            builder.HasData(
                new StateCityRelation
                {
                    Id = 1,
                    CityId = 1,
                    StateId = 1
                },
               new StateCityRelation
               {
                   Id = 2,
                   CityId = 2,
                   StateId = 2
               },
               new StateCityRelation
               {
                   Id = 3,
                   CityId = 3,
                   StateId = 3
               },
                new StateCityRelation
                {
                    Id = 4,
                    CityId = 4,
                    StateId = 4
                },
               new StateCityRelation
               {
                   Id = 5,
                   CityId = 5,
                   StateId = 5
               },
               new StateCityRelation
               {
                   Id = 6,
                   CityId = 6,
                   StateId = 6
               },
               new StateCityRelation
               {
                   Id = 7,
                   CityId = 7,
                   StateId = 7
               },
               new StateCityRelation
               {
                   Id = 8,
                   CityId = 8,
                   StateId = 8
               },
               new StateCityRelation
               {
                   Id = 9,
                   CityId = 9,
                   StateId = 9
               }
            );
        }
    }
}
