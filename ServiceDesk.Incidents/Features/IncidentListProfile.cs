using AutoMapper;
using ServiceDesk.Incidents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Features
{
    public class IncidentListProfile: Profile 
    {
        public IncidentListProfile()
        {
            CreateMap<Incident, IncidentList>();
        }
    }
}
