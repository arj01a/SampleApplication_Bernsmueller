using SampleApplication.Domain.Context;

namespace SampleApplication.Domain.Repository
{
    public interface ICommandRepositor<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
