namespace SampleApplication.Domain.Context
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveEntitiesAsync(CancellationToken cancellationToken = default);
    }
}
