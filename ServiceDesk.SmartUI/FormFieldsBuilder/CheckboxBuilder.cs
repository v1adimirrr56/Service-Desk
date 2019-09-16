using ServiceDesk.SmartUI.FormFieldAttributes;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using ServiceDesk.SmartUI.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsBuilder
{
    public class CheckboxBuilder : BuildFormField
    {
        public CheckboxBuilder()
        {
        }

        public override FormField Build(PropertyInfo property)
        {
            BuildValidation(property);
            if (!property.PropertyType.IsEnum)
                throw new Exception("Checkbox has te be the enum type");

            var options = new List<Option>();
            var fieldsEnum = property.PropertyType.GetFields().Where(x => x.IsLiteral).ToList();
            foreach (var field in fieldsEnum)
            {
                options.Add(new Option
                {
                    Label = field.Name,
                    Value = Convert.ToInt64(field.GetRawConstantValue()),
                });
            }
            


            FormField formfield = new FormField
            {
                NameField = property.Name,
                Label = property.GetCustomAttribute<DisplayAttribute>()?.Name ?? property.Name,
                Validation = Validations,
                Type = FieldType.Checkbox.ToString(),
                Options = options
            };

            return formfield;
        }


        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<Checkbox>() == null ? false : true;

    }
}
