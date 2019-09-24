using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.ActionHandler
{
    public interface IDeleteActionHandler<in TIn, out TOut>: IActionHandler<TIn, TOut>
    {
    }
}
