using AutoMapper;
using ServiceDesk.Context.Infrastructure;
using System.Collections.Generic;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders
{
    public interface ISelector
    {
        ICollection<Option> GetOptions(IQueryableProvider provider);
    }
}
