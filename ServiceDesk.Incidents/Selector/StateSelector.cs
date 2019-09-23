using ServiceDesk.Incidents.Entities;
using ServiceDesk.Context.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders;

namespace ServiceDesk.Incidents.Selector
{
    public class StateSelector : ISelector
    {
        public ICollection<Option> GetOptions(IQueryableProvider provider)
            => provider
            .Context
            .Set<State>()
            .Select(x => new Option { Label = x.Name, Value = x.Id })
            .ToList();
    }
}
