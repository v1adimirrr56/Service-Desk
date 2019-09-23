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
        private readonly IServiceQueryHandler<ICollection<FilterConfig>, IEnumerable<IncidentList>> _getAllIncidentList;
        public IncidentsListController(
            IServiceQueryHandler<ICollection<FilterConfig>, IEnumerable<IncidentList>> getAllIncidentList)
        {
            _getAllIncidentList = getAllIncidentList;
        }

        [HttpGet]
        public IActionResult GetAll(ICollection<FilterConfig> filterConfigs)
        {
            return Ok(_getAllIncidentList.Handle(filterConfigs));
        }

    }
}
