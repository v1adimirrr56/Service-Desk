﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldAttributes
{
    public class DropDownList : FormFieldOptionAttribute
    {
        public DropDownList(): base() { }
        public DropDownList(Type type): base(type) { }
    }
}
