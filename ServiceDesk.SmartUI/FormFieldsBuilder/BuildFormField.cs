using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsFactory
{
    public abstract class BuildFormField
    {
        protected Validation Validations { get; set; } = new Validation();
        protected virtual void BuildValidation(PropertyInfo property)
        {
            Validations.Required = property.GetCustomAttribute<RequiredAttribute>() == null ? false : true;
        }
        public abstract bool CheckFormFieldType(PropertyInfo input);
        public abstract FormField Build(PropertyInfo input);
    }
}
