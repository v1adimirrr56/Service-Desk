using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using System.Linq;
using ServiceDesk.Infrastructure.ServiceHandler;

namespace ServiceDesk.Incidents
{
    public class IncidentsController : ServiceDeskBaseController
    {
        private readonly IServiceHandler<IncidentDto> _serviceHandler;
        private IServiceQueryHandler<long, IncidentDto> _getIncidentService;
        public IncidentsController(
            IServiceQueryHandler<long, IncidentDto> getIncidentService,
            IServiceHandler<IncidentDto> serviceHandler)
        {
            _serviceHandler = serviceHandler;
            _getIncidentService = getIncidentService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(_getIncidentService.Handle(id));
        }
    }
}
