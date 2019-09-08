using System.Threading;

namespace ServiceDesk.Infrastructure.Handlers
{
    public interface IQueryHandlerAsync<in TIn, out TOut>
    {
        TOut Handler(TIn input, CancellationToken ct = default);
    }
}
