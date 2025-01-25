using AutoMapper;
using Cars.Application.CarBrands.Commands.CreateBrand;
using Cars.Application.Common.Mappings;
using System;

namespace Cars.WebApi.Models.BrandDto
{
    public class CreateBrandDto : IMapWith<CreateBrandDto>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBrandDto, CreateBrandCommand>()
                .ForMember(brandCommand => brandCommand.Name,
                opt => opt.MapFrom(brandDto => brandDto.Name));
        }
    }
}
