using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure.ActionHandler;
using ServiceDesk.Infrastructure.Runners;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Incidents.Features.Services
{
    public class DeleteIncidentService : IDeleteServiceHandler<long>
    {
        public ICollection<ValidationResult> Errors => _runner.Errors;
        public bool HasErrors => _runner.HasErrors;
        private Runner<long, Incident> _runner;

        public DeleteIncidentService(
            IDeleteActionHandler<long, Incident> deleteAction,
            IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _runner = new Runner<long, Incident>(deleteAction, incidentsQueryableProvider);
        }

        public void Handle(long input)
        {
            _runner.Run(input);
        }
    }
}
