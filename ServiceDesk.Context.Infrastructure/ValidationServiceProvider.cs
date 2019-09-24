using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Context.Infrastructure
{
    public class ValidationServiceProvider : IServiceProvider
    {
        private IQueryableProvider _provider;
        public ValidationServiceProvider(IQueryableProvider provider)
        {
            _provider = provider;
        }
        public object GetService(Type serviceType)
        {
            return _provider.Context;
        }
    }
}
