using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.ServiceHandler
{
    public interface IServiceQueryHandler<in TIn, out TOut>
    {
        TOut Handle(TIn input);
    }
}
