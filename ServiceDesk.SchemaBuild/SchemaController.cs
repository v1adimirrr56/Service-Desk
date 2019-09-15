using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaController : ServiceDeskBaseController
    {
        [HttpGet("{context}/{schema}")]
        public IActionResult Get(string context, string schema, [FromServices] SchemaHandler schemaHandler)
        {
            return Ok(schemaHandler.Handler(context, schema));
        }
    }
}
