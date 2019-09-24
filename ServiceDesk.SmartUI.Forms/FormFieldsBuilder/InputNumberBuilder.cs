using ServiceDesk.SmartUI.Forms.FormFieldAttributes;
using ServiceDesk.SmartUI.Forms.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder
{
    public class InputNumberBuilder : BuildFormField
    {
        public override FormField Build(PropertyInfo property)
        {
            BuildValidation(property);
            BuildShowProperty(property);

            FormField formfield = new FormField
            {
                NameField = GenerateKey(property),
                ShowProperties = ShowProperties,
                Validations = Validations,
                Type = FieldType.InputNumber.ToString()
            };

            return formfield;
        }

        protected override void BuildValidation(PropertyInfo property)
        {
            base.BuildValidation(property);
            Validations.Max = (int?)property.GetCustomAttribute<RangeAttribute>()?.Maximum;
            Validations.Min = (int?)property.GetCustomAttribute<RangeAttribute>()?.Minimum;
        }

        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<InputNumber>() != null;
    }
}
