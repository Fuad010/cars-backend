using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Cars.Application.Cars.Commands.CreaeteCar;
using Cars.Application.Cars.Commands.DeleteCar;
using Cars.Application.Cars.Commands.UpdateCar;
using Cars.Application.Cars.Queries.GetCarDetails;
using Cars.Application.Cars.Queries.GetCarList;
using Cars.WebApi.Models.CarDto;
using System;
using System.Threading.Tasks;
using Cars.Application.CarColors.Queries.GetColorList;
using System.Collections.Generic;

namespace Cars.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CarController : BaseController
    {
        private readonly IMapper _mapper;
        public CarController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CarListVm>> GetAll()
        {
            var query = new GetCarListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDetailsVm>> Get(Guid id)
        {
            var query = new GetCarDetailsQuery
            {
                Id = id,
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromForm] CreateCarDto createCarDto)
        {
            var command = _mapper.Map<CreateCarCommand>(createCarDto);

            if (createCarDto.Images != null && createCarDto.Images.Count > 0)
            {
                command.Images = createCarDto.Images;
            }

            var carId = await Mediator.Send(command);
            return Ok(carId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id,[FromForm] UpdateCarDto updateCarDto)
        {   
            var command = _mapper.Map<UpdateCarCommand>(updateCarDto);
            command.Id = id;

            if (updateCarDto.Images != null && updateCarDto.Images.Count > 0)
            {
                command.Images = updateCarDto.Images;
            }

            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteCarCommand
            {
                Id = id,
            };
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpGet("Сolors")]
        public async Task<ActionResult<CarColorListVm>> GetCarColors()
        {
            var query = new GetCarColorListQuery();
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}
