using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Infrastructure.ActionHandler
{
    public interface IActionHandler<in TIn, out TOut>
    {
        ICollection<ValidationResult> Errors { get; }
        bool HasErrors { get; }
        TOut Action(TIn input);
    }
}
