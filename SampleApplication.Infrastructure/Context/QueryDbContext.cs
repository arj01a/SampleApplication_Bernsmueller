using Microsoft.EntityFrameworkCore;
using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using System.Reflection;

namespace SampleApplication.Infrastructure.Context
{
    public class QueryDbContext : DbContext, IQueryDbContext
    {
        public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options)
        {

        }

        public IQueryable<Account> Accounts => Set<Account>().AsNoTracking();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
