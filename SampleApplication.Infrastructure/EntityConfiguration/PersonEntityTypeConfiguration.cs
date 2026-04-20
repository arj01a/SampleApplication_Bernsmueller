using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleApplication.Domain.Entities;

namespace SampleApplication.Infrastructure.EntityConfiguration
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.HasKey(ac => ac.PersonId);
        }
    }
}
