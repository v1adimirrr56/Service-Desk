using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormAttribute
{
    public class DropDownList : FormFieldAttribute
    {
        public Type Selector { get; set; }
        public DropDownList(Type selector)
        {
            Selector = selector;
        }
    }
}
