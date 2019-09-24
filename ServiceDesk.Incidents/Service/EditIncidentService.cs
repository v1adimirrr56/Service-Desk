using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ActionHandler;
using ServiceDesk.Infrastructure.Runners;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Incidents.Service
{
    public class EditIncidentService : IEditServiceHandler<IncidentDto>
    {
        public ICollection<ValidationResult> Errors => _runner.Errors;
        public bool HasErrors => _runner.HasErrors;
        private readonly Runner<IncidentDto, Incident> _runner;

        public EditIncidentService(
            IEditActionHandler<IncidentDto, Incident> editAction,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _runner = new Runner<IncidentDto, Incident>(editAction, incidentsQueryableProvider);
        }

        public void Handle(IncidentDto input)
        {
            _runner.Run(input);
        }
    }
}
