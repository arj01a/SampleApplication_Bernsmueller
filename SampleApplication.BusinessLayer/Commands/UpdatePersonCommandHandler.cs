using AutoMapper;
using MediatR;
using SampleApplication.Domain.Entities;
using SampleApplication.Domain.Repository;

namespace SampleApplication.BusinessLayer.Commands;

public class UpdatePersonCommandHandler(
    IPersonCommandRepository repository,
    IMapper mapper
    ) : IRequestHandler<UpdatePersonCommand, bool>
{
    public async Task<bool> Handle(
        UpdatePersonCommand request,
        CancellationToken cancellationToken)
    {
        var person = mapper.Map<Person>(request.Person);

        repository.Update(person);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

        return true;
    }
}