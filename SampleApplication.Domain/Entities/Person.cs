using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Entities
{
    public class Person
    {
        public int PersonId { get; private protected set; }
        public string FirstName { get; private protected set; }
        public string LastName { get; private protected set; }
    }
}
