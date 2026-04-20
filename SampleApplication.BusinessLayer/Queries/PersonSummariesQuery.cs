using MediatR;
using SampleApplication.BusinessLayer.Dto;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonSummariesQuery : IRequest<IQueryable<PersonSummaryDto>>
    {

    }
}
