using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Repository;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonSummariesQueryHandler(IPersonQueryRepository personQueryRepository ,IMapper mapper) : IRequestHandler<PersonSummariesQuery, IQueryable<PersonSummaryDto>>
    {
        Task<IQueryable<PersonSummaryDto>> IRequestHandler<PersonSummariesQuery, IQueryable<PersonSummaryDto>>.Handle(PersonSummariesQuery request, CancellationToken cancellationToken)
        {
            var personSummaries = personQueryRepository.GetPersonSummaries()
                .ProjectTo<PersonSummaryDto>(mapper.ConfigurationProvider);

            return Task.FromResult(personSummaries);
        }
    }
}
