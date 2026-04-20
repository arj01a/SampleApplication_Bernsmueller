using MediatR;
using SampleApplication.Domain.Entities;
using SampleApplication.Domain.Repository;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonByIdQueryHandler(IPersonQueryRepository personQueryRepository) : IRequestHandler<PersonByIdQuery, Person?>
    {
        Task<Person?> IRequestHandler<PersonByIdQuery, Person?>.Handle(PersonByIdQuery request, CancellationToken cancellationToken)
        {
            var person = personQueryRepository.GetPersonById(request.PersonId);
            return Task.FromResult(person);
        }
    }
}