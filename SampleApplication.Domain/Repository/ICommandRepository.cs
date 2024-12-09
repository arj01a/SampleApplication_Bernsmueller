using SampleApplication.Domain.Context;

namespace SampleApplication.Domain.Repository
{
    public interface ICommandRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
