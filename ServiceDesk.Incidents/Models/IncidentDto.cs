using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Models
{
    public class IncidentDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Archive {get;set;}
        public string Branch { get; set; }
        public ShareType ShareType { get; set; }
    } 

    public enum ShareType
    {
        Internal,
        External
    }

}
