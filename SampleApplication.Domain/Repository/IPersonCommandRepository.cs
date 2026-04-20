using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;

namespace SampleApplication.Domain.Repository
{
    public interface IPersonCommandRepository : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }

        void Update(Person person);
    }
}
