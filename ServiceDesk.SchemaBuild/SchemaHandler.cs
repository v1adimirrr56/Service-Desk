using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaHandler
    {
        private readonly IFormFieldsBuilder _formFieldsBuilder;
        private readonly ModuleAssembly _moduleAssembly;
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        private readonly ICrashesQueryableProvider _crashesQueryableProvider;

        public SchemaHandler(
            IIncidentsQueryableProvider incidentsQueryableProvider,
            ICrashesQueryableProvider crashesQueryableProvider,
            IFormFieldsBuilder formFieldsBuilder,
            ModuleAssembly moduleAssembly)
        {
            _formFieldsBuilder = formFieldsBuilder;
            _moduleAssembly = moduleAssembly;
            _crashesQueryableProvider = crashesQueryableProvider;
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }

        public IEnumerable<FormField> Handler(string context, string schema)
        {
            var assembliesByContext = _moduleAssembly.GetAssembliesByContext(context.ToLower());
            var fields = new List<FormField>();
            var properties = assembliesByContext
                .SelectMany(x => x.DefinedTypes)
                .Where(x => x.GetCustomAttribute<FormAttribute>() != null)
                .Single(x => x.Name.StartsWith(schema))
                .GetProperties();
            IQueryableProvider queryableProvider = null;

            if ("incidents" == context.ToLower())
                queryableProvider = _incidentsQueryableProvider;
            if ("crashes" == context.ToLower())
                queryableProvider = _crashesQueryableProvider;
            if (queryableProvider == null)
                throw new Exception($"There is no context the {context}");

            var formFields = _formFieldsBuilder.BuildFormFieldsBySchemaProperty(properties, queryableProvider);

            return formFields;
        }
    }
}
