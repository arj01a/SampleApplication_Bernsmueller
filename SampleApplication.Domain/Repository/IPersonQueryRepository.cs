using SampleApplication.Domain.Context;
using SampleApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Repository
{
    public interface IPersonQueryRepository : IQueryRespository<Person>
    {
        IQueryable<Person> GetPersonSummaries();
        Person? GetPersonById(int personId);
    }
}
