using CarBook.Application.Features.Mediator.Queries.CarPricingQuery;
using CarBook.Application.Features.Mediator.Queries.LocationQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetcarPricingWithCarList()
        {
            var values = await _mediator.Send(new GetCarPricingQuery());
            return Ok(values);
        }
        [HttpGet("GetCarPricingWithTimePeriod1")]
        public async Task<IActionResult> GetCarPricingWithTimePeriod1()
        {
            var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
            return Ok(values);
        }
    }
}
