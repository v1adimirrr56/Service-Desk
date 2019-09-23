using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;

namespace ServiceDesk.Incidents
{
    [Route("api/Incidents/[controller]")]
    [ApiController]
    public class IncidentsBaseServiceDeskController: ServiceDeskBaseController
    {
    }
}
