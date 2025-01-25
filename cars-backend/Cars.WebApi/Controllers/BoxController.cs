using AutoMapper;
using Cars.Application.CarBoxes.Commands.CreateBox;
using Cars.Application.CarBoxes.Commands.DeleteBox;
using Cars.Application.CarBoxes.Queries.GetBoxList;
using Cars.WebApi.Models.BoxDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BoxController : BaseController
    {
        private readonly IMapper _mapper;

        public BoxController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<BoxListVm>> GetAll()
        {
            var query = new GetBoxListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }
        
        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBoxDto createBoxDto)
        {
            var command = _mapper.Map<CreateBoxCommand>(createBoxDto);
            var boxId = await Mediator.Send(command);

            return Ok(boxId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteBoxCommand
            {
                Id = id
            };

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
