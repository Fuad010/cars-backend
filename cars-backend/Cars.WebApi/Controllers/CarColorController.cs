using AutoMapper;
using Cars.Application.CarColors.Commands.CreateColor;
using Cars.Application.CarColors.Commands.DeleteColor;
using Cars.Application.CarColors.Queries.GetColorList;
using Cars.WebApi.Models.BodyDto;
using Cars.WebApi.Models.CarColorDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("asp/[controller]")]
    public class CarColorController : BaseController
    {
        private readonly IMapper _mapper;

        public CarColorController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CarColorListVm>> GetAll()
        {
            var query = new GetCarColorListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCarColorDto createCarColorDto)
        {
            var command = _mapper.Map<CreateCarColorCommand>(createCarColorDto);
            var carColorId = await Mediator.Send(command);

            return Ok(carColorId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteCarColorCommand
            {
                Id = id
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
