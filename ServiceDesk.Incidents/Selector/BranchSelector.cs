using ServiceDesk.Incidents.Entities;
using ServiceDesk.Context.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;

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
                .Select(x => new Option { Label = x.ShareType.ToString(), Value = x.Id })
                .ToList();

            return incidentSharedType;
        }
    }
}
