using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormAttribute
{
    public class DropdownListAttribute : FormFiledAttribute
    {
        public Type Selector { get; set; }
        public DropdownListAttribute(Type selector)
        {
            Selector = selector;
        }
    }
}
