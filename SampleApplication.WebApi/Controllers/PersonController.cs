using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.BusinessLayer.Commands;
using SampleApplication.BusinessLayer.Dto;
using SampleApplication.BusinessLayer.Queries;

namespace SampleApplication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController(ILogger<PersonController> logger, IMediator mediator) : Controller
    {
        [HttpGet(Name = "GetPerson")]
        public async Task<IActionResult> GetPersons()
        {
            var persons = await mediator.Send(new PersonSummariesQuery());
            return Json(persons);
        }

        [HttpGet("{personId}", Name = "GetPersonById")]
        public async Task<IActionResult> GetPersonById(int personId)
        {
            var person = await mediator.Send(new PersonByIdQuery(personId));
            
            return person != null ? Json(person) : NotFound();
        }

        [HttpPut(Name = "UpdatePerson")]
        public async Task<IActionResult> UpdatePerson([FromBody] PersonUpdateDto personUpdateDto)
        {
            logger.LogInformation("Updating person with id: {personId}", personUpdateDto.PersonId);

            var success = await mediator.Send(new UpdatePersonCommand(personUpdateDto));

            return success ? Ok() : NotFound();
        }
    }
}
