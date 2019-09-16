using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Priority : IHasId
    {
        public long Id { get; set; }
        public PriorityType PriorityType { get; set; }
    }
    public enum PriorityType
    {
        First,
        Second,
        Third,
        Fourth,
        Fiveth
    }
}
