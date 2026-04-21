using MediatR;
using SampleApplication.BusinessLayer.Dto;

namespace SampleApplication.BusinessLayer.Queries
{
    public class PersonByIdQuery(int personId) : IRequest<PersonSummaryDto?>
    {
        public int PersonId { get; } = personId;
    }
}