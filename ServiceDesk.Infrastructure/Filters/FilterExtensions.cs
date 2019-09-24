using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace ServiceDesk.Infrastructure.Filters
{
    public static class FilterExtensions
    {
        public static IQueryable<T> Filter<T>(this IQueryable<T> queryable, FilterConfig filter)
        {
            if (filter == null || filter.PropertyNames == null || filter.Values == null)
                return queryable;

            var parameter = Expression.Parameter(typeof(T));
            Expression resultExpression = null;
            for (int i = 0; i < filter.PropertyNames.Count; i++)
            {
                var propertyName = filter.PropertyNames.ElementAt(i);
                var propertyValue = filter.Values.ElementAt(i);
                if (string.IsNullOrEmpty(propertyValue))
                    continue;

                var prop = Expression.Property(parameter, propertyName);
                var value = Expression.Constant(propertyValue);
                var expressionBody = Expression.Call(prop, StartsWith, value);

                if (resultExpression == null)
                {
                    resultExpression = expressionBody;
                }
                else
                {
                    resultExpression = Expression.And(resultExpression, expressionBody);
                }
            }
            Expression<Func<T, bool>> expression = null;
            if (resultExpression != null)
                expression = Expression.Lambda<Func<T, bool>>(resultExpression, parameter);
            return expression != null ? queryable.Where(expression) : queryable;
        }

        private static MethodInfo StartsWith = typeof(string).GetMethod(nameof(StartsWith), new Type[]
        {
            typeof(string)
        });
    }
}
