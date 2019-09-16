﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SmartUI.FormFieldAttributes
{
    public class FormFieldOptionAttribute : FormFieldAttribute
    {
        protected FormFieldOptionAttribute()
        {

        }
        public Type Selector { get; set; }
        public FormFieldOptionAttribute(Type selector)
        {
            Selector = selector;
        }
    }
}
