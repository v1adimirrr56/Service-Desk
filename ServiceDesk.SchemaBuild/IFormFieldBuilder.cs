using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI;
using System.Collections.Generic;
using System.Reflection;

namespace ServiceDesk.SchemaBuild
{
    public interface IFormFieldsBuilder
    {
        IEnumerable<FormField> BuildFormFieldsBySchemaProperty(
            IEnumerable<PropertyInfo> properties,
            IQueryableProvider queryableProvider);
    }
}