using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.ServiceHandler
{
    public interface IEditServiceHandler<in TIn>: IServiceHandler<TIn>
    {
    }
}
