using ServiceDesk.SmartUI.Forms.FormFieldAttributes;
using System.Collections.Generic;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders
{
    public interface IBuildOptions
    {
        IEnumerable<Option> BuildOptions(FormFieldOptionAttribute input);
    }
}
