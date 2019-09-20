
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Infrastructure.ServiceHandler
{
    public interface IServiceHandler<in TIn>
    {
        ICollection<ValidationResult> Errors { get; }
        bool HasError { get; }
        void Handle(TIn input);
    }
}
