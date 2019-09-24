using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure.ActionHandler;
using ServiceDesk.Infrastructure.Runners;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Incidents.Service
{
    public class CreateIncidentService : ICreateServiceHandler<IncidentDto>
    {
        public ICollection<ValidationResult> Errors => _runner.Errors;
        public bool HasErrors => Errors.Any();
        private readonly Runner<IncidentDto, Incident> _runner;
        public CreateIncidentService(
            ICreateActionHandler<IncidentDto, Incident> createAction,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _runner = new Runner<IncidentDto, Incident>(createAction, incidentsQueryableProvider);
        }

        public void Handle(IncidentDto input)
        {
            _runner.Run(input);
        }

    }
}
