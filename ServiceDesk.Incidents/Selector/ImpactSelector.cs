using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceDesk.Incidents.Selector
{
    public class ImpactSelector : ISelector
    {
        public ICollection<Option> GetOptions(IQueryableProvider provider)
            => provider
            .Context
            .Set<Impact>()
            .Select(x => new Option { Label = x.Name, Value = x.Id })
            .ToList();
    }
}
