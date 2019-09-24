using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class StateCityRelation : IHasId
    {
        public long Id { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
    }
}
