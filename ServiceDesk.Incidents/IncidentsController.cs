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
        public IActionResult Get(IncidentDto incidentDto)
        {
            _incidentsQueryableProvider
                .Context
                .Add(new Incident { Name = "Test" });
            _incidentsQueryableProvider.Context.SaveChanges();
            return Ok(new long[1 , 2]);
        }
    }
}
