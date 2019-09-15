using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Context.Incidents;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure;

namespace TextContext
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
                .Add(new Incident { Name = "Test222" });
            _incidentsQueryableProvider.Context.SaveChanges();
            return Ok(new long[1, 2]);
        }
    }
}
