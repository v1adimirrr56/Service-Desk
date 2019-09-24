using AutoMapper;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure.Filters;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceDesk.Incidents.Features.Services
{
    public class GetAllIncidentListService: IServiceQueryHandler<FilterConfig, IEnumerable<IncidentList>>
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        private readonly IMapper _mapper;
        public GetAllIncidentListService(
            IMapper mapper,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
            _mapper = mapper;
        }
        public IEnumerable<IncidentList> Handle(FilterConfig filterConfigs)
        {
            var query = _incidentsQueryableProvider
                .Context
                .Set<Incident>();

            var result = _mapper
                .ProjectTo<IncidentList>(query)
                .Filter(filterConfigs)
                .ToList();
            return result;
        }
    }
}
