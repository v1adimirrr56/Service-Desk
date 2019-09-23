using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaController : ServiceDeskBaseController
    {
        [HttpGet("{context}/{schema}/Forms")]
        public IActionResult GetForm(string context, string schema, [FromServices] SchemaFormsHandler schemaFormsHandler)
        {
            return Ok(schemaFormsHandler.Handler(context, schema));
        }

        [HttpGet("{context}/{schema}/Grids")]
        public IActionResult GetGrid(string context, string schema, [FromServices] SchemaGridsHandler schemaGridsHandler)
        {
            return Ok(schemaGridsHandler.Handle(context, schema));
        }
    }
}
