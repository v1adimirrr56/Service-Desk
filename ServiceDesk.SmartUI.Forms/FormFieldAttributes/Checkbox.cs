using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.Forms.FormFieldAttributes
{
    public class Checkbox : FormFieldOptionAttribute
    {
        public Checkbox(): base() { }
        public Checkbox(Type selector) : base(selector) { }
    }
}
