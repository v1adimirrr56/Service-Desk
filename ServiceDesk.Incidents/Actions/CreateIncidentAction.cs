using AutoMapper;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ActionHandler;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ServiceDesk.Incidents.Actions
{
    public class CreateIncidentAction
        : ActionError, ICreateActionHandler<IncidentDto, Incident>
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        private readonly IMapper _mapper;
        public CreateIncidentAction(
            IMapper mapper,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
            _mapper = mapper;
        }
        public Incident Action(IncidentDto input)
        {
            //is New York
            //is not critical
            if (input.StateId == 1
                && input.PriorityId != 4)
                AddError("Priority for New York must be critical", new[] { nameof(input.PriorityId) });

            if (HasErrors)
                return null;

            var incident = _mapper.Map<IncidentDto, Incident>(input);
            incident.StatusId = 1;
            incident.PhaseId = 1;

            _incidentsQueryableProvider.Context.Add(incident);

            return incident;
        }
    }
}
