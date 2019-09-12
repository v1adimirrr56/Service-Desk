using Microsoft.AspNetCore.Mvc.ModelBinding;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Models;
using System;
using System.Threading.Tasks;

namespace ServiceDesk.Incidents
{
    public class IncidentDtoBinder : IModelBinder
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        public IncidentDtoBinder(IIncidentsQueryableProvider incidentsQueryableProvider)
        {
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = "Archive";

            // Try to fetch the value of the argument by name
            var valueProviderResult =
                bindingContext.ValueProvider.GetValue(modelName);
            bindingContext.Result = ModelBindingResult.Failed();
            return Task.FromResult(false);
        }
    }
}
