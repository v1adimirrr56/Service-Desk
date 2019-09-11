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
        public IncidentsController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new long[1 , 2]);
        }
    }
}
