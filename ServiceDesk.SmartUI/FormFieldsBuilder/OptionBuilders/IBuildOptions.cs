using ServiceDesk.SmartUI.FormFieldAttributes;
using System.Collections.Generic;

namespace ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders
{
    public interface IBuildOptions
    {
        IEnumerable<Option> BuildOptions(FormFieldOptionAttribute input);
    }
}
