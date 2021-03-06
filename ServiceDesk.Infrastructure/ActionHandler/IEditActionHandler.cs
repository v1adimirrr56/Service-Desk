﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Infrastructure.ActionHandler
{
    public interface IEditActionHandler<in TIn, out TOut> : IActionHandler<TIn, TOut>
    {
    }
}
