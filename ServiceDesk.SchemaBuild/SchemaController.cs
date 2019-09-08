using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;
using ServiceDesk.Infrastructure.Context;
using System.Linq;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaController : ServiceDeskBaseController
    {
        readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        public SchemaController(IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }

        [HttpGet("{context}/{schema}")]
        public IActionResult Get(string context, string schema,[FromServices] ModuleAssembly moduleAssembly)
        {
            var allContexts = moduleAssembly;
            /*if (allContexts.ContainsKey(context.ToLower()))
            {
                var dto = allContexts[schema].DefinedTypes.Single(x => x.Name.Contains("Dto"));
                var properties = dto.DeclaredProperties;

                var ff = properties
                    .SelectMany(x =>
                        x.GetCustomAttributes(true)
                        .OfType<FromAttribute>()
                        .Select(y => new FormField
                        {
                            Label = x.Name,
                            Name = y.DisplayName,
                            Type = y.Type.ToString(),
                            DefaultValue = y.DefaultValue
                        })
                    );

                return Ok(ff);
            }*/

            return BadRequest();
        }
    }
}
