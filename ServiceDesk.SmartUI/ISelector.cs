using AutoMapper;
using ServiceDesk.Context.Infrastructure;
using System.Collections.Generic;

namespace ServiceDesk.SmartUI
{
    public interface ISelector
    {
        ICollection<Option> GetOptions(IQueryableProvider provider);
    }
}
