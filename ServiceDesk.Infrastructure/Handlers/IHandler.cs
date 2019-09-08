namespace ServiceDesk.Infrastructure.Handlers
{
    public interface IHandler<in TIn>
    {
        void Handler(TIn input);
    }
}
