using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.FormAttribute
{
    public class RadioAttribute : FormFiledAttribute
    {
        public Type Selector { get; set; }
        public RadioAttribute(Type selector)
        {
            Selector = selector;
        }
    }
}
