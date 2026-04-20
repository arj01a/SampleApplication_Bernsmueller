using Microsoft.EntityFrameworkCore;
using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using System.Reflection;

namespace SampleApplication.Infrastructure.Context
{
    public class CommandDbContext(DbContextOptions<CommandDbContext> options) : DbContext(options), ICommandDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Person> Persons { get; set; }

        public async Task<int> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
