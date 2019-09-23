using ServiceDesk.SmartUI.Forms.FormFieldAttributes;
using ServiceDesk.SmartUI.Forms.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder
{
    public class DatePickerBuilder : BuildFormField
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
                Type = FieldType.DatePicker.ToString()
            };

            return formfield;
        }

        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<DatePicker>() != null;
    }
}
