using AutoMapper;
using Cars.Application.CarBodies.Commands.CreateBody;
using Cars.Application.CarBodies.Commands.DeleteBody;
using Cars.Application.CarBodies.Queries.GetBodyList;
using Cars.WebApi.Models.BodyDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BodyController:BaseController
    {
        private readonly IMapper _mapper;

        public BodyController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<BodyListVm>> GetAll()
        {
            var query = new GetBodyListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBodyDto createBodyDto)
        {
            var command = _mapper.Map<CreateBodyCommand>(createBodyDto);
            var bodyId = await Mediator.Send(command);

            return Ok(bodyId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteBodyCommand
            {
                Id = id
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
