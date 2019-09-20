using ServiceDesk.SmartUI.FormFieldAttributes;
using ServiceDesk.SmartUI.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders
{
    public abstract class FormFieldOptionBuilder: BuildFormField
    {
        protected ICollection<Option> Options { get; private set; } = new List<Option>();
        public virtual void BuildFormFieldOptions(PropertyInfo property, IBuildOptions buildOptions = null)
        {
            if (property.PropertyType.IsEnum)
                BuildFormFieldEnumOptions(property);
            else if (buildOptions != null)
                BuildFormFieldSelectorOptions(property, buildOptions);
            else
                throw new ArgumentException($"You haven't specified selector for the {property.Name}");

        }

        private void BuildFormFieldSelectorOptions(PropertyInfo property, IBuildOptions buildOptions)
        {
            var options = new List<Option>();
            var attribute = (FormFieldOptionAttribute)Attribute.GetCustomAttribute(property, typeof(FormFieldOptionAttribute));
            options.AddRange(buildOptions.BuildOptions(attribute));
            Options = options;
        }

        private void BuildFormFieldEnumOptions(PropertyInfo property)
        {
            var options = new List<Option>();

            var fieldsEnum = property.PropertyType.GetFields().Where(x => x.IsLiteral).ToList();
            foreach (var field in fieldsEnum)
            {
                options.Add(new Option
                {
                    Label = field.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? field.Name,
                    Value = Convert.ToInt64(field.GetRawConstantValue()),
                });
            }

            Options = options;
        }
    }
}
