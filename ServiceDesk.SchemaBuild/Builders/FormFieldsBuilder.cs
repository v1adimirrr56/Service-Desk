using Microsoft.AspNetCore.Http;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI.Forms;
using ServiceDesk.SmartUI.Forms.FormFieldsBuilder;
using ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders;
using ServiceDesk.SmartUI.Forms.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SchemaBuild.Builders
{
    public class FormFieldsBuilder : IFormFieldsBuilder
    {
        private BuildFormField _defaultInputBuilder = new InputBuilder();
        private ICollection<BuildFormField> _factoryFormFields { get; set; }
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FormFieldsBuilder(
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<FormField> BuildFormFieldsBySchemaProperty(
            IEnumerable<PropertyInfo> properties,
            IQueryableProvider queryableProvider)
        {
            var formFields = new List<FormField>();
            InitializeFormFieldBuilders(queryableProvider);
            foreach (var property in properties)
            {
                var formFieldConfig = _factoryFormFields.SingleOrDefault(x => x.CheckFormFieldType(property));
                if (formFieldConfig != null)
                    formFields.Add(formFieldConfig.Build(property));
                else
                    formFields.Add(_defaultInputBuilder.Build(property));
            }

            return formFields;
        }

        private void InitializeFormFieldBuilders(IQueryableProvider queryableProvider)
        {
            _factoryFormFields = new List<BuildFormField>
            {
                new CheckboxBuilder(),
                new DatePickerBuilder(),
                new DropDownListBuilder(new OptionsBuilder(queryableProvider, _httpContextAccessor)),
                new RadioBuilder(new OptionsBuilder(queryableProvider, _httpContextAccessor)),
                new InputBuilder()
            };
        }
    }
}
