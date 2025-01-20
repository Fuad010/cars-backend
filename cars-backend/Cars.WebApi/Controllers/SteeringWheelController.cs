using AutoMapper;
using Cars.Application.CarSteeringWheels.Commands.CreateSteeringWheel;
using Cars.Application.CarSteeringWheels.Commands.DeleteSteeringWheel;
using Cars.Application.CarSteeringWheels.Queries;
using Cars.Domain.Car;
using Cars.WebApi.Models.SteeringWheelDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("asp/[controller]")]
    public class SteeringWheelController : BaseController
    {
        private readonly IMapper _mapper;

        public SteeringWheelController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<SteeringWheelListVm>> GetAll()
        {
            var query = new GetSteeringWheelListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateSteeringWheelDto createSteeringWheelDto)
        {
            var command = _mapper.Map<CreateSteeringWheelCommand>(createSteeringWheelDto);
            var steeringWheelId = await Mediator.Send(command);

            return Ok(steeringWheelId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteSteeringWheelCommand
            {
                Id = id
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
