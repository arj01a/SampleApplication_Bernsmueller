using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Entities
{
    public class Relation
    {
        public int RelationId { get; private protected set; }
        public int AccountId { get; private protected set; }
        public Account Account { get; private protected set; }
        public int PersonId { get; private protected set; }
        public Person Person { get; private protected set; }
        public short RelationTypeId { get; private protected set; }
        public RelationType RelationType { get; private protected set; }
    }
}
