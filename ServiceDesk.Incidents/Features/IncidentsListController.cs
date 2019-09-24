using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure.Filters;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Features
{
    public class IncidentsListController : IncidentsBaseServiceDeskController
    {
        private readonly IServiceQueryHandler<FilterConfig, IEnumerable<IncidentList>> _getAllIncidentList;
        private readonly IDeleteServiceHandler<long> _deleteIncident;
        
        public IncidentsListController(
            IDeleteServiceHandler<long> deleteIncident,
            IServiceQueryHandler<FilterConfig, IEnumerable<IncidentList>> getAllIncidentList)
        {
            _getAllIncidentList = getAllIncidentList;
            _deleteIncident = deleteIncident;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery]FilterConfig filterConfigs)
        {
            return Ok(_getAllIncidentList.Handle(filterConfigs));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIncident(long id)
        {
            _deleteIncident.Handle(id);
            if (_deleteIncident.HasErrors)
                return BadRequest(_deleteIncident.Errors);
            return Ok();
        }

    }
}
