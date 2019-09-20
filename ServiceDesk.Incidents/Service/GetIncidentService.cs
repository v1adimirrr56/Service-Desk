using AutoMapper;
using AutoMapper.QueryableExtensions;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceDesk.Incidents.Service
{
    public class GetIncidentService : IServiceQueryHandler<long, IncidentDto>
    {
        private IIncidentsQueryableProvider _provider;
        private IMapper _mapper;
        public GetIncidentService(IIncidentsQueryableProvider provider, IMapper mapper)
        {
            _provider = provider;
            _mapper = mapper;
        }
        public IncidentDto Handle(long id)
        {
            var query = _provider
                .Context
                .Set<Incident>()
                .Where(x => x.Id == id);
            var result = _mapper
                .ProjectTo<IncidentDto>(query)
                .Single();
            return result;
        }
    }
}
