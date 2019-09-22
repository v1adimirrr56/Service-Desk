using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Infrastructure.Validations
{
    public class ValidationResultModel
    {
        public string Title { get; private set; }
        public IEnumerable<ValidationResult> Errors { get; private set; }
        public ValidationResultModel(IEnumerable<ValidationResult> errors)
        {

        }
    }
}
