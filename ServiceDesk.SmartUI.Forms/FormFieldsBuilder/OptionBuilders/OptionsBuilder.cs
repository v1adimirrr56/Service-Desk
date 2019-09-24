using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.SmartUI.Forms.FormFieldAttributes;

namespace ServiceDesk.SmartUI.Forms.FormFieldsBuilder.OptionBuilders
{
    public class OptionsBuilder : IBuildOptions
    {
        private readonly IQueryableProvider _queryableProvider;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OptionsBuilder(
            IQueryableProvider queryableProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _queryableProvider = queryableProvider;
            _httpContextAccessor = httpContextAccessor;
        }
        public IEnumerable<Option> BuildOptions(FormFieldOptionAttribute input)
        {
            var selector = (ISelector)_httpContextAccessor.HttpContext.RequestServices.GetService(input.Selector);
            return selector.GetOptions(_queryableProvider);
        }
    }
}
