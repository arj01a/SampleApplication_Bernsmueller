namespace SampleApplication.Domain.Context
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveEntitiesAysnc(CancellationToken cancellationToken = default);
    }
}
