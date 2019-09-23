using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Infrastructure.Validations
{
    public class ValidationResultModel
    {
        public string Title { get; private set; }
        public ICollection<ValidationResult> Errors { get; private set; }
        public ValidationResultModel(ICollection<ValidationResult> validationResults)
        {
            Title = "Validation failed";
            Errors = validationResults;
        }
    }
}
