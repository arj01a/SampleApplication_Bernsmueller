using Microsoft.EntityFrameworkCore;
using SampleApplication.Domain.Entities;

namespace SampleApplication.Domain.Context
{
    public interface ICommandDbContext : IUnitOfWork
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Person> Persons { get; set; }
    }
}
