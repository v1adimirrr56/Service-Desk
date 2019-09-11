using ServiceDesk.Incidents.Entities;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace ServiceDesk.Incidents.Selector
{
    public class BranchSelector : ISelector
    {
        public ICollection<Option> GetOptions(IQueryableProvider provider)
        {
            var incidentSharedType = provider
                .Context
                .Set<Incident>()
                .Take(2)
                .Select(x => new Option { Label = x.ShareType.ToString(), Value = x.Id.ToString() })
                .ToList();

            return incidentSharedType;
        }
    }
}
