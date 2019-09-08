using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.Context
{
    public interface IQueryableProvider
    {
        DbContext Context { get; }
    }
}
