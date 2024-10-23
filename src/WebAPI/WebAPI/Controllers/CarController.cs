using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Application.Features.Commands.CreateCar;
using OnionApp.Application.Features.Queries.GetAllCars;
using OnionApp.Application.Features.Queries.GetCarById;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator mediator;

        public CarController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllCarQuery();
            return Ok(await mediator.Send(query));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetCarByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCarCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
