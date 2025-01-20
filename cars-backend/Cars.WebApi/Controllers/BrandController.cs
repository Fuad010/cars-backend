
using AutoMapper;
using Cars.Application.CarBrands.Commands.DeleteBrand;
using Cars.Application.CarBrands.Queries.GetBrandList;
using Cars.WebApi.Models.BrandDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cars.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BrandController : BaseController
    {
        private readonly IMapper _mapper;
        public BrandController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<BrandListVm>> GetAll()
        {
            var query = new GetBrandListQuery();
            var vm = await Mediator.Send(query);

            return Ok(vm);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateBrandDto createBrandDto)
        {
            var command = _mapper.Map<CreateBrandDto>(createBrandDto);
            var brandId = await Mediator.Send(command);

            return Ok(brandId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new DeleteBrandCommand
            {
                Id = id
            };

            await Mediator.Send(command);
            return Ok();
        }
    }
}
