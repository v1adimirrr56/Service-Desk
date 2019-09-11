using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Infrastructure
{
    public interface IQueryableProvider
    {
        DbContext Context { get; }
    }
}
