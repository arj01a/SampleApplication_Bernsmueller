using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.BusinessLayer.Queries;

namespace SampleApplication.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(ILogger<AccountController> logger, IMediator mediator) : Controller
    {
        [HttpGet(Name = "GetAccountSummary")]
        public async Task<IActionResult> GetAccountSummaries()
        {
            var accounts = await mediator.Send(new AccountSummariesQuery());
            return Json(accounts);
        }
    }
}
