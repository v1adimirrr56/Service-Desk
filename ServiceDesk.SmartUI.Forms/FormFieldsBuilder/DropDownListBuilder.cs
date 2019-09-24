using ServiceDesk.SmartUI.Forms.FormFieldAttributes;
using ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders;
using ServiceDesk.SmartUI.Forms.FormFieldsFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder
{
    public class DropDownListBuilder : FormFieldOptionBuilder
    {
        private IBuildOptions _buildOptions;
        public DropDownListBuilder(IBuildOptions buildOptions)
        {
            _buildOptions = buildOptions;
        }

        public override FormField Build(PropertyInfo property)
        {
            BuildValidation(property);
            BuildFormFieldOptions(property, _buildOptions);
            BuildShowProperty(property);

            FormField formfield = new FormField
            {
                NameField = GenerateKey(property),
                ShowProperties = ShowProperties,
                Validations = Validations,
                Type = FieldType.DropDownList.ToString(),
                Options = Options
            };

            return formfield;
        }

        public override bool CheckFormFieldType(PropertyInfo input)
            => input.GetCustomAttribute<DropDownList>() != null;
    }
}
