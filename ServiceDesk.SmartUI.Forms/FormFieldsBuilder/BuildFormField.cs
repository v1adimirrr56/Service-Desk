using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldsFactory
{
    public abstract class BuildFormField
    {
        protected Validation Validations { get; private set; }
        protected ShowProperty ShowProperties { get; private set; }
        protected virtual void BuildValidation(PropertyInfo property)
        {
            Validations = new Validation();
            Validations.Required = property.GetCustomAttribute<RequiredAttribute>() != null;
        }
        protected void BuildShowProperty(PropertyInfo property)
        {
            var showProperties = new ShowProperty();
            showProperties.Hidden = property.GetCustomAttribute<HiddenInputAttribute>() != null;
            showProperties.Label = property.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property.Name;
            showProperties.ReadOnly = property.GetCustomAttribute<ReadOnlyAttribute>()?.IsReadOnly ?? false;
            ShowProperties = showProperties;
        }
        protected string GenerateKey(PropertyInfo property)
            => char.ToLower(property.Name[0]) + property.Name.Substring(1);

        public abstract bool CheckFormFieldType(PropertyInfo property);
        public abstract FormField Build(PropertyInfo property);
    }
}
