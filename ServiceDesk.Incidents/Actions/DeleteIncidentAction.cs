using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure.ActionHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Actions
{
    public class DeleteIncidentAction
        : ActionError, IDeleteActionHandler<long, Incident>
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        public DeleteIncidentAction(
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }

        public Incident Action(long input)
        {
            var incident = _incidentsQueryableProvider
                .Context
                .Set<Incident>()
                .Find(input);
            _incidentsQueryableProvider
                .Context
                .Remove(incident);

            return incident;
        }
    }
}
