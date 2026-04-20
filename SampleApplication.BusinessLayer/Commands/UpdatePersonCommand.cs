using MediatR;
using SampleApplication.BusinessLayer.Dto;

namespace SampleApplication.BusinessLayer.Commands;

public record UpdatePersonCommand(PersonUpdateDto Person) : IRequest<bool>;
