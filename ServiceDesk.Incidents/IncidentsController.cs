using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Infrastructure;
using ServiceDesk.Infrastructure.Context;

namespace ServiceDesk.Incidents
{
    public class IncidentsController : ServiceDeskBaseController
    {
        private IIncidentsQueryableProvider _queryableProvider;
        public IncidentsController(IIncidentsQueryableProvider queryableProvider)
        {
            _queryableProvider = queryableProvider;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new long[1 , 2]);
        }
    }
}
