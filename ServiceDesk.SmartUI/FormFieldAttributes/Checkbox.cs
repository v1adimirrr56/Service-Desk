using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldAttributes
{
    public class Checkbox : FormFieldOptionAttribute
    {
        public Checkbox()
        {

        }
        public Checkbox(Type selector) : base(selector)
        {
        }
    }
}
