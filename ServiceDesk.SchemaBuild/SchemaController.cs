using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Infrastructure;
using ServiceDesk.Context.Infrastructure;
using System.Linq;
using ServiceDesk.SmartUI.FormAttribute;
using ServiceDesk.SmartUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

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
            var assembliesByContext = moduleAssembly.GetAssembliesByContext(context.ToLower());
            var fields = new List<FormField>();
            var properties = assembliesByContext
                .SelectMany(x => x.DefinedTypes)
                .Where(x => x.Name.Contains("Dto"))
                .SelectMany(x => x.DeclaredProperties)
                .ToList();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);
                fields.Add(new FormField
                {
                    NameField = property.Name,
                    Hidden = property.GetCustomAttribute<HiddenInputAttribute>() != null,
                    Label = property.GetCustomAttribute<DisplayAttribute>()?.Name,
                    ReadOnly = property.GetCustomAttribute<ReadOnlyAttribute>()?.IsReadOnly ?? false,
                    Required = property.GetCustomAttribute<RequiredAttribute>() != null,
                    Type = property.GetCustomAttribute<FormFiledAttribute>()?.ToString() ?? FieldType.Input.ToString()
                });

                /*foreach (var attr in property.GetCustomAttributes(true))
                {
                    if (attr is DropdownListAttribute)
                    {
                        var type = ((DropdownListAttribute)attr).Selector;
                        
                    }
                }*/
            }

            return Ok(fields);
        }
    }
}
