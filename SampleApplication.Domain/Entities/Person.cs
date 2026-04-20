using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Entities
{
    // IEntity constraint in IQueryRepository;
    // IAggregateRoot constraint in command repo interface
    public class Person(
        int personId,
        string firstName,
        string lastName
        ) : IEntity, IAggregateRoot
    {
        public int PersonId { get; private protected set; } = personId;
        public string FirstName { get; private protected set; } = firstName;
        public string LastName { get; private protected set; } = lastName;
    }
}
