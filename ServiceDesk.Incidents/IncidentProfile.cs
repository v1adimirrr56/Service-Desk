using AutoMapper;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;

namespace ServiceDesk.Incidents
{
    public class IncidentProfile : Profile
    {
        public IncidentProfile()
        {
            CreateMap<Incident, IncidentDto>()
                .ForMember(x => x.Manager, x => x.MapFrom(y => y.Manager.FirstName + " " + y.Manager.LastName));
        }
    }
}
