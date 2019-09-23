using AutoMapper;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;

namespace ServiceDesk.Incidents
{
    public class IncidentProfile : Profile
    {
        public IncidentProfile()
        {
            CreateMap<Incident, IncidentDto>();
        }
    }
}
