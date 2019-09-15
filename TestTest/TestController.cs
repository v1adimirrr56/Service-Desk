using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Context.Incidents;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure;
using System;

namespace TestTest
{
    public class TestController : ServiceDeskBaseController
    {
        private readonly IncidentsContext _incidentsQueryableProvider;
        public TestController(IncidentsContext incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _incidentsQueryableProvider
                .Context
                .Add(new Incident { Name = "Test2229999" });

            var s = ModelState.IsValid;

            _incidentsQueryableProvider.Context.SaveChanges();
            return Ok(new long[1, 2]);
        }
    }
}
