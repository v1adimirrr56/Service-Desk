using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI
{
    public class FormField
    {
        public string Label { get; set; }
        public string NameField { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public string Type { get; set; }
        public Validation Validation { get; set; }
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
