using ServiceDesk.SmartUI.FormFieldAttributes;
using ServiceDesk.SmartUI.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsBuilder
{
    public class InputBuilder : BuildFormField
    {
        public override FormField Build(PropertyInfo property)
        {
            BuildValidation(property);
            FormField formfield = new FormField
            {
                NameField = property.Name,
                Label = property.GetCustomAttribute<DisplayAttribute>()?.Name ?? property.Name,
                Validation = Validations,
                Type = FieldType.Input.ToString()
            };

            return formfield;
        }

        protected override void BuildValidation(PropertyInfo property)
        {
            base.BuildValidation(property);
            if (property.PropertyType.GetType().IsNumberType())
            {
                Validations.Max = (int?)property.GetCustomAttribute<RangeAttribute>()?.Maximum;
                Validations.Min = (int?)property.GetCustomAttribute<RangeAttribute>()?.Minimum;
            }
            else
            {
                Validations.MaxLength = property.GetCustomAttribute<MaxLengthAttribute>()?.Length;
                Validations.MinLength = property.GetCustomAttribute<MinLengthAttribute>()?.Length;
                Validations.RegExp = property.GetCustomAttribute<RegularExpressionAttribute>()?.Pattern;
            }
        }

        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<Input>() == null ? false : true;
    }
}
