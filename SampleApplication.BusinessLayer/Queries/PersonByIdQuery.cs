using MediatR;
using SampleApplication.Domain.Entities;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonByIdQuery(int personId) : IRequest<Person?>
    {
        public int PersonId { get; } = personId;
    }
}