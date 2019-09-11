using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI
{
    public class FormField
    {
        public string Label { get; set; }
        public string NameField { get; set; }
        public bool Hidden { get; set; }
        public bool ReadOnly { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; }
    }
}
