using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Context.Infrastructure
{
    public static class ContextValidationHelpers
    {
        public static ICollection<ValidationResult> SaveChangesWithValidations(this IQueryableProvider provider)
        {
            var resultValidation = provider.ExecuteValidation();
            if (resultValidation.Any()) return resultValidation;

            provider.Context.SaveChanges();

            return resultValidation;
        }

        public static ICollection<ValidationResult> ExecuteValidation(this IQueryableProvider provider)
        {
            var errors = new List<ValidationResult>();
            var entries = provider
                .Context
                .ChangeTracker
                .Entries()
                .Where(x => x.State == Microsoft.EntityFrameworkCore.EntityState.Added
                        || x.State == Microsoft.EntityFrameworkCore.EntityState.Modified)
                .ToList();

            foreach (var entry in entries)
            {
                var entity = entry.Entity;
                var validationContext = new ValidationContext(entity);
                var entityErrors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(entity, validationContext, entityErrors))
                    errors.AddRange(entityErrors);
            }

            return errors;
        }
    }
}
