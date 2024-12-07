using MediatR;
using SampleApplication.BusinessLayer.Dto;

namespace SampleApplication.BusinessLayer.Queries
{
    public class AccountSummariesQuery : IRequest<IQueryable<AccountSummaryDto>>
    {

    }
}
