using ServiceDesk.SmartUI.FormFieldAttributes;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using ServiceDesk.SmartUI.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsBuilder
{
    public class CheckboxBuilder : FormFieldOptionBuilder
    {
        public CheckboxBuilder()
        {
        }

        public override FormField Build(PropertyInfo property)
        {
            if (!property.PropertyType.IsEnum)
                throw new Exception("Checkbox has te be the enum type");

            BuildValidation(property);
            BuildFormFieldOptions(property);
            BuildShowProperty(property);

            FormField formfield = new FormField
            {
                NameField = char.ToLower(property.Name[0]) + property.Name.Substring(1),
                ShowProperties = ShowProperties,
                Validations = Validations,
                Type = FieldType.Checkbox.ToString(),
                Options = Options
            };

            return formfield;
        }


        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<Checkbox>() != null;

    }
}
