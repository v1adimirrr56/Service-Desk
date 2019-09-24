using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Infrastructure.Filters
{
    public class FilterConfig
    {
        public ICollection<string> PropertyNames { get; set; }
        public ICollection<string> Values { get; set; }
    }

}
