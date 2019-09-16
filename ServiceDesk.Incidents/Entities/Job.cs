using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Job : IHasId
    {
        public long Id { get; set; }
        public string JobTitle { get; set; }
        public virtual Incident Incident { get; set; }
        public long IncidentId { get; set; }

    }
}
