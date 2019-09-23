using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SchemaBuild.Builders;
using ServiceDesk.SchemaBuild.Loaders;
using ServiceDesk.SmartUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SchemaBuild
{
    public class SchemaFormsHandler
    {
        private readonly IFormFieldsBuilder _formFieldsBuilder;
        private readonly ModelLoader _modelLoader;
        private readonly ContextLoader _contextLoader;

        public SchemaFormsHandler(
            ContextLoader contextLoader,
            IFormFieldsBuilder formFieldsBuilder,
            ModelLoader modelLoader)
        {
            _formFieldsBuilder = formFieldsBuilder;
            _modelLoader = modelLoader;
            _contextLoader = contextLoader;
        }

        public IEnumerable<FormField> Handler(string context, string schema)
        {
            var properties = _modelLoader.LoadModel<FormAttribute>(context, schema);
            IQueryableProvider queryableProvider = _contextLoader.Load(context);

            var formFields = _formFieldsBuilder.BuildFormFieldsBySchemaProperty(properties, queryableProvider);

            return formFields;
        }
    }
}
