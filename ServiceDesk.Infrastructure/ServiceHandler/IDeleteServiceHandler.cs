using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.ServiceHandler
{
    public interface IDeleteServiceHandler<in TIn>: IServiceHandler<TIn>
    {
    }
}
