using SampleApplication.Domain.Entities;

namespace SampleApplication.Domain.Context
{
    public interface IQueryDbContext : IDisposable
    {
        IQueryable<Account> Accounts { get; }
    }
}
