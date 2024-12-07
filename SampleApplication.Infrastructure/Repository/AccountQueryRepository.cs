using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using SampleApplication.Domain.Repository;

namespace SampleApplication.Infrastructure.Repository
{
    public class AccountQueryRepository(IQueryDbContext queryContext) : IAccountQueryRepository
    {

        public IQueryable<Account> GetAccountSummaries()
        {
            return queryContext.Accounts;
        }

        public void Dispose()
        {
            queryContext.Dispose();
        }
    }
}
