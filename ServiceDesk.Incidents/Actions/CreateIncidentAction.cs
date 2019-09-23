using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ActionHandler;
using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.Incidents.Actions
{
    public class CreateIncidentAction
        : ActionError, IActionHandler<IncidentDto, Incident>
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        public CreateIncidentAction(IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }
        public Incident Action(IncidentDto input)
        {
            AddError("Fatal error", new[] { nameof(input.CityId) });
            AddError("Fatal error2", new[] { nameof(input.ImpactId) });
            return new Incident();
        }
    }
}
