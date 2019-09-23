using ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.Forms
{
    public class FormField
    {
        public string NameField { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public string Type { get; set; }
        public Validation Validations { get; set; }
        public ShowProperty ShowProperties { get; set; }
    }

    public class ShowProperty
    {
        public bool ReadOnly { get; set; }
        public bool Hidden { get; set; }
        public string Label { get; set; }
    }

    public class Validation
    {
        public bool? Required { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public int? Max { get; set; }
        public int? Min { get; set; }
        public string RegExp { get; set; }

    }

}
