namespace ServiceDesk.Infrastructure.Handlers
{
    public interface IQueryHandler<in TIn, out TOut>
    {
        TOut Handler(TIn input);
    }
}
