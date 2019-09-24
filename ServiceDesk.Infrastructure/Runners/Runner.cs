using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Infrastructure.ActionHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Infrastructure.Runners
{
    public class Runner<Tin, TOut>
    {
        public ICollection<ValidationResult> Errors { get; private set; }
        public bool HasErrors => Errors.Any();
        private readonly IActionHandler<Tin, TOut> _actionHandler;
        private readonly IQueryableProvider _provider;
        public Runner(IActionHandler<Tin, TOut> actionHandler, IQueryableProvider provider)
        {
            _actionHandler = actionHandler;
            _provider = provider;
        }
        
        public TOut Run(Tin input)
        {
            var result = _actionHandler.Action(input);
            Errors = _actionHandler.Errors;
            if (!HasErrors)
                Errors = _provider.SaveChangesWithValidations();

            return result;
        } 
    }
}
