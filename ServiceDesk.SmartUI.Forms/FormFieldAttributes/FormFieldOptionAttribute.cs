using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldAttributes
{
    public class FormFieldOptionAttribute : FormFieldAttribute
    {
        public FormFieldOptionAttribute() { }
        public Type Selector { get; set; }
        public FormFieldOptionAttribute(Type selector)
        {
            Selector = selector;
        }
    }
}
