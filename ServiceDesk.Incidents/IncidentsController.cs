using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using System.Linq;

namespace ServiceDesk.Incidents
{
    public class IncidentsController : ServiceDeskBaseController
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        public IncidentsController(IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }

        [HttpGet]
        public IActionResult Get([FromBody]IncidentDto incident)
        {
            return Ok(new long[1 , 2]);
        }
    }
}
