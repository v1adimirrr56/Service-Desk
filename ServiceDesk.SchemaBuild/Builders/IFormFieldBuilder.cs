using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace ServiceDesk.SchemaBuild.Builders
{
    public interface IFormFieldsBuilder
    {
        IEnumerable<FormField> BuildFormFieldsBySchemaProperty(
            IEnumerable<PropertyInfo> properties,
            IQueryableProvider queryableProvider);
    }
}