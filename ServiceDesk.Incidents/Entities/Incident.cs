using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Incident : IHasId
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Archive { get; set; }
        public string Branch { get; set; }
        public ShareType ShareType { get; set; }
    }
}
