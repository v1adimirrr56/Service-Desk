using System.Threading;

namespace ServiceDesk.Infrastructure.Handlers
{
    public interface IHandlerAsync<in TIn>
    {
        void Handlers(TIn input, CancellationToken ct = default);
    }
}
