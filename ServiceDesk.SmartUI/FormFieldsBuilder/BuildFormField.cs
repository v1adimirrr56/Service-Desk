using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsFactory
{
    public abstract class BuildFormField
    {
        protected Validation Validations { get; private set; } = new Validation();
        protected ShowProperty ShowProperties { get; private set; } = new ShowProperty();
        protected virtual void BuildValidation(PropertyInfo property)
        {
            Validations.Required = property.GetCustomAttribute<RequiredAttribute>() != null;
        }
        protected void BuildShowProperty(PropertyInfo property)
        {
            var showProperties = new ShowProperty();
            showProperties.Hidden = property.Name.EndsWith("Id") || property.GetCustomAttribute<HiddenInputAttribute>() != null;
            showProperties.Label = property.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property.Name;
            showProperties.ReadOnly = property.GetCustomAttribute<ReadOnlyAttribute>()?.IsReadOnly ?? false;
            ShowProperties = showProperties;
        }
        public abstract bool CheckFormFieldType(PropertyInfo input);
        public abstract FormField Build(PropertyInfo input);
    }
}
