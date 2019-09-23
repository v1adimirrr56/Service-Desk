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
    public class GetAllIncidentListService: IServiceQueryHandler<ICollection<FilterConfig>, IEnumerable<IncidentList>>
    {
        private readonly IIncidentsQueryableProvider _provider;
        private readonly IMapper _mapper;
        public GetAllIncidentListService(
            IMapper mapper,
            IIncidentsQueryableProvider provider)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public IEnumerable<IncidentList> Handle(ICollection<FilterConfig> filterConfigs)
        {
            var query =_provider
                .Context
                .Set<Incident>()
                .Filter(filterConfigs);

            var result = _mapper
                .ProjectTo<IncidentList>(query)
                .ToList();
            return result;
        }
    }
}
