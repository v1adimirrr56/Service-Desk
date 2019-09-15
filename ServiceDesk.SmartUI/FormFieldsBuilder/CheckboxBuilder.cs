using ServiceDesk.SmartUI.FormFieldAttributes;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using ServiceDesk.SmartUI.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldsBuilder
{
    public class CheckboxBuilder : BuildFormField
    {
        private IBuildOptions _buildOptions;
        public CheckboxBuilder(IBuildOptions buildOptions)
        {
            _buildOptions = buildOptions;
        }

        public override FormField Build(PropertyInfo property)
        {
            BuildValidation(property);
            FormField formfield = new FormField
            {
                NameField = property.Name,
                Label = property.GetCustomAttribute<DisplayAttribute>()?.Name ?? property.Name,
                Validation = Validations,
                Type = FieldType.Checkbox.ToString(),
                Options = _buildOptions.BuildOptions(property.GetCustomAttribute<Checkbox>())
            };

            return formfield;
        }


        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<Checkbox>() == null ? false : true;

    }
}
