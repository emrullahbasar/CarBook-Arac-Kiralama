using CarBook.Application.Features.Mediator.Commands.RezervationCommand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezervationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RezervationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateRezervation(CreateRezervationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Referans Başarıyla Eklendi");
        }
    }
}
