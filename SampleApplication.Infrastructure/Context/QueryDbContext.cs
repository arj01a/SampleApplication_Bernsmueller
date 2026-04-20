using Microsoft.EntityFrameworkCore;
using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using System.Reflection;

namespace SampleApplication.Infrastructure.Context
{
    public class QueryDbContext(DbContextOptions<QueryDbContext> options) : DbContext(options), IQueryDbContext
    {
        public IQueryable<Account> Accounts => Set<Account>().AsNoTracking();

        public IQueryable<Person> Persons => Set<Person>().AsNoTracking();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
