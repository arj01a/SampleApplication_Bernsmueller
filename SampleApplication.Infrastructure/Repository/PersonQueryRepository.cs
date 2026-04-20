using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using SampleApplication.Domain.Repository;

namespace SampleApplication.Infrastructure.Repository
{
    public class PersonQueryRepository(IQueryDbContext queryContext) : IPersonQueryRepository
    {
        public IQueryable<Person> GetPersonSummaries()
        {
            return queryContext.Persons;
        }

        public Person? GetPersonById(int personId)
        {
            return queryContext.Persons.FirstOrDefault(p => p.PersonId == personId);
        }

        public void Dispose()
        {
            queryContext.Dispose();
        }
    }
}
