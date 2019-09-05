using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure
{
    public interface IHasId
    {
        long Id { get; set; }
    }
}
