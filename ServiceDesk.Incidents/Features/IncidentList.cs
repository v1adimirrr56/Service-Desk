using ServiceDesk.Incidents.Entities;
using ServiceDesk.SmartUI.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ServiceDesk.Incidents.Features
{
    [Grid]
    public class IncidentList
    {
        public long Id { get; set; }
        [DisplayName("State")]
        public string StateName { get; set; }
        [DisplayName("Status")]
        public string StatusName { get; set; }
        [DisplayName("Priority")]
        public string PriorityPriorityType { get; set; }
        [DisplayName("City")]
        public string CityName { get; set; }
        public double Rate { get; set; }
    }
}
