using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Infrastructure.ActionHandler
{
    public abstract class ActionError
    {
        private readonly ICollection<ValidationResult> _error = new List<ValidationResult>();
        public ICollection<ValidationResult> Errors => _error;
        public bool HasErrors => _error.Any();
        protected void AddError(string errorMessage, params string[] propertyNames)
        {
            _error.Add(new ValidationResult(errorMessage, propertyNames));
        }
    }
}
