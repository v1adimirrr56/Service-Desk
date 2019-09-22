using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;

namespace ServiceDesk.Incidents
{
    [Route("api/[controller]/Incidents")]
    [ApiController]
    public class IncidentsBaseServiceDeskController: ServiceDeskBaseController
    {
    }
}
