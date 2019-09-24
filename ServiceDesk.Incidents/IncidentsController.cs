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
        private readonly ICreateServiceHandler<IncidentDto> _createIncident;
        private readonly IEditServiceHandler<IncidentDto> _editIncident;
        private IServiceQueryHandler<long, IncidentDto> _getIncidentService;
        public IncidentsController(
            IEditServiceHandler<IncidentDto> editIncident,
            ICreateServiceHandler<IncidentDto> createIncident,
            IServiceQueryHandler<long, IncidentDto> getIncidentService)
        {
            _createIncident = createIncident;
            _editIncident = editIncident;
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
            if (_createIncident.HasErrors)
                return BadRequest(new ValidationResultModel(_createIncident.Errors));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult EditIncident([FromBody]IncidentDto incident)
        {
            _editIncident.Handle(incident);
            if (_editIncident.HasErrors)
                return BadRequest(new ValidationResultModel(_editIncident.Errors));
            return Ok();
        }
    }
}
