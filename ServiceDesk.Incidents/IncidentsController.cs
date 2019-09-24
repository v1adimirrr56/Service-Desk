using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using System.Linq;
using ServiceDesk.Infrastructure.ServiceHandler;
using ServiceDesk.Infrastructure.Validations;

namespace ServiceDesk.Incidents
{
    public class IncidentsController : IncidentsBaseServiceDeskController
    {
        private readonly IServiceHandler<IncidentDto> _createIncident;
        private IServiceQueryHandler<long, IncidentDto> _getIncidentService;
        public IncidentsController(
            IServiceQueryHandler<long, IncidentDto> getIncidentService,
            IServiceHandler<IncidentDto> createIncident)
        {
            _createIncident = createIncident;
            _getIncidentService = getIncidentService;
        }

        [HttpGet("{id}")]
        public IActionResult GetIncidentById(long id)
        {
            return Ok(_getIncidentService.Handle(id));
        }

        [HttpPost]
        public IActionResult CreateIncident([FromBody]IncidentDto incident)
        {
            _createIncident.Handle(incident);
            if (_createIncident.HasError)
                return BadRequest(new ValidationResultModel(_createIncident.Errors));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIncident([FromBody]IncidentDto incident)
        {
            _createIncident.Handle(incident);
            if (_createIncident.HasError)
                return BadRequest(new ValidationResultModel(_createIncident.Errors));
            return Ok();
        }
    }
}
