using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.FormAttribute
{
    public class Radio : FormFieldAttribute
    {
        public Type Selector { get; set; }
        public Radio(Type selector)
        {
            Selector = selector;
        }
    }
}
