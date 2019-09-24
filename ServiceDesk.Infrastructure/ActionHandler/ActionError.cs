using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Infrastructure.ActionHandler
{
    public abstract class ActionError
    {
        private readonly ICollection<ValidationResult> _errors = new List<ValidationResult>();
        public ICollection<ValidationResult> Errors => _errors;
        public bool HasErrors => _errors.Any();
        protected void AddError(string errorMessage, params string[] propertyNames)
        {
            _errors.Add(new ValidationResult(errorMessage, propertyNames));
        }
    }
}
