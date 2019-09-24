using AutoMapper;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ActionHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Actions
{
    public class EditIncidentAction
        : ActionError, IEditActionHandler<IncidentDto, Incident>
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        private readonly IMapper _mapper;
        public EditIncidentAction(
            IMapper mapper,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
            _mapper = mapper;
        }

        public Incident Action(IncidentDto input)
        {
            //New York state
            if (input.StateId == 1)
                AddError("You can't edit incident from New York", new[] { nameof(input.StateId) });

            var incident = _incidentsQueryableProvider
                .Context
                .Set<Incident>()
                .Find(input.Id);
            _mapper.Map(input, incident);

            return incident;
        }
    }
}
