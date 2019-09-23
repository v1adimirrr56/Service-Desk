using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceDesk.Infrastructure.Filters
{
    public static class Filter
    {
        public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, ICollection<FilterConfig> filter)
        {
            throw new Exception('d');
        }
    }
}
