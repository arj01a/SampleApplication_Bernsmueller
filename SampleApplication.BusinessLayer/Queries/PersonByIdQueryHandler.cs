using AutoMapper;
using MediatR;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Repository;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonByIdQueryHandler(
        IPersonQueryRepository personQueryRepository,
        IMapper mapper) : IRequestHandler<PersonByIdQuery, PersonSummaryDto?>
    {
        Task<PersonSummaryDto?> IRequestHandler<PersonByIdQuery, PersonSummaryDto?>.Handle(PersonByIdQuery request, CancellationToken cancellationToken)
        {
            var person = personQueryRepository.GetPersonById(request.PersonId);

            if (person is null)
            {
                return Task.FromResult<PersonSummaryDto?>(null);
            }

            return Task.FromResult(mapper.Map<PersonSummaryDto?>(person));
        }
    }
}