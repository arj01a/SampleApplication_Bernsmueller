using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.Domain.Repository;

namespace SampleApplication.BusinessLayer.Queries
{
    public class AccountSummariesQueryHandler(IAccountQueryRepository accountQueryRepository ,IMapper mapper) : IRequestHandler<AccountSummariesQuery, IQueryable<AccountSummaryDto>>
    {
        Task<IQueryable<AccountSummaryDto>> IRequestHandler<AccountSummariesQuery, IQueryable<AccountSummaryDto>>.Handle(AccountSummariesQuery request, CancellationToken cancellationToken)
        {
            var accountSummaries = accountQueryRepository.GetAccountSummaries()
                .ProjectTo<AccountSummaryDto>(mapper.ConfigurationProvider);

            return Task.FromResult(accountSummaries);
        }
    }
}
