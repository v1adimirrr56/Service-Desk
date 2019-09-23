using ServiceDesk.Context.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.SchemaBuild.Loaders
{
    public class ContextLoader
    {
        private readonly IIncidentsQueryableProvider _incidentsQueryableProvider;
        private readonly ICrashesQueryableProvider _crashesQueryableProvider;

        public ContextLoader(
            IIncidentsQueryableProvider incidentsQueryableProvider,
            ICrashesQueryableProvider crashesQueryableProvider)
        {
            _crashesQueryableProvider = crashesQueryableProvider;
            _incidentsQueryableProvider = incidentsQueryableProvider;
        }
        public IQueryableProvider Load(string context)
        {
            if ("incidents" == context.ToLower())
                return _incidentsQueryableProvider;
            if ("crashes" == context.ToLower())
                return _crashesQueryableProvider;

            throw new Exception($"There is no context the {context}");
        }
    }
}
