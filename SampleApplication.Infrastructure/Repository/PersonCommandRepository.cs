using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using SampleApplication.Domain.Repository;

namespace SampleApplication.Infrastructure.Repository
{
    public class PersonCommandRepository(ICommandDbContext commandContext) : IPersonCommandRepository
    {
        public IUnitOfWork UnitOfWork => commandContext;

        public void Update(Person person) => commandContext.Persons.Update(person);
    }
}